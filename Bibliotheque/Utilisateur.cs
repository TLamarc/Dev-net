using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Utilisateur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public DateTime DateInscription { get; set; }
        public List<Livre> LivresEmpruntes { get; set; }

        public Utilisateur(string nom, string prenom, string email)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            DateInscription = DateTime.Now;
            LivresEmpruntes = new List<Livre>();
        }
        public void EmprunterLivre(Livre livre)
        {
            if (livre.EstDisponible)
            {
                LivresEmpruntes.Add(livre);
                livre.EstDisponible = false;
            }
            else
            {
                throw new Exception("Ce livre n'est pas disponible.");
            }
        }
        public void RendreLivre(Livre livre)
        {
            if (LivresEmpruntes.Contains(livre))
            {
                LivresEmpruntes.Remove(livre);
                livre.EstDisponible = true;
            }
            else
            {
                throw new Exception("Ce livre est disponible.");
            }
        }
    }
}
