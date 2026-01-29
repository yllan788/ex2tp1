using ex2tp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2ex1
{
    internal class Livre

    {
        private string titre;
        private string annee;
        private int npage;
        private int prix;
        private Fournisseur lefour;
        private Auteur leauteur;

        public string Titre { get => titre; set => titre = value; }
        public string Annee { get => annee; set => annee = value; }
        public int Npage { get => npage; set => npage = value; }
        public int Prix { get => prix; set => prix = value; }
        internal Fournisseur Lefour { get => lefour; set => lefour = value; }
        internal Auteur Leauteur { get => leauteur; set => leauteur = value; }

        public Livre()
        {

        }
        public Livre( string lTitre, string lAnnee, int lNpage, int lPrix)
        {
            this.Titre = lTitre;
            this.Annee = lAnnee;
            this.Npage = lNpage;
            this.Prix = lPrix;
        }
        public Livre(string lTitre, string lAnnee, int lNpage, int lPrix, Fournisseur lfournisseur, Auteur lauteur)
        {
            this.Titre = lTitre;
            this.Annee = lAnnee;
            this.Npage = lNpage;
            this.Prix = lPrix;
            this.Lefour = lfournisseur;
            this.Leauteur = lauteur;
        }

        public void affichel()
        {
            Console.WriteLine("Livre : \n Titre :" + this.Titre);
            Console.WriteLine(" Année : " + this.Annee);
            Console.WriteLine(" Nombre de pages : " + this.npage);
            Console.WriteLine(" prix : " + this.Prix + "\n" );
        }
    }
}
