using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionStock.Model
{
    // Pattern Singleton

    // Permet de récupérer une instance de la base de données à chaque fois que l'on aura besoin de l'utiliser
    public class DatabaseContext
    {
        public static string connectionString = "Data Source=localhost;Initial Catalog=GestionStock2;Integrated Security=True";

        public static SqlConnection _instance;

        // Constructeur privé empêche d'instancier la class en dehors de ce namespace
        // A la place on va utiliser la méthode getInstance qui s'assurera que l'objet n'existait pas.
        private DatabaseContext()
        {
            _instance = new SqlConnection(connectionString);
        }

        public static SqlConnection GetInstance()
        {
            if(_instance == null)
            {
                _instance = new SqlConnection(connectionString);
            }
            return _instance;
        }

        public static int Exec(string query)
        {
            SqlCommand cmd = new SqlCommand(query, GetInstance());
            _instance.Open();

            // Lors d'une modification ou d'une création ou d'une suppression, le ExecuteNonQuery() retourne la quantité de lignes modifiées.
            int ret = cmd.ExecuteNonQuery();

            return ret;

        }

        public static SqlDataReader ExecWithResult(string query)
        {
            SqlCommand cmd = new SqlCommand(query, GetInstance());
            _instance.Open();

            // ExecuteReader() => Retourne le résultat de la requête dans un tableau.
            SqlDataReader ret = cmd.ExecuteReader();

            return ret;
        }

        public static void CloseInst()
        {
            if (_instance != null)
                _instance.Close();
        }
    }
}
