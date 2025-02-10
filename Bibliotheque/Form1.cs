using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Reflection;
using System.Security.Principal;

namespace Bibliotheque
{
    public partial class Form1 : Form
    {
        private List<Livre> livres = new List<Livre>();
        private Utilisateur utilisateur;
        private List<Utilisateur> utilisateurs = new List<Utilisateur>();
        public Form1()
        {
            InitializeComponent();
            LivresParDefaut();
            utilisateur = new Utilisateur("Haotong", "CHEN", "HC@163.com");
            utilisateurs.Add(utilisateur);
            LoadData();
        }

        private void LivresParDefaut()
        {
            // Creez des livres par ddfaut et ajoutez-les a la liste
            livres.Add(new Livre("Sherlock Holmes", "Conan Doyle", new DateTime(2017, 6, 1), "10 7533284267", new Categorie(TypeCategorie.Suspense)));
            livres.Add(new Livre("Test1", "CCC", new DateTime(1999, 3, 1), "54985165", new Categorie(TypeCategorie.Histoire)));
            livres.Add(new Livre("Test2", "TTT", new DateTime(1999, 4, 1), "874974897", new Categorie(TypeCategorie.Science)));
        }
        private void AfficherTousLesLivres()
        {
            listLivre.Items.Clear(); // Effacez la zone de liste

            foreach (var livre in livres)
            {
                // Ajouter des informations pour chaque livre a la zone de liste
                listLivre.Items.Add($"{livre.Titre}, {livre.Auteur}, {livre.DateDePublication:yyyy-MM-dd},ISBN: {livre.ISBN}, Disponible: {livre.EstDisponible}, {livre.Categorie.Nom}");
            }

            if (livres.Count == 0)
            {
                MessageBox.Show("Aucun livre ¨¤ afficher.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void AfficherTousLesUtilisateurs()
        {
            listUser.Items.Clear(); // Çå¿ÕÁÐ±í¿ò

            foreach (var utilisateur in utilisateurs)
            {
                listUser.Items.Add($"{utilisateur.Nom} {utilisateur.Prenom}, e-mail: {utilisateur.Email}, Date d'inscription: {utilisateur.DateInscription:yyyy-MM-dd}");
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string titre = textTitre.Text;
            string auteur = textAuteur.Text;
            DateTime dateDePublication = Convert.ToDateTime(textDatePublic.Text);
            string isbn = textISBN.Text;
            Categorie categorie = new Categorie((TypeCategorie)Enum.Parse(typeof(TypeCategorie), textCategorie.Text));

            Livre livre = new Livre(titre, auteur, dateDePublication, isbn, categorie);
            livres.Add(livre);
            listLivre.Items.Add($"{livre.Titre}, {livre.Auteur}, {livre.DateDePublication:yyyy-MM-dd},ISBN: {livre.ISBN}, Disponible: {livre.EstDisponible}, {livre.Categorie.Nom}");

            textTitre.Clear();
            textAuteur.Clear();
            textDatePublic.Clear();
            textISBN.Clear();
            textCategorie.Clear();

        }

        private void AjouterUser_Click(object sender, EventArgs e)
        {
            string nom = textNom.Text;
            string prenom = textPrenom.Text;
            string email = textEmail.Text;

            Utilisateur newUtilisateur = new Utilisateur(nom, prenom, email);

            utilisateurs.Add(newUtilisateur);

            AfficherTousLesUtilisateurs();

            textNom.Clear();
            textPrenom.Clear();
            textEmail.Clear();
        }

        private void AfficherLivre_Click(object sender, EventArgs e)
        {
            AfficherTousLesLivres();
        }

        private void AfficherUser_Click(object sender, EventArgs e)
        {
            AfficherTousLesUtilisateurs();
        }

        private void Emprunter_Click(object sender, EventArgs e)
        {
            string isbn = ISBNsearch.Text;
            Livre? livre = livres.FirstOrDefault(l => l.ISBN == isbn);

            if (livre != null)
            {
                try
                {
                    utilisateur.EmprunterLivre(livre);

                    // Affiche un message indiquant que l'emprunt a ete fructueux
                    MessageBox.Show($"¡¶{livre.Titre}¡·Emprunt¨¦ avec succ¨¨s£¡", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Si le livre n'est pas disponible a l'emprunt, un message d'exception s'affiche
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ce livre n¡¯a pas ¨¦t¨¦ retrouv¨¦£¡", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rendre_Click(object sender, EventArgs e)
        {
            string isbn = ISBNsearch.Text;
            Livre? livre = livres.FirstOrDefault(l => l.ISBN == isbn);

            if (livre != null)
            {
                try
                {
                    utilisateur.RendreLivre(livre);

                    // Affiche un message indiquant que le retour a reussi
                    MessageBox.Show($"¡¶{livre.Titre}¡·rendu avec succ¨¨s£¡", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Si le livre ne figure pas dans la liste d'emprunt de l'utilisateur, un message d'exception s'affiche
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ce livre n¡¯a pas ¨¦t¨¦ retrouv¨¦£¡", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            int maxAttempts = 3;
            int attemptCount = 0;

            // Configurez le mot de passe correct
            string correctPassword = "test";  
            bool passwordVerified = false;
            try
            {
                string fileName = "BibliothequeData.json.enc";

                // obtenir la cl¨¦ de chiffrement
                string key = GetEncryptionKey();

                // crypter le fichier
                Cryptage.DecryptFile(fileName, key);

                // charger les donn¨¦es
                while (attemptCount < maxAttempts && !passwordVerified)
                {
                    string userInput = Microsoft.VisualBasic.Interaction.InputBox("Veuillez entrer le mot de passe pour charger les donn¨¦es", "V¨¦rification du mot de passe", "", -1, -1);

                    if (userInput == correctPassword)
                    {
                        passwordVerified = true;
                        break;
                    }
                    else
                    {
                        attemptCount++;
                        MessageBox.Show($"Mauvais mot de passe ! Le nombre de tentatives restantes£º{maxAttempts - attemptCount}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // si le nombre de tentatives est d¨¦pass¨¦, supprimez le fichier
                if (attemptCount >= maxAttempts)
                {
                    MessageBox.Show("Vous avez d¨¦pass¨¦ le nombre maximum de tentatives et le fichier sera supprim¨¦ !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    try
                    {
                        if (File.Exists("BibliothequeData.json"))
                        {
                            File.Delete("BibliothequeData.json");
                            MessageBox.Show($"Le fichier {"BibliothequeData.json"} a ¨¦t¨¦ supprim¨¦£¡", "Suppression de fichiers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Une erreur s¡¯est produite lors de la suppression du fichier: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return; 
                }

                // Si le mot de passe est correct, chargez les donn¨¦es
                try
                {
                    Bibliotheque loadedBibliotheque = Bibliotheque.Deserialize("BibliothequeData.json");

                    livres = loadedBibliotheque.Livres;
                    utilisateurs = loadedBibliotheque.Utilisateurs;

                    AfficherTousLesLivres();
                    AfficherTousLesUtilisateurs();
                    MessageBox.Show("Les donn¨¦es ont ¨¦t¨¦ charg¨¦es avec succ¨¨s£¡", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur s¡¯est produite lors du chargement des donn¨¦es: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s¡¯est produite lors du chargement des donn¨¦es: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // obtenir la cl¨¦ de chiffrement
        private string GetEncryptionKey()
        {
            string key = Microsoft.VisualBasic.Interaction.InputBox("Veuillez saisir la cl¨¦ de cryptage", "Cl¨¦s de chiffrement");

            if (string.IsNullOrEmpty(key))
            {
                // utilisez le SID de l'utilisateur Windows actuel comme cl¨¦ par d¨¦faut
                key = new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null).Value;
                MessageBox.Show($"Aucune cl¨¦ n¡¯est fournie, la cl¨¦ par d¨¦faut (Windows SID) est utilis¨¦e: {key}", "La cl¨¦ par d¨¦faut", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return key;
        }

        // Sauvegarder les donn¨¦es et les crypter
        private void Save_Click(object sender, EventArgs e)
        {
            Bibliotheque bibliotheque = new Bibliotheque
            {
                Livres = livres,
                Utilisateurs = utilisateurs
            };

            string fileName = "BibliothequeData.json";

            try
            {
                // s¨¦rialiser les donn¨¦es json
                bibliotheque.Serialize(fileName);

                // obtenir la cl¨¦ de chiffrement
                string key = GetEncryptionKey();

                Cryptage.EncryptFile(fileName, key);

                MessageBox.Show($"Les donn¨¦es sont enregistr¨¦es et crypt¨¦es en tant que {fileName}.enc", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s¡¯est produite lors de l¡¯enregistrement des donn¨¦es: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


