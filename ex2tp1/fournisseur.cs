using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2tp1
{
    internal class Fournisseur
    {
        private int idF;
        private string NomF;
        private string AdresseF;

        public int IdF { get => idF; set => idF = value; }
        public string NomF1 { get => NomF; set => NomF = value; }
        public string AdresseF1 { get => AdresseF; set => AdresseF = value; }

        public Fournisseur()
        {

        }

        public Fournisseur(int fidF, string fnomF, string fadresseF)
        {
            this.idF = fidF;
            this.NomF = fnomF;
            this.AdresseF = fadresseF;
        }

        public void affichef()
        {
            Console.WriteLine("fournisseur : \n idf:" + this.IdF);
            Console.WriteLine(" nom :" +this.NomF);
            Console.WriteLine(" adresse :" +this.AdresseF);
        }
    }
}
