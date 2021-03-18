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
    public class GestionBudget
    {
        public GestionBudget()
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
        public static List<Budget> GetLesBudget()
        {
            return BudgetDAO.GetLesBudget();
        }

        public static bool CreerBudget(Budget unBudget)
        {
            return BudgetDAO.AjoutBudget(unBudget);
        }
        public static bool GetRegexString(string value, string regex)
        {
            return BudgetDAO.GetRegexString(value, regex);
        }
        public static bool ModifierBudget(Budget unBudget)
        {
            return BudgetDAO.UpdateBudget(unBudget);
        }

        public static bool SupprimerBudget(int id)
        {
            return BudgetDAO.DeleteBudget(id);
        }
    }
}
