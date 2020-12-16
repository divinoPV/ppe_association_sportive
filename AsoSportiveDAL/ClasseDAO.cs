using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsoSportiveBO; // Référence la couche BO
using System.Data.SqlClient;
using System.Data;

namespace AsoSportiveDAL
{
    public class ClasseDAO
    {
        // Cette méthode permet de récupérer les données d'une classe
        // retourne une classe
        public static Classe GetClasse(int id)
        {
            string libelle;

            Classe classe = new Classe();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM classe WHERE id = @id";

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = id;

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = (int)monReader["id"];

                if (monReader["id"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["libelle"].ToString();
                }

                classe = new Classe(id, libelle);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return classe;
        }
        // Cette méthode permet de recupère l'ensemble des classes
        // retourne une liste de classe
        public static List<Classe> GetLesClasses()
        {
            int id;
            string libelle;
            List<Classe> LesClasses = new List<Classe>();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM classe";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id"].ToString());

                if (monReader["id"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["libelle"].ToString();
                }
                Classe classe = new Classe(id, libelle);
                LesClasses.Add(classe);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return LesClasses;
        }
    }
}
