﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsoSportiveBO
{
    public class Classe
    {
        private int id;
        private string libelle;

        public Classe() { }
        public Classe(int id)
        {
            this.id = id;
        }
        public Classe(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }

        public string Libelle
        {
            get => this.libelle;
            set => this.libelle = value;
        }
    }
}
