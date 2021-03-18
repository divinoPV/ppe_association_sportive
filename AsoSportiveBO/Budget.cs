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
        private const string REGEX_DIGIT = "^-?[0-9][0-9.]*$";

        private int id;
        private string libelle;
        private float montantInitial;

        public Budget() { }
        public Budget(int id, string libelle, float montantInitial)
        {
            this.Id = id;
            this.libelle = libelle;
            this.montantInitial = montantInitial;
        }

        public static string REGEX_STRING1 => REGEX_STRING;

        public static string REGEX_DIGIT1 => REGEX_DIGIT;

        public int Id { 
            get => id; 
            set => id = value; 
        }

        public string Libelle { 
            get => libelle; 
            set => libelle = value; 
        }

        public float MontantInitial { 
            get => montantInitial; 
            set => montantInitial = value; 
        }
    }
}
