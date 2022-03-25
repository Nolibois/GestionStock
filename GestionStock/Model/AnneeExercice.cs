using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.Model;
using System.Data.SqlClient;

namespace GestionStock.Model
{
    internal class AnneeExercice
    {
        public int codeAE { get; set; }

        public String anneeExercice { get; set; }

        public AnneeExercice() { }

        public AnneeExercice(string anneeE)
        {
            this.anneeExercice = anneeE;
        }

        public AnneeExercice Insert()
        {
            string query = "INSERT INTO AnneeExercice VALUES ('" + this.anneeExercice + "')";
            DatabaseContext.Exec(query);
            return this;
        }

        public AnneeExercice Update()
        {
            string query = "UPDATE AnneeExercice SET AnneeExercice= '" + this.anneeExercice + "' where codeAE='" + this.codeAE + "'";

            DatabaseContext.Exec(query);
            return this;
        }

        public bool Delete(int id)
        {
            string query = "delete from AnneeExercice where CodeAE= '" + id + "'";
            return DatabaseContext.Exec(query) == 1;
        }

        public List<AnneeExercice> ShowAll()
        {
            List<AnneeExercice> list = new List<AnneeExercice>();
            string query = "SELECT * FROM AnneeExercice";

            SqlDataReader resultat = DatabaseContext.ExecWithResult(query);
            if (resultat.HasRows)
            {
                while (resultat.Read())
                {
                    AnneeExercice ae = new AnneeExercice();
                    ae.codeAE = resultat.GetInt32(0);
                    ae.anneeExercice = resultat.GetDateTime(1).ToString();
                    list.Add(ae);
                }
            }
            DatabaseContext.CloseInst();
            return list;
        }

        public AnneeExercice ShowById(int id)
        {
            AnneeExercice ae = new AnneeExercice();
            string query = "SELECT *  FROM AnneeExercice where CodeAE=" + this.codeAE + "'";
            SqlDataReader resultat = DatabaseContext.ExecWithResult(query);

            if (resultat.HasRows && resultat.Read())
            {
                ae.codeAE = resultat.GetInt32(0);
                ae.anneeExercice = resultat.GetDateTime(1).ToString();
            }

            return ae;
        }
    }
}
