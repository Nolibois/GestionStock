using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Model
{
    internal class tSorties
    {
        private int tSortiesPK { get; }
        public Article tArticleFK{ get; set; }
        public DateTime sortiesDate{ get; set; }
        public DateTime sortiesQuant{ get; set; }
        public int sortiesImputation{ get; set; }
        public float cmup{ get; set; }
    }
}
