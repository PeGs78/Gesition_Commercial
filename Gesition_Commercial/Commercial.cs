using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Gesition_Commercial
{
    internal class Commercial
    {
        private Service service;
        private string nom;
        private string prenom;
        private int anneeNaissance;
        private Categorie categorie;

        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        internal Categorie Categorie { get => categorie; set => categorie = value; }
        internal Service Service { get => service; set => service = value; }

        public Commercial(string nom, string prenom, int aneNaiss,Categorie cat, Service ser)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.anneeNaissance = aneNaiss;
            this.categorie = cat;
            this.service = ser;

           service.ajouterCom(this);
        }

        public Commercial() { }

        public int calculAge() 
        {
          int age = DateTime.Now.Year - this.anneeNaissance;
            return age;
        }

        public override string ToString()
        {
            return "nom :" + nom + "\n prenom: " + prenom + "\n Année de naissance: " + anneeNaissance + "\n Ce commercial a donc " + calculAge() + "ans\n" + this.categorie ;

        }

        public void Compare(Commercial autreC)
        {
        
            if (nom == autreC.nom)
            {
                Console.WriteLine("Les deux commerciaux ont le même nom de famille.");
            }
            else
            {
                Console.WriteLine("Les deux commerciaux n'ont pas le même nom de famille.");
            }
        }

    }
}

