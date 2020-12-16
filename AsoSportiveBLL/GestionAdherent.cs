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

        // Méthode qui renvoit une valeur booléen en faisant appel à
        // la méthode VerifAdherent() de la DAL
        public static bool VerifAdherent(string value)
        {
            return AdherentDAO.VerifAdherent(value);
        }

        // Méthode qui renvoit une valeur booléen en faisant appel à
        // la méthode VerifAdherentByIdAndLogin() de la DAL
        public static bool VerifAdherentByLoginAndId(string value, int id)
        {
            return AdherentDAO.VerifAdherentByLoginAndId(value, id);
        }

        // Méthode qui renvoit une List d'objets Adherent en faisant appel à
        // la méthode GetAdherent() de la DAL
        public static List<Adherent> GetAdherent()
        {
            return AdherentDAO.GetAdherent();
        }

        // Méthode qui renvoit une valeur booléen et ajoute un object adherent
        // BD avec la méthode AjoutAdherent de la DAL
        public static bool CreerAdherent(Adherent unAdherent)
        {
            return AdherentDAO.AjoutAdherent(unAdherent);
        }

        // Méthode qui modifie un nouvel Adherent avec la méthode
        // UpdateUtilisateur de la DAL
        public static bool ModifierAdherent(Adherent ut)
        {
            return AdherentDAO.UpdateAdherent(ut);
        }

        // Méthode qui supprime un Adherent avec la méthode
        // DeleteUtilisateur de la DAL
        public static int SupprimerAdherent(int id)
        {
            return AdherentDAO.DeleteAdherent(id);
        }
    }
}
