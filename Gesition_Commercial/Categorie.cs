using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gesition_Commercial
{
    internal class Categorie
    {
        private string codeCategorie;
        private string libCategorie;

        public string LibCategorie { get => libCategorie; set => libCategorie = value; }
        public string CodeCategorie { get => codeCategorie; set => codeCategorie = value; }


        public Categorie(string libC,string codeC)
        {
            this.libCategorie = libC;
            this.codeCategorie = codeC;
        }

        public Categorie() { }

        public override string ToString()
        {
            return "code :" + codeCategorie + "\nlibellé :" + libCategorie + "\n" ;

        }

        

    }
}
