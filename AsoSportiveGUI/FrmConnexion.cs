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
                GestionUtilisateurs.logUtilisateur(txtId.Text); //sauvegarde des données de l'utilisateur connecté
                this.Hide(); // fermeture du formulaire actuel
                FrmRedirection frmRedirection = new FrmRedirection();
                frmRedirection.Show(); // ouverture du formulaire
            } else {
                MessageBox.Show("Identifiants incorrects.");
                txtId.Clear();
                txtPass.Clear();
            }
        }
    }
}
