using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2tp1
{
    internal class Auteur
    {
        private int idA;
        private string NomA;
        private string PrenomA;

        public int IdA { get => idA; set => idA = value; }
        public string NomA1 { get => NomA; set => NomA = value; }
        public string PrenomA1 { get => PrenomA; set => PrenomA = value; }


        public Auteur()
        {

        }
        public Auteur(int aIda, string aNoma, string aPrenoma)
        {
            this.idA = aIda;
            this.NomA = aNoma;
            this.PrenomA = aPrenoma;
        }       
        public void affichea()
        {
            Console.WriteLine(" Auteur " + this.NomA +" "+this.PrenomA +"(numéro "+this.idA +")");
        }
    }

}


