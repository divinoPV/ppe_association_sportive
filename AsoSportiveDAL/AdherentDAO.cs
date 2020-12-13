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
    public class AdherentDAO
    {
        // Cette méthode retourne une List contenant les objets Utilisateurs
        // contenus dans la table Identification
        public static List<Adherent> GetAdherent()
        {
            int id;
            string nom;
            string prenom;
            DateTime ddn;
            string numtel;
            string email;
            string numparnt;
            bool autprelev;
            char sexe;
            string login;
            string mdp;
            DateTime datemaj;
            bool archive;
            Utilisateur utilisateur;
            Classe classe;

            Adherent unAdherent;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            // Création d'une liste vide d'objets Utilisateurs
            List<Adherent> lesAdherents = new List<Adherent>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM adherent";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id"].ToString());

                if (monReader["id"] == DBNull.Value)
                {
                    id = default(int);
                    nom = default(string);
                    prenom = default(string);
                    ddn = default(DateTime);
                    numtel = default(string);
                    email = default(string);
                    numparnt = default(string);
                    autprelev = default(bool);
                    sexe = default(char);
                    login = default(string);
                    mdp = default(string);
                    datemaj = default(DateTime);
                    archive = default(bool);
                    utilisateur = default(Utilisateur);
                    classe = default(Classe);
                }
                else
                {
                    nom = monReader["nom"].ToString();
                    prenom = monReader["prenom"].ToString();
                    ddn = (DateTime)monReader["ddn"];
                    numtel = monReader["numtel"].ToString();
                    email = monReader["email"].ToString();
                    numparnt = monReader["numparent"].ToString();
                    autprelev = (bool)monReader["autprelev"];
                    sexe = monReader["sexe"].ToString()[0];
                    login = monReader["login"].ToString();
                    mdp = monReader["mdp"].ToString();
                    datemaj = (DateTime)monReader["datemaj"];
                    archive = (bool)monReader["archive"];
                    utilisateur = new Utilisateur((int)monReader["utilisateur"]);
                    classe = new Classe((int)monReader["classe"]);
                }
                unAdherent = new Adherent(id, nom, prenom, ddn, numtel, email, numparnt, autprelev, sexe, login,
                                        mdp, datemaj, archive, utilisateur, classe);
                lesAdherents.Add(unAdherent);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            foreach (Adherent adherent in lesAdherents)
            {
                adherent.Utilisateur = UtilisateurDAO.GetUtilisateur(adherent.Utilisateur.Id);
                adherent.Classe = ClasseDAO.GetClasse(adherent.Classe.Id);
            }

            return lesAdherents;
        }

        // Cette méthode insert un nouvel utilisateur passé en paramètre
        // dans la BD
        public static int AjoutAdherent(Utilisateur unAdherent)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO adherent values('" + unAdherent.Login + "')";

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }

        // Cette méthode modifie un utilisateur passé en paramètre dans la BD
        public static int UpdateAdherent(Utilisateur unAdherent)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE adherent SET login_utilisateur = '" +
                unAdherent.Login + "' WHERE id = " + unAdherent.Id;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }

        // Cette méthode supprime de la BD un utilisateur dont l'id est 
        // passé en paramètre
        public static int DeleteAdherent(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM adherent WHERE id = " + id;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }

        // Cette méthode vérifie que le string passé en paramètre correspond
        // au regex
        // retourne une valeur booléenne
        public static bool GetRegexString(string value, string regex)
        {
            Regex regexString = new Regex(regex);

            return regexString.IsMatch(value);
        }
    }
}
