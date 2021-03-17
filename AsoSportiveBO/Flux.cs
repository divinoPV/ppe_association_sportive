using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsoSportiveBO
{
    public class Flux
    {
        private const string REGEX_STRING = "^[A-Za-z]{3,20}$";

        private int id;
        private string libelle;
        private DateTime date;
        private decimal montant;
        private bool prelevement;
        private Adherent adherent;
        private Budget budget;
        private TypeFlux typeFlux;

        private static Flux fluxSauvegarder;

        public Flux(int id, string libelle, DateTime date, decimal montant, bool prelevement, Adherent adherent, Budget budget, TypeFlux typeFlux)
        {
            this.id = id;
            this.libelle = libelle;
            this.date = date;
            this.montant = montant;
            this.prelevement = prelevement;
            this.adherent = adherent;
            this.budget = budget;
            this.typeFlux = typeFlux;
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

        public DateTime Date { 
            get => date; 
            set => date = value; 
        }

        public decimal Montant { 
            get => montant; 
            set => montant = value; 
        }

        public bool Prelevement { 
            get => prelevement; 
            set => prelevement = value; 
        }

        public Adherent Adherent { 
            get => adherent; 
            set => adherent = value; 
        }

        public Budget Budget { 
            get => budget; 
            set => budget = value; 
        }

        public TypeFlux TypeFlux { 
            get => typeFlux; 
            set => typeFlux = value; 
        }

        public static Flux FluxSauvegarder { 
            get => fluxSauvegarder; 
            set => fluxSauvegarder = value; 
        }
    }
}
