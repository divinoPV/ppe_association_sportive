using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsoSportiveBO
{
    public class Flux
    {
        private int id;
        private string libelle;
        private DateTime date;
        private float montant;
        private bool prelevement;
        private Adherent adherent;
        private Budget budget;
        private TypeFlux typeFlux;

        public Flux(int id, string libelle, DateTime date, float montant, bool prelevement, Adherent adherent, Budget budget, TypeFlux typeFlux)
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

        public float Montant { 
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
    }
}
