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
        private int id;
        private string login;

        // variable de stockage de l'utilisateur connecté
        private static int idLog;
        private static string loginLog;
        private static char roleLog;

        public GestionUtilisateurs()
        { }

        public GestionUtilisateurs(string login)
        {
            this.login = login;
        }

        public GestionUtilisateurs(int id, string login)
        {
            this.id = id;
            this.login = login;
        }
        
        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public string Login
        {
            get => this.login;
            set => this.login = value;
        }
        // méthode pour récupérer les données stocker de l'utilisateur connecté
        public static int IdLog { 
            get => idLog; 
            set => idLog = value; 
        }
        public static string LoginLog { 
            get => loginLog; 
            set => loginLog = value; 
        }
        public static char RoleLog { 
            get => roleLog; 
            set => roleLog = value; 
        }

        private static GestionUtilisateurs uneGestionUtilisateurs; // objet BLL

        // Accesseur en lecture
        public static GestionUtilisateurs GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new GestionUtilisateurs();
            }

            return uneGestionUtilisateurs;
        }

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

        // Méthode qui va récuperer et stocker les données de l'utilisateur lors de la connection
        // stockage de l'id / login / role
        // la méthode GetUtilisateurLog() de la DAL
        public static void logUtilisateur(string login)
        {
            Utilisateur utilisateur;
            utilisateur = UtilisateurDAO.GetUtilisateurLog(login);

            IdLog = utilisateur.Id;
            LoginLog = utilisateur.Login;
            RoleLog = utilisateur.Role;

        }

        // Méthode qui renvoi l’objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutUtilisateur de la DAL
        public static int CreerUtilisateur(Utilisateur ut)
        {
            return UtilisateurDAO.AjoutUtilisateur(ut);
        }

        // Méthode qui modifie un nouvel Utilisateur avec la méthode
        // UpdateUtilisateur de la DAL
        public static int ModifierUtilisateur(Utilisateur ut)
        {
            return UtilisateurDAO.UpdateUtilisateur(ut);
        }

        // Méthode qui supprime un Utilisateur avec la méthode
        // DeleteUtilisateur de la DAL
        public static int SupprimerUtilisateur(int id)
        {
            return UtilisateurDAO.DeleteUtilisateur(id);
        }
    }
}
