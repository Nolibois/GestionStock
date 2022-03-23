using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.Model;

namespace GestionStock.Controller
{
    internal class FournisseurControl
    {
        public void Show()
        {

        }

        public Fournisseurs ShowById(int id)
        {
            return new Fournisseurs();
        }

        public Fournisseurs Search(string condition)
        {
            return new Fournisseurs();
        }

        public Fournisseurs Ajouter(Fournisseurs fournisseur)
        {
            return fournisseur.Insert(fournisseur);
        }
        
        public Fournisseurs Edit(Fournisseurs fournisseur)
        {
            return new Fournisseurs();
        }

        public bool Delete(Fournisseurs fournuisseur)
        {
            return false;
        }

    }
}
