using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Model
{
    internal class Categories
    {
        private int refCategorie{ get; }
        public string nomCategorie{ get; set; }
        public AnneeExercice anneeExercice { get; set; }
    }
}
