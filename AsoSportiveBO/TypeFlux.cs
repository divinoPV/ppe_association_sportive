﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsoSportiveBO
{
    public class TypeFlux
    {
        private int id;
        private string libelle;

        public TypeFlux()
        { }

        public TypeFlux(int id)
        {
            this.id = id;
        }
        public TypeFlux(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int Id { 
            get => id; 
            set => id = value; 
        }

        public string Libelle { 
            get => libelle; 
            set => libelle = value; 
        }
    }
}
