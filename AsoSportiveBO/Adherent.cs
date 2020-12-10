using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsoSportiveBO
{
    public class Adherent
    {
        private int id;
        private string nom;
        private string prenom;
        private DateTime ddn;
        private string numtel;
        private string email;
        private string numparnt;
        private bool autprelev;
        private char sexe;
        private string login;
        private string mdp;
        private DateTime datemaj;
        private bool archive;
        private Utilisateur utilisateur;
        private Classe classe;

        public Adherent() { }
        public Adherent(int id,
                        string nom,
                        string prenom,
                        DateTime ddn,
                        string numtel,
                        string email,
                        string numparnt,
                        bool autprelev,
                        char sexe,
                        string login,
                        string mdp,
                        DateTime datemaj,
                        bool archive,
                        Utilisateur utilisateur,
                        Classe classe)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.ddn = ddn;
            this.numtel = numtel;
            this.email = email;
            this.numparnt = numparnt;
            this.autprelev = autprelev;
            this.sexe = sexe;
            this.login = login;
            this.mdp = mdp;
            this.datemaj = datemaj;
            this.archive = archive;
            this.utilisateur = utilisateur;
            this.classe = classe;
        }

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public string Nom
        {
            get => this.nom;
            set => this.nom = value;
        }
        public string Prenom
        {
            get => this.prenom;
            set => this.prenom = value;
        }
        public DateTime Ddn
        {
            get => this.ddn;
            set => this.ddn = value;
        }
        public string NumTel
        {
            get => this.numtel;
            set => this.numtel = value;
        }
        public string Email
        {
            get => this.email;
            set => this.email = value;
        }
        public string NumParnt
        {
            get => this.numparnt;
            set => this.numparnt = value;
        }
        public bool AutPrelev
        {
            get => this.autprelev;
            set => this.autprelev = value;
        }
        public char Sexe
        {
            get => this.sexe;
            set => this.sexe = value;
        }

        public string Login
        {
            get => this.login;
            set => this.login = value;
        }

        public string Mdp
        {
            get => this.mdp;
            set => this.mdp = value;
        }
        public DateTime DateMaj
        {
            get => this.datemaj;
            set => this.datemaj = value;
        }
        public bool Archive
        {
            get => this.archive;
            set => this.archive = value;
        }
        public Utilisateur Utilisateur
        {
            get => this.utilisateur;
            set => this.utilisateur = value;
        }
        public Classe Classe
        {
            get => this.classe;
            set => this.classe = value;
        }
    }
}
