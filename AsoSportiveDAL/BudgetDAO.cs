using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsoSportiveBO; // Référence la couche BO
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace AsoSportiveDAL
{
    public class BudgetDAO
    {
        // Cette méthode permet de recupère l'ensemble des budget
        // retourne une liste de budget
        public static List<Budget> GetLesBudget()
        {
            int id;
            string libelle;
            float montantInitial;

            List<Budget> lesBudgets = new List<Budget>();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM budget";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id"].ToString());

                if (monReader["id"] == DBNull.Value)
                {
                    libelle = default(string);
                    montantInitial = default(float);
                }
                else
                {
                    libelle = monReader["libelle"].ToString();
                    montantInitial = float.Parse(monReader["montantInitial"].ToString());
                }
                Budget budget = new Budget(id, libelle, montantInitial);
                lesBudgets.Add(budget);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesBudgets;
        }
    }
}
