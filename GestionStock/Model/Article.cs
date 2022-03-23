using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Model
{
    internal class Article
    {
        private int tArticlePK { get;}
        public string articleNom{ get; set; }
        public Fournisseurs fournisseur{ get; set; }
        public Categories categorie{ get; set; }
        public DateTime dateFab{ get; set; }
        public DateTime dateExp{ get; set; }
        public int seuil_de_reappro{ get; set; }
        public double prixUnitaireAchat{ get; set; }
        public double prixUnitaireVente{ get; set; }


    }
}
