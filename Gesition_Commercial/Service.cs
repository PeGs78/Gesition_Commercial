using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gesition_Commercial
{
    internal class Service
    {
        private string nomService;
        private Commercial[] tabcom;
        private int effectif;

        public string NomService { get => nomService; set => nomService = value; }
        internal Commercial[] Tabcom { get => tabcom; set => tabcom = value; }
        public int Effectif { get => effectif; set => effectif = value; }

        public Service(string nomS)
        {
            NomService = nomS;
            effectif = 0;
            tabcom = new Commercial[10];
        }

        public Service() { }

        public void ajouterCom(Commercial c)
        {
            if (c.Service == this)
            {
                tabcom[effectif] = c;
                effectif++;
            }
        }

        public Commercial CommercialLePlusAge()
        {
            Commercial plusAge = null;
            foreach (Commercial commercial in tabcom)
            {
                if (commercial != null && (plusAge == null || commercial.calculAge() > plusAge.calculAge()))
                {
                    plusAge = commercial; 
                }
            }
            return plusAge;
        }
        public override string ToString()
        {
            string result = "Service: " + NomService + "\n";
            result += "Commerciaux:\n";
            foreach (Commercial commercial in Tabcom)
            {
                if (commercial != null)
                {
                    result += commercial.ToString() + "\n";
                }
            }
            result += "Effectif: " + Tabcom.Length + "\n";


            Commercial plusAge = CommercialLePlusAge();
            if (plusAge != null)
            {
                result += "Commercial le plus âgé du service:\n" + plusAge.ToString() + "\n";
            }
            else
            {
                result += "Aucun commercial dans ce service.\n";
            }



            return result;

        }



    }
}
