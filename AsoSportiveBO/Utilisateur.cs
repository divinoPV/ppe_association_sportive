using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsoSportiveBO
{
    public class Utilisateur
    {
        private int id_utilisateur;
        private string login_utilisateur;
        private string pass_utilisateur;
        private char role_utilisateur;

        public Utilisateur() { }
        public Utilisateur(int id, string login)
        {
            this.id_utilisateur = id;
            this.login_utilisateur = login;
        }

        public Utilisateur(string login, string pass)
        {
            this.login_utilisateur = login;
            this.pass_utilisateur = pass;
        }
        public Utilisateur(int id, string login, char role)
        {
            this.id_utilisateur = id;
            this.login_utilisateur = login;
            this.role_utilisateur = role;
        }
        public Utilisateur(int id, string login, string pass)
        {
            this.id_utilisateur = id;
            this.login_utilisateur = login;
            this.pass_utilisateur = pass;
        }

        public int Id
        {
            get => this.id_utilisateur;
            set => this.id_utilisateur = value;
        }

        public string Login
        {
            get => this.login_utilisateur;
            set => this.login_utilisateur = value;
        }

        public string Pass
        {
            get => this.pass_utilisateur;
            set => this.pass_utilisateur = value;
        }
        public char Role { 
            get => role_utilisateur; 
            set => role_utilisateur = value; 
        }
    }
}
