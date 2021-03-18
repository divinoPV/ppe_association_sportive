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
            decimal montantInitial;

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
                    montantInitial = default(decimal);
                }
                else
                {
                    libelle = monReader["libelle"].ToString();
                    montantInitial = decimal.Parse(monReader["montantInitial"].ToString());
                }
                Budget budget = new Budget(id, libelle, montantInitial);
                lesBudgets.Add(budget);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesBudgets;
        }

        public static bool AjoutBudget(Budget unBudget)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "INSERT INTO budget (libelle, montantInitial) VALUES (@libelle, @montantInitial)";

            cmd.Parameters.Add(new SqlParameter("@libelle", SqlDbType.NVarChar));
            cmd.Parameters["@libelle"].Value = unBudget.Libelle;

            cmd.Parameters.Add(new SqlParameter("@montantInitial", SqlDbType.Decimal));
            cmd.Parameters["@montantInitial"].Value = unBudget.MontantInitial;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            if (string.IsNullOrEmpty(Convert.ToString(nbEnr)) || Convert.ToString(nbEnr) == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool UpdateBudget(Budget unBudget)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "UPDATE budget SET libelle = @libelle, montantInitial = @montantInitial WHERE id = @id";

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = unBudget.Id;

            cmd.Parameters.Add(new SqlParameter("@libelle", SqlDbType.NVarChar));
            cmd.Parameters["@libelle"].Value = unBudget.Libelle;

            cmd.Parameters.Add(new SqlParameter("@montantInitial", SqlDbType.Decimal));
            cmd.Parameters["@montantInitial"].Value = unBudget.MontantInitial;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            if (string.IsNullOrEmpty(Convert.ToString(nbEnr)) || Convert.ToString(nbEnr) == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool DeleteBudget(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM budget WHERE id = @id ";

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = id;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            if (string.IsNullOrEmpty(Convert.ToString(nbEnr)) || Convert.ToString(nbEnr) == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool GetRegexString(string value, string regex)
        {
            Regex regexString = new Regex(regex);

            return regexString.IsMatch(value);
        }

        public static Budget GetBudget(int idS)
        {
            int id;
            string libelle;
            decimal montantInitial;

            Budget budget = new Budget();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM budget WHERE id = @id";

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = idS;

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id"].ToString());

                if (monReader["id"] == DBNull.Value)
                {
                    libelle = default(string);
                    montantInitial = default(decimal);
                }
                else
                {
                    libelle = monReader["libelle"].ToString();
                    montantInitial = decimal.Parse(monReader["montantInitial"].ToString());
                }
                budget = new Budget(id, libelle, montantInitial);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return budget;
        }
    }
}
