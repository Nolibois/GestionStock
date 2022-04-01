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
        public List<Fournisseurs> Show()
        {
            return new Fournisseurs().ShowAll();
        }

        public Fournisseurs ShowById(int id)
        {
            return new Fournisseurs().ShowById(id);
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
            return fournisseur.Edit(fournisseur);
        }

        public bool Delete(Fournisseurs fournuisseur)
        {
            return false;
        }

    }
}
