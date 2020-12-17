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

        // Cette méthode insert un nouvel adherent passé en paramètre
        // dans la BD
        public static bool AjoutAdherent(Adherent unAdherent)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            
            cmd.CommandText = "INSERT INTO adherent (nom,prenom,ddn,numtel,email,numparent,autprelev,sexe,login,mdp,datemaj,archive,utilisateur,classe) VALUES ( @nom, @prenom, @ddn, @numtel, @email, @numparent, @autprelev, @sexe, @login, @mdp, @datemaj, @archive, @utilisateur,@classe)";

            cmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.NVarChar));
            cmd.Parameters["@nom"].Value = unAdherent.Nom;

            cmd.Parameters.Add(new SqlParameter("@prenom", SqlDbType.NVarChar));
            cmd.Parameters["@prenom"].Value = unAdherent.Prenom;

            cmd.Parameters.Add(new SqlParameter("@ddn", SqlDbType.DateTime));
            cmd.Parameters["@ddn"].Value = unAdherent.Ddn;

            cmd.Parameters.Add(new SqlParameter("@numtel", SqlDbType.NVarChar));
            cmd.Parameters["@numtel"].Value = unAdherent.NumTel;

            cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar));
            cmd.Parameters["@email"].Value = unAdherent.Email;

            cmd.Parameters.Add(new SqlParameter("@numparent", SqlDbType.NVarChar));
            cmd.Parameters["@numparent"].Value = unAdherent.NumParnt;

            cmd.Parameters.Add(new SqlParameter("@autprelev", SqlDbType.Bit));
            cmd.Parameters["@autprelev"].Value = unAdherent.AutPrelev;

            cmd.Parameters.Add(new SqlParameter("@sexe", SqlDbType.NVarChar));
            cmd.Parameters["@sexe"].Value = unAdherent.Sexe;

            cmd.Parameters.Add(new SqlParameter("@login", SqlDbType.NVarChar));
            cmd.Parameters["@login"].Value = unAdherent.Login;

            cmd.Parameters.Add(new SqlParameter("@mdp", SqlDbType.NVarChar));
            cmd.Parameters["@mdp"].Value = unAdherent.Mdp;

            cmd.Parameters.Add(new SqlParameter("@datemaj", SqlDbType.DateTime));
            cmd.Parameters["@datemaj"].Value = unAdherent.DateMaj;

            cmd.Parameters.Add(new SqlParameter("@archive", SqlDbType.Bit));
            cmd.Parameters["@archive"].Value = unAdherent.Archive;

            cmd.Parameters.Add(new SqlParameter("@utilisateur", SqlDbType.Int));
            cmd.Parameters["@utilisateur"].Value = unAdherent.Utilisateur.Id;

            cmd.Parameters.Add(new SqlParameter("@classe", SqlDbType.Int));
            cmd.Parameters["@classe"].Value = unAdherent.Classe.Id;


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

        // Cette méthode modifie un Adherent passé en paramètre dans la BD
        public static bool UpdateAdherent(Adherent unAdherent)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "UPDATE adherent SET nom = @nom, prenom = @prenom, ddn = @ddn, numtel = @numtel, email = @email, numparent = @numparent, autprelev = @autprelev, sexe = @sexe, login = @login, mdp = @mdp, datemaj = @datemaj, archive = @archive, utilisateur = @utilisateur, classe = @classe WHERE id = @id";

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = unAdherent.Id;

            cmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.NVarChar));
            cmd.Parameters["@nom"].Value = unAdherent.Nom;

            cmd.Parameters.Add(new SqlParameter("@prenom", SqlDbType.NVarChar));
            cmd.Parameters["@prenom"].Value = unAdherent.Prenom;

            cmd.Parameters.Add(new SqlParameter("@ddn", SqlDbType.DateTime));
            cmd.Parameters["@ddn"].Value = unAdherent.Ddn;

            cmd.Parameters.Add(new SqlParameter("@numtel", SqlDbType.NVarChar));
            cmd.Parameters["@numtel"].Value = unAdherent.NumTel;

            cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar));
            cmd.Parameters["@email"].Value = unAdherent.Email;

            cmd.Parameters.Add(new SqlParameter("@numparent", SqlDbType.NVarChar));
            cmd.Parameters["@numparent"].Value = unAdherent.NumParnt;

            cmd.Parameters.Add(new SqlParameter("@autprelev", SqlDbType.Bit));
            cmd.Parameters["@autprelev"].Value = unAdherent.AutPrelev;

            cmd.Parameters.Add(new SqlParameter("@sexe", SqlDbType.NVarChar));
            cmd.Parameters["@sexe"].Value = unAdherent.Sexe;

            cmd.Parameters.Add(new SqlParameter("@login", SqlDbType.NVarChar));
            cmd.Parameters["@login"].Value = unAdherent.Login;

            cmd.Parameters.Add(new SqlParameter("@mdp", SqlDbType.NVarChar));
            cmd.Parameters["@mdp"].Value = unAdherent.Mdp;

            cmd.Parameters.Add(new SqlParameter("@datemaj", SqlDbType.DateTime));
            cmd.Parameters["@datemaj"].Value = unAdherent.DateMaj;

            cmd.Parameters.Add(new SqlParameter("@archive", SqlDbType.Bit));
            cmd.Parameters["@archive"].Value = unAdherent.Archive;

            cmd.Parameters.Add(new SqlParameter("@utilisateur", SqlDbType.Int));
            cmd.Parameters["@utilisateur"].Value = unAdherent.Utilisateur.Id;

            cmd.Parameters.Add(new SqlParameter("@classe", SqlDbType.Int));
            cmd.Parameters["@classe"].Value = unAdherent.Classe.Id;


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
        public static bool DeleteAdherent(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM adherent WHERE id = @id ";

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

        // Cette méthode vérifie que le string passé en paramètre correspond
        // au regex
        // retourne une valeur booléenne
        public static bool GetRegexString(string value, string regex)
        {
            Regex regexString = new Regex(regex);

            return regexString.IsMatch(value);
        }

        // Cette méthode vérifie que l'existance de l'adhérent via son login
        // retourne une valeur booléenne
        public static bool VerifAdherent(string login)
        {
            bool resultat = false;
      
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM adherent WHERE login = @login";

            cmd.Parameters.Add(new SqlParameter("@login", SqlDbType.NVarChar));
            cmd.Parameters["@login"].Value = login;

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                
                if (monReader["login"] == DBNull.Value)
                {
                    
                }
                else
                {
                    resultat = true;
                }

            }

            // Fermeture de la connexion
            maConnexion.Close();

            return resultat;
        }

        // Cette méthode vérifie que l'existance de l'adhérent via son login et son id
        // retourne une valeur booléenne
        public static bool VerifAdherentByLoginAndId(string login, int id)
        {
            bool resultat = false;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM adherent WHERE login = @login AND id != @id";

            cmd.Parameters.Add(new SqlParameter("@login", SqlDbType.NVarChar));
            cmd.Parameters["@login"].Value = login;

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = id;

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {

                if (monReader["login"] == DBNull.Value)
                {

                }
                else
                {
                    resultat = true;
                }

            }

            // Fermeture de la connexion
            maConnexion.Close();

            return resultat;
        }
    }
}
