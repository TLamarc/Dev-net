using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public DateTime DateDePublication { get; set; }
        public string ISBN { get; set; }
        public Categorie Categorie { get; set; }
        public DateTime DateAjout { get; set; }
        public bool EstDisponible { get; set; } = true;
        public Livre(string titre, string auteur, DateTime dateDePublication, string isbn, Categorie categorie)
        {
            Titre = titre;
            Auteur = auteur;
            DateDePublication = dateDePublication;
            ISBN = isbn;
            Categorie = categorie;
            DateAjout = DateTime.Now;
        }
    }
}
