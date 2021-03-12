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
    public class FluxDAO
    {
        public static List<Flux> GetLesFlux()
        {
            int id;
            string libelle;
            DateTime date;
            float montant;
            bool prelevement;
            Adherent adherent;
            Budget budget;
            TypeFlux typeFlux;

            List<Flux> lesFlux = new List<Flux>();

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
                    date = default(DateTime);
                    montant = default(float);
                    prelevement = default(bool);
                    adherent = default(Adherent);
                    budget = default(Budget);
                    typeFlux = default(TypeFlux);
                }
                else
                {
                    libelle = monReader["libelle"].ToString();
                    date = (DateTime)monReader["date"];
                    montant = (float)monReader["montant"];
                    prelevement = (bool)monReader["prelevement"];
                    adherent = (Adherent)monReader["adherent"];
                    budget = (Budget)monReader["budget"];
                    typeFlux = (TypeFlux)monReader["typeFlux"];
                }
                Flux flux = new Flux(id, libelle, date, montant, prelevement, adherent, budget, typeFlux);
                lesFlux.Add(flux);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesFlux;
        }

        // Cette méthode insert un nouveau flux passé en paramètre
        // dans la BD
        public static bool AjoutFlux(Flux unFlux)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "INSERT INTO flux (libelle,date,montant,prelevement,adherent,typeFlux,evenement,budget) VALUES (@libelle,@date,@montant,@prelevement,@adherent,@typeFlux,@evenement,@budget)";

            cmd.Parameters.Add(new SqlParameter("@libelle", SqlDbType.NVarChar));
            cmd.Parameters["@libelle"].Value = unFlux.Libelle;

            cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime));
            cmd.Parameters["@date"].Value = unFlux.Date;

            cmd.Parameters.Add(new SqlParameter("@montant", SqlDbType.Float));
            cmd.Parameters["@montant"].Value = unFlux.Montant;

            cmd.Parameters.Add(new SqlParameter("@prelevement", SqlDbType.Bit));
            cmd.Parameters["@prelevement"].Value = unFlux.Prelevement;

            cmd.Parameters.Add(new SqlParameter("@adherent", SqlDbType.Int));
            cmd.Parameters["@adherent"].Value = unFlux.Adherent;

            cmd.Parameters.Add(new SqlParameter("@typeFlux", SqlDbType.Int));
            cmd.Parameters["@typeFlux"].Value = unFlux.TypeFlux;

            cmd.Parameters.Add(new SqlParameter("@evenement", SqlDbType.Int));
            cmd.Parameters["@evenement"].Value = null;

            cmd.Parameters.Add(new SqlParameter("@budget", SqlDbType.Int));
            cmd.Parameters["@budget"].Value = unFlux.Budget;

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

        public static bool UpdateFlux(Flux unFlux)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "UPDATE flux SET libelle = @libelle, date = @date, montant = @montant, prelevement = @prelevement, adherent = @adherent, typeFlux = @typeFlux, evenement = @evenement, budget = @budget WHERE id = @id";

            cmd.Parameters.Add(new SqlParameter("@libelle", SqlDbType.NVarChar));
            cmd.Parameters["@libelle"].Value = unFlux.Libelle;

            cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime));
            cmd.Parameters["@date"].Value = unFlux.Date;

            cmd.Parameters.Add(new SqlParameter("@montant", SqlDbType.Float));
            cmd.Parameters["@montant"].Value = unFlux.Montant;

            cmd.Parameters.Add(new SqlParameter("@prelevement", SqlDbType.Bit));
            cmd.Parameters["@prelevement"].Value = unFlux.Prelevement;

            cmd.Parameters.Add(new SqlParameter("@adherent", SqlDbType.Int));
            cmd.Parameters["@adherent"].Value = unFlux.Adherent;

            cmd.Parameters.Add(new SqlParameter("@typeFlux", SqlDbType.Int));
            cmd.Parameters["@typeFlux"].Value = unFlux.TypeFlux;

            cmd.Parameters.Add(new SqlParameter("@evenement", SqlDbType.Int));
            cmd.Parameters["@evenement"].Value = null;

            cmd.Parameters.Add(new SqlParameter("@budget", SqlDbType.Int));
            cmd.Parameters["@budget"].Value = unFlux.Budget;

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

        // Cette méthode supprime de la BD un Adherent dont l'id est 
        // passé en paramètre
        public static bool DeleteFlux(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM flux WHERE id = @id ";

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
    }
}
