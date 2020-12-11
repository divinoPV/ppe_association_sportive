using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsoSportiveBLL;
using AsoSportiveBO;

namespace AsoSportiveGUI
{
    public partial class FrmRedirection : Form
    {
        public FrmRedirection()
        {
            InitializeComponent();

            string id = Convert.ToString(Utilisateur.IdLog);
            string login = Utilisateur.LoginLog;
            string role = Convert.ToString(Utilisateur.RoleLog);

            // affiche les données de l'utilisateur connecté
            idLabel.Text = "Votre identifiant est : " + id;
            loginLabel.Text = "bonjour, " + login;  
            if(role == "a")
            {
                roleLabel.Text = "L'utilisateur est un administrateur";
            }
            else
            {
                roleLabel.Text = "L'utilisateur est un comptable";
            }
            
        }

        private void btnFrmAjout_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmAjoutEleve frmAjoutEleve = new FrmAjoutEleve();
            frmAjoutEleve.Show(); // ouverture du formulaire
        }
    }
}
