using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using AsoSportiveDAL; // Référence la couche DAL
using AsoSportiveBO; // Référence la couche BO

namespace AsoSportiveBLL
{
    public class GestionUtilisateurs
    {
        
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion
        // de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetChaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à
        // la méthode GetUtilisateurs() de la DAL
        public static List<Utilisateur> GetUtilisateurs()
        {
            return UtilisateurDAO.GetUtilisateurs();
        }
        // méthode qui va vérifier l'existance de les identifiants de l'utilisateur (login / password) dans la bdd
        // retourne un boolean
        public static bool ConnexionUtilisateur(string login, string pass)
        {
            return UtilisateurDAO.ConnexionUtilisateur(login, pass);
        }

        // Méthode qui va retourner l'objet utilisateur connecté
        // la méthode GetUtilisateurLog() de la DAL
        public static Utilisateur logUtilisateur(string login)
        {
            return UtilisateurDAO.GetUtilisateurLog(login);
        }
    }
}
