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
        private int id_utilisateur;
        private string login_utilisateur;

        public GestionUtilisateurs()
        { }

        public GestionUtilisateurs(string login)
        {
            this.login_utilisateur = login;
        }

        public GestionUtilisateurs(int id, string login)
        {
            this.id_utilisateur = id;
            this.login_utilisateur = login;
        }

        public int Id
        {
            get => this.id_utilisateur;
            set => this.id_utilisateur = value;
        }
        public string Login
        {
            get => this.login_utilisateur;
            set => this.login_utilisateur = value;
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

        public static bool ConnexionUtilisateur(string login, string pass)
        {
            return UtilisateurDAO.ConnexionUtilisateur(login, pass);
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
