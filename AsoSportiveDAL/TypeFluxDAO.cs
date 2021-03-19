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
    public class TypeFluxDAO
    {
        // Cette méthode permet de recupère l'ensemble des types de flux
        // retourne une liste de flux
        public static List<TypeFlux> GetLesTypeFlux()
        {
            int id;
            string libelle;

            List<TypeFlux> lesTypeFlux = new List<TypeFlux>();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM type_flux";

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
                TypeFlux typeFlux = new TypeFlux(id, libelle);
                lesTypeFlux.Add(typeFlux);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesTypeFlux;
        }

        public static TypeFlux GetTypeFlux(int idS)
        {
            int id;
            string libelle;

            TypeFlux typeFlux = new TypeFlux();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM type_flux WHERE id = @id";

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = idS;

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
                typeFlux = new TypeFlux(id, libelle);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return typeFlux;
        }
    }
}
