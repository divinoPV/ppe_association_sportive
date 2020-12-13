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
    public class GestionAdherent
    {
        public GestionAdherent()
        { }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion
        // de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetChaineConnexion(chaine);
        }
        // Méthode qui renvoit une valeur booléen en faisant appel à
        // la méthode GetRegexString() de la DAL
        public static bool GetRegexString(string value, string regex)
        {
            return AdherentDAO.GetRegexString(value, regex);
        }
        // Méthode qui renvoit une List d'objets Adherent en faisant appel à
        // la méthode GetAdherent()() de la DAL
        public static List<Adherent> GetAdherent()
        {
            return AdherentDAO.GetAdherent();
        }

        // Méthode qui renvoi l’objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutUtilisateur de la DAL
        public static int CreerUtilisateur(Utilisateur ut)
        {
            return AdherentDAO.AjoutAdherent(ut);
        }

        // Méthode qui modifie un nouvel Utilisateur avec la méthode
        // UpdateUtilisateur de la DAL
        public static int ModifierUtilisateur(Utilisateur ut)
        {
            return AdherentDAO.UpdateAdherent(ut);
        }

        // Méthode qui supprime un Utilisateur avec la méthode
        // DeleteUtilisateur de la DAL
        public static int SupprimerUtilisateur(int id)
        {
            return AdherentDAO.DeleteAdherent(id);
        }
    }
}
