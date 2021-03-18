using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsoSportiveBO
{
    public class Budget
    {
        private const string REGEX_STRING = "^[A-Za-z]{3,20}$";

        private int id;
        private string libelle;
        private decimal montantInitial;

        private static Budget budgetSauvegarder;

        public Budget() { }
        public Budget(int id, string libelle, decimal montantInitial)
        {
            this.Id = id;
            this.libelle = libelle;
            this.montantInitial = montantInitial;
        }

        public static string REGEX_STRING1 => REGEX_STRING;

        public int Id { 
            get => id; 
            set => id = value; 
        }

        public string Libelle { 
            get => libelle; 
            set => libelle = value; 
        }

        public decimal MontantInitial { 
            get => montantInitial; 
            set => montantInitial = value; 
        }

        public static Budget BudgetSauvegarder { 
            get => budgetSauvegarder; 
            set => budgetSauvegarder = value; 
        }
    }
}
