using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public enum TypeCategorie
    {
        Fiction,
        Science,
        Suspense,
        Histoire,
        NonClasse
    }
    public class Categorie
    {
        public string Nom { get; set; }
        public TypeCategorie Type { get; set; }

        public Categorie(TypeCategorie Type)
        {
            this.Type = Type;
            Nom = Type.ToString();
        }

    }
}
