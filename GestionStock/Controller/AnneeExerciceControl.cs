using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.Model;

namespace GestionStock.Controller
{
    internal class AnneeExerciceControl
    {
        private AnneeExercice anneeE;

        public AnneeExerciceControl()
        {
            anneeE = new AnneeExercice();
        }

        public AnneeExercice Add(AnneeExercice aE)
        {
            return aE.Insert();
        }

        public AnneeExercice Update(AnneeExercice aE)
        {
            return aE.Edit();
        }

        public bool Delete(int id)
        {
            return anneeE.Delete(id);
        }

        public List<AnneeExercice> Show()
        {
            return anneeE.ShowAll();
        }

        public AnneeExercice ShowOne(int id)
        {
            return anneeE.ShowById(id);
        }

        public AnneeExercice Search(string search)
        {
            return anneeE;
        }
    }
}
