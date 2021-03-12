using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsoSportiveBO
{
    public class Budget
    {
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
