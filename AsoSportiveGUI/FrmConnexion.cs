using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using AsoSportiveBLL; // Référence la couche BLL
using AsoSportiveBO; // Référence la couche BO
using System.Data.SqlClient;

namespace AsoSportiveGUI
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Local"]);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (GestionUtilisateurs.ConnexionUtilisateur(txtId.Text, txtPass.Text) == true) {
                Utilisateur utilisateurLog;

                utilisateurLog = GestionUtilisateurs.logUtilisateur(txtId.Text); //fonction qui récupère un objet utilisateur connecté

                //sauvegarde des données de l'utilisateur connecté
                Utilisateur.IdLog = utilisateurLog.Id;
                Utilisateur.LoginLog = utilisateurLog.Login;
                Utilisateur.RoleLog = utilisateurLog.Role;

                this.Hide();

                FrmDetailsEleve frmDetailsEleve = new FrmDetailsEleve();
                frmDetailsEleve.ShowDialog(); // ouverture du formulaire

                this.Show();

            } else {
                MessageBox.Show("Identifiants incorrects.");
                txtId.Clear();
                txtPass.Clear();
            }
        }
    }
}
