using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using AsoSportiveBO;
using AsoSportiveDAL;

namespace AsoSportiveBLL
{
    public class GestionFlux
    {
        public GestionFlux()
        { }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion
        // de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetChaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Classe en faisant appel à
        // la méthode GetLesClasses() de la DAL
        public static List<Flux> GetLesFlux()
        {
            return FluxDAO.GetLesFlux();
        }

        // Méthode qui renvoit une List d'objets Classe en faisant appel à
        // la méthode GetLesClasses() de la DAL
        public static bool CreerFlux(Flux unFlux)
        {
            return FluxDAO.AjoutFlux(unFlux);
        }

        public static bool ModifierFlux(Flux unFlux)
        {
            return FluxDAO.UpdateFlux(unFlux);
        }

        public static bool SupprimerFlux(int id)
        {
            return FluxDAO.DeleteFlux(id);
        }
    }
}
