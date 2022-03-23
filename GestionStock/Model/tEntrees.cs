using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Model
{
    internal class tEntrees
    {
        private int tEntreesPK{ get; }
        public Article tArticleFK{ get; set; }
        public DateTime entreeDate{ get; set; }
        public DateTime entreeQuant{ get; set; }
        public int entreeImputation{ get; set; }
        public float cmup{ get; set; }
    }
}
