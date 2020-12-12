using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsoSportiveBO; // Référence la couche BO
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AsoSportiveDAL
{
    public class UtilisateurDAO
    {
        // Cette méthode retourne une List contenant les objets Utilisateurs
        // contenus dans la table Identification
        public static List<Utilisateur> GetUtilisateurs()
        {
            int id;
            string login;
            string pass;
            Utilisateur unUtilisateur;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            // Création d'une liste vide d'objets Utilisateurs
            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM utilisateur";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id"].ToString());

                if (monReader["id"] == DBNull.Value)
                {
                    login = default(string);
                    pass = default(string);
                }
                else
                {
                    login = monReader["login"].ToString();
                    pass = monReader["mdp"].ToString();
                }
                unUtilisateur = new Utilisateur(id, login, pass);
                lesUtilisateurs.Add(unUtilisateur);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesUtilisateurs;
        }

        // Cette méthode permet de récupérer les données d'un utilisateur (id/login/role)
        // retourne un utilisateur
        public static Utilisateur GetUtilisateurLog(string login)
        {
            int id;
            char role;
            Utilisateur utilisateur = new Utilisateur();

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM utilisateur WHERE login = @login";

            cmd.Parameters.Add(new SqlParameter("@login", SqlDbType.NVarChar));
            cmd.Parameters["@login"].Value = login;

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id"].ToString());

                if (monReader["id"] == DBNull.Value)
                {
                    role = default(char);
                }
                else
                {
                    role = Convert.ToChar(monReader["droit"]);
                }

                utilisateur = new Utilisateur(id, login, role);
            }
            
            // Fermeture de la connexion
            maConnexion.Close();

            return utilisateur;
        }

        // Cette méthode permet de récupérer les données d'un utilisateur
        // retourne un utilisateur
        public static Utilisateur GetUtilisateur(int id)
        {
            string login;

            Utilisateur utilisateur = new Utilisateur();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM utilisateur WHERE id = @id";

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = id;

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = (int)monReader["id"];

                if (monReader["id"] == DBNull.Value)
                {
                    login = default(string);
                }
                else
                {
                    login = monReader["login"].ToString();
                }

                utilisateur = new Utilisateur(id, login);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return utilisateur;
        }

        // Cette méthode permet la connexion d'un utilisateur
        public static bool ConnexionUtilisateur(string login, string pass)
        {
            foreach (Utilisateur utilisateur in GetUtilisateurs()) {
                if (login == utilisateur.Login && pass == utilisateur.Pass)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
