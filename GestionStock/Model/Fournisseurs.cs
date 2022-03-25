using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.Model;
using System.Data.SqlClient;

namespace GestionStock.Model
{
    class Fournisseurs
    {
        private int refFournisseur { get; set; }
        public string nomFournisseur{ get; set; }
        public string nomContact{ get; set; }
        public string titreContact{ get; set; }
        public string adresse{ get; set; }
        public string ville{ get; set; }
        public int codePostal{ get; set; }
        public int departement{ get; set; }
        public string pays_Region{ get; set; }
        public string telephone{ get; set; }
        public int conditionPaiement{ get; set; }
        public string email{ get; set; }
        public string remarques{ get; set; }

        public Fournisseurs(
            string nomFournisseur,
            string nomContact,
            string titreContact,
            string adresse,
            string ville,
            int codePostal,
            int departement,
            string pays_Region,
            string telephone,
            int conditionPaiement,
            string email,
            string remarques)
        {
            this.nomFournisseur     = nomFournisseur;
            this.nomContact         = nomContact;
            this.titreContact       = titreContact;
            this.adresse            = adresse;
            this.ville              = ville;
            this.codePostal         = codePostal;
            this.departement        = departement;
            this.pays_Region        = pays_Region;
            this.telephone          = telephone;
            this.conditionPaiement  = conditionPaiement;
            this.email              = email;
            this.remarques          = remarques;
        }

        public Fournisseurs() { }

        public int Size()
        {
            string query = "SELECT COUNT(*) FROM Fournisseurs";
            return DatabaseContext.Exec(query);
        }

        public Fournisseurs Insert(Fournisseurs fournisseur)
        {

            string query = 
                "INSERT INTO Fournisseurs(" +
                    "NomFournisseur," +
                    "NomContact," +
                    "TitreContact," +
                    "Adresse," +
                    "Ville,"+
                    "CodePostal," +
                    "DepartementOuRegion," +
                    "Pays," +
                    "NumeroTel," +
                    "ConditionsPaiements," +
                    "AdresseEmail," +
                    "Remarques) " +
                "VALUES('" + 
                    fournisseur.nomFournisseur + "', '" + 
                    fournisseur.nomContact + "', '" + 
                    fournisseur.titreContact + "', '" + 
                    fournisseur.adresse + "', '" + 
                    fournisseur.ville + "', '" + 
                    fournisseur.codePostal + "', '" + 
                    fournisseur.departement + "', '" +
                    fournisseur.pays_Region + "', '" + 
                    fournisseur.telephone + "', '" + 
                    fournisseur.conditionPaiement + "', '" + 
                    fournisseur.email + "', '" + 
                    fournisseur.remarques + "')";

            DatabaseContext.Exec(query);

            return fournisseur;
        }

        public Fournisseurs Edit(Fournisseurs fournisseur)
        {

            string query =
               "UPDATE Fournisseurs SET " +
                   "NomFournisseur      = '" + fournisseur.nomFournisseur + "'," +
                   "NomContact          = '" + fournisseur.nomContact + "'," +
                   "TitreContact        = '" + fournisseur.titreContact + "'," +
                   "Adresse             = '" + fournisseur.adresse + "'," +
                   "Ville               = '" + fournisseur.ville + "'," +
                   "CodePostal          = '" + fournisseur.codePostal + "'," +
                   "Departement         = '" + fournisseur.departement + "'," +
                   "Pays_Region         = '" + fournisseur.pays_Region + "'," +
                   "Telephone           = '" + fournisseur.telephone + "'," +
                   "ConditionPaiement   = '" + fournisseur.conditionPaiement + "'," +
                   "Email               = '" + fournisseur.email + "'," +
                   "Remarques           = '" + fournisseur.remarques + "'";

            DatabaseContext.Exec(query);

            return fournisseur;
        }

        public int Delete(int id)
        {
            string query = "DELETE FROM Fournisseurs * WHERE RefFournisseur = " + id + "'";

            return DatabaseContext.Exec(query);
        }

        public Fournisseurs ShowById(int reference)
        {
            Fournisseurs fournisseur = new Fournisseurs();

            string query = "SELECT * FROM Fournisseurs WHERE RefFournisseur = " + reference + "'";

            SqlDataReader result = DatabaseContext.ExecWithResult(query);

            if (result.HasRows)
            { 
                fournisseur.refFournisseur      = result.GetInt32(0);
                fournisseur.nomFournisseur      = result.GetString(1);
                fournisseur.nomContact          = result.GetString(2);
                fournisseur.titreContact        = result.GetString(3);
                fournisseur.adresse             = result.GetString(4);
                fournisseur.ville               = result.GetString(5);
                fournisseur.codePostal          = result.GetInt32(6);
                fournisseur.departement         = result.GetInt32(7);
                fournisseur.pays_Region         = result.GetString(8);
                fournisseur.telephone           = result.GetString(9);
                fournisseur.conditionPaiement   = result.GetInt32(11);
                fournisseur.email               = result.GetString(12);
                fournisseur.remarques           = result.GetString(13);

            }

            return fournisseur;
        }

        public List<Fournisseurs> ShowAll()
        {
            List<Fournisseurs> list = new List<Fournisseurs>();
            string query = "SELECT * FROM Fournisseurs";
            SqlDataReader results = DatabaseContext.ExecWithResult(query);

            if (results.HasRows)
            {

                while(results.Read())
                {
                    Fournisseurs fournisseur = new Fournisseurs();

                    fournisseur.refFournisseur      = (int)results["RefFournisseur"];
                    fournisseur.nomFournisseur      = (string)results["NomFournisseur"];
                    fournisseur.nomContact          = (string)results["NomContact"];
                    fournisseur.titreContact        = (string)results["TitreContact"];
                    fournisseur.adresse             = (string)results["adresse"];
                    fournisseur.ville               = (string)results["ville"];
                    fournisseur.codePostal          = (int)results["codePostal"];
                    fournisseur.departement         = (int)results["DepartementOuRegion"];
                    fournisseur.pays_Region         = (string)results["Pays"];
                    fournisseur.telephone           = (string)results["NumeroTel"];
                    fournisseur.conditionPaiement   = (int)results["ConditionsPaiements"];
                    fournisseur.email               = (string)results["AdresseEmail"];
                    fournisseur.remarques           = (string)results["Remarques"];

                    list.Add(fournisseur);
                }
            }

            DatabaseContext.CloseInst();
            return list;
        }

    }
}
