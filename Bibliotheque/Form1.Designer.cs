namespace Bibliotheque
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Titre = new Label();
            Auteur = new Label();
            DateDePublication = new Label();
            ISBN = new Label();
            Categorie = new Label();
            listLivre = new ListBox();
            AfficherLivre = new Button();
            textTitre = new TextBox();
            textAuteur = new TextBox();
            textDatePublic = new TextBox();
            textISBN = new TextBox();
            textCategorie = new TextBox();
            Ajouter = new Button();
            listUser = new ListBox();
            AfficherUser = new Button();
            ISBNsearch = new TextBox();
            ISBN_search = new Label();
            Emprunter = new Button();
            Rendre = new Button();
            Save = new Button();
            textPrenom = new TextBox();
            textEmail = new TextBox();
            textNom = new TextBox();
            Prenom = new Label();
            Email = new Label();
            Nom = new Label();
            AjouterUser = new Button();
            SuspendLayout();
            // 
            // Titre
            // 
            Titre.AutoSize = true;
            Titre.Location = new Point(948, 3);
            Titre.Margin = new Padding(2, 0, 2, 0);
            Titre.Name = "Titre";
            Titre.Size = new Size(43, 20);
            Titre.TabIndex = 0;
            Titre.Text = "Titre";
            // 
            // Auteur
            // 
            Auteur.AutoSize = true;
            Auteur.Location = new Point(932, 40);
            Auteur.Margin = new Padding(2, 0, 2, 0);
            Auteur.Name = "Auteur";
            Auteur.Size = new Size(59, 20);
            Auteur.TabIndex = 1;
            Auteur.Text = "Auteur";
            // 
            // DateDePublication
            // 
            DateDePublication.AutoSize = true;
            DateDePublication.Location = new Point(847, 77);
            DateDePublication.Margin = new Padding(2, 0, 2, 0);
            DateDePublication.Name = "DateDePublication";
            DateDePublication.Size = new Size(144, 20);
            DateDePublication.TabIndex = 2;
            DateDePublication.Text = "DateDePublication";
            // 
            // ISBN
            // 
            ISBN.AutoSize = true;
            ISBN.Location = new Point(946, 110);
            ISBN.Margin = new Padding(2, 0, 2, 0);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(43, 20);
            ISBN.TabIndex = 3;
            ISBN.Text = "ISBN";
            // 
            // Categorie
            // 
            Categorie.AutoSize = true;
            Categorie.Location = new Point(911, 144);
            Categorie.Margin = new Padding(2, 0, 2, 0);
            Categorie.Name = "Categorie";
            Categorie.Size = new Size(81, 20);
            Categorie.TabIndex = 4;
            Categorie.Text = "Categorie";
            // 
            // listLivre
            // 
            listLivre.FormattingEnabled = true;
            listLivre.Location = new Point(1, -2);
            listLivre.Margin = new Padding(2);
            listLivre.Name = "listLivre";
            listLivre.Size = new Size(837, 104);
            listLivre.TabIndex = 5;
            // 
            // AfficherLivre
            // 
            AfficherLivre.Location = new Point(1, 110);
            AfficherLivre.Margin = new Padding(2);
            AfficherLivre.Name = "AfficherLivre";
            AfficherLivre.Size = new Size(172, 28);
            AfficherLivre.TabIndex = 6;
            AfficherLivre.Text = "Afficher Livres";
            AfficherLivre.UseVisualStyleBackColor = true;
            AfficherLivre.Click += AfficherLivre_Click;
            // 
            // textTitre
            // 
            textTitre.Location = new Point(1015, 0);
            textTitre.Margin = new Padding(2);
            textTitre.Name = "textTitre";
            textTitre.Size = new Size(123, 27);
            textTitre.TabIndex = 7;
            // 
            // textAuteur
            // 
            textAuteur.Location = new Point(1015, 36);
            textAuteur.Margin = new Padding(2);
            textAuteur.Name = "textAuteur";
            textAuteur.Size = new Size(123, 27);
            textAuteur.TabIndex = 8;
            // 
            // textDatePublic
            // 
            textDatePublic.Location = new Point(1015, 70);
            textDatePublic.Margin = new Padding(2);
            textDatePublic.Name = "textDatePublic";
            textDatePublic.Size = new Size(123, 27);
            textDatePublic.TabIndex = 9;
            // 
            // textISBN
            // 
            textISBN.Location = new Point(1015, 106);
            textISBN.Margin = new Padding(2);
            textISBN.Name = "textISBN";
            textISBN.Size = new Size(123, 27);
            textISBN.TabIndex = 10;
            // 
            // textCategorie
            // 
            textCategorie.Location = new Point(1015, 139);
            textCategorie.Margin = new Padding(2);
            textCategorie.Name = "textCategorie";
            textCategorie.Size = new Size(123, 27);
            textCategorie.TabIndex = 11;
            // 
            // Ajouter
            // 
            Ajouter.Location = new Point(1206, 52);
            Ajouter.Margin = new Padding(2);
            Ajouter.Name = "Ajouter";
            Ajouter.Size = new Size(92, 28);
            Ajouter.TabIndex = 12;
            Ajouter.Text = "Ajouter";
            Ajouter.UseVisualStyleBackColor = true;
            Ajouter.Click += Ajouter_Click;
            // 
            // listUser
            // 
            listUser.FormattingEnabled = true;
            listUser.Location = new Point(1, 265);
            listUser.Margin = new Padding(2);
            listUser.Name = "listUser";
            listUser.Size = new Size(837, 104);
            listUser.TabIndex = 13;
            // 
            // AfficherUser
            // 
            AfficherUser.Location = new Point(1, 374);
            AfficherUser.Name = "AfficherUser";
            AfficherUser.Size = new Size(172, 29);
            AfficherUser.TabIndex = 14;
            AfficherUser.Text = "Afficher User";
            AfficherUser.UseVisualStyleBackColor = true;
            AfficherUser.Click += AfficherUser_Click;
            // 
            // ISBNsearch
            // 
            ISBNsearch.Location = new Point(1015, 265);
            ISBNsearch.Margin = new Padding(2);
            ISBNsearch.Name = "ISBNsearch";
            ISBNsearch.Size = new Size(123, 27);
            ISBNsearch.TabIndex = 16;
            // 
            // ISBN_search
            // 
            ISBN_search.AutoSize = true;
            ISBN_search.Location = new Point(946, 269);
            ISBN_search.Margin = new Padding(2, 0, 2, 0);
            ISBN_search.Name = "ISBN_search";
            ISBN_search.Size = new Size(43, 20);
            ISBN_search.TabIndex = 15;
            ISBN_search.Text = "ISBN";
            // 
            // Emprunter
            // 
            Emprunter.Location = new Point(911, 341);
            Emprunter.Margin = new Padding(2);
            Emprunter.Name = "Emprunter";
            Emprunter.Size = new Size(92, 28);
            Emprunter.TabIndex = 17;
            Emprunter.Text = "Emprunter";
            Emprunter.UseVisualStyleBackColor = true;
            Emprunter.Click += Emprunter_Click;
            // 
            // Rendre
            // 
            Rendre.Location = new Point(1100, 341);
            Rendre.Margin = new Padding(2);
            Rendre.Name = "Rendre";
            Rendre.Size = new Size(92, 28);
            Rendre.TabIndex = 18;
            Rendre.Text = "Rendre";
            Rendre.UseVisualStyleBackColor = true;
            Rendre.Click += Rendre_Click;
            // 
            // Save
            // 
            Save.Location = new Point(1074, 493);
            Save.Margin = new Padding(2);
            Save.Name = "Save";
            Save.Size = new Size(92, 28);
            Save.TabIndex = 19;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // textPrenom
            // 
            textPrenom.Location = new Point(77, 461);
            textPrenom.Margin = new Padding(2);
            textPrenom.Name = "textPrenom";
            textPrenom.Size = new Size(123, 27);
            textPrenom.TabIndex = 24;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(77, 498);
            textEmail.Margin = new Padding(2);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(123, 27);
            textEmail.TabIndex = 25;
            // 
            // textNom
            // 
            textNom.Location = new Point(77, 419);
            textNom.Margin = new Padding(2);
            textNom.Name = "textNom";
            textNom.Size = new Size(123, 27);
            textNom.TabIndex = 23;
            // 
            // Prenom
            // 
            Prenom.AutoSize = true;
            Prenom.Location = new Point(7, 460);
            Prenom.Margin = new Padding(2, 0, 2, 0);
            Prenom.Name = "Prenom";
            Prenom.Size = new Size(66, 20);
            Prenom.TabIndex = 22;
            Prenom.Text = "Prenom";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(7, 496);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(47, 20);
            Email.TabIndex = 21;
            Email.Text = "Email";
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(7, 421);
            Nom.Margin = new Padding(2, 0, 2, 0);
            Nom.Name = "Nom";
            Nom.Size = new Size(45, 20);
            Nom.TabIndex = 20;
            Nom.Text = "Nom";
            // 
            // AjouterUser
            // 
            AjouterUser.Location = new Point(269, 460);
            AjouterUser.Margin = new Padding(2);
            AjouterUser.Name = "AjouterUser";
            AjouterUser.Size = new Size(92, 28);
            AjouterUser.TabIndex = 26;
            AjouterUser.Text = "Ajouter";
            AjouterUser.UseVisualStyleBackColor = true;
            AjouterUser.Click += AjouterUser_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 532);
            Controls.Add(AjouterUser);
            Controls.Add(textPrenom);
            Controls.Add(textEmail);
            Controls.Add(textNom);
            Controls.Add(Prenom);
            Controls.Add(Email);
            Controls.Add(Nom);
            Controls.Add(Save);
            Controls.Add(Rendre);
            Controls.Add(Emprunter);
            Controls.Add(ISBNsearch);
            Controls.Add(ISBN_search);
            Controls.Add(AfficherUser);
            Controls.Add(listUser);
            Controls.Add(Ajouter);
            Controls.Add(textCategorie);
            Controls.Add(textISBN);
            Controls.Add(textDatePublic);
            Controls.Add(textAuteur);
            Controls.Add(textTitre);
            Controls.Add(AfficherLivre);
            Controls.Add(listLivre);
            Controls.Add(Categorie);
            Controls.Add(ISBN);
            Controls.Add(DateDePublication);
            Controls.Add(Auteur);
            Controls.Add(Titre);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titre;
        private Label Auteur;
        private Label DateDePublication;
        private Label ISBN;
        private Label Categorie;
        private ListBox listLivre;
        private Button AfficherLivre;
        private TextBox textTitre;
        private TextBox textAuteur;
        private TextBox textDatePublic;
        private TextBox textISBN;
        private TextBox textCategorie;
        private Button Ajouter;
        private ListBox listUser;
        private Button AfficherUser;
        private TextBox ISBNsearch;
        private Label ISBN_search;
        private Button Emprunter;
        private Button Rendre;
        private Button Save;
        private TextBox textPrenom;
        private TextBox textEmail;
        private TextBox textNom;
        private Label Prenom;
        private Label Email;
        private Label Nom;
        private Button AjouterUser;
    }
}
