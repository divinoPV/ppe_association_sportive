using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsoSportiveBO
{
    public class Utilisateur
    {
        private int id;
        private string login;
        private string pass;
        private char role;

        public Utilisateur() { }
        public Utilisateur(int id)
        {
            this.id = id;
        }
        public Utilisateur(int id, string login)
        {
            this.id = id;
            this.login = login;
        }

        public Utilisateur(string login, string pass)
        {
            this.login = login;
            this.pass = pass;
        }
        public Utilisateur(int id, string login, char role)
        {
            this.id = id;
            this.login = login;
            this.role = role;
        }
        public Utilisateur(int id, string login, string pass)
        {
            this.id = id;
            this.login = login;
            this.pass = pass;
        }

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }

        public string Login
        {
            get => this.login;
            set => this.login = value;
        }

        public string Pass
        {
            get => this.pass;
            set => this.pass = value;
        }
        public char Role { 
            get => role; 
            set => role = value; 
        }
    }
}
