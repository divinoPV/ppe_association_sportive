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

            string role = Convert.ToString(Utilisateur.RoleLog);
            btnFrmDetailsEleve.Visible = false;
            // affiche les données de l'utilisateur connecté 
            if(role == "a")
            {
                btnFrmDetailsEleve.Visible = true;
            }
            
        }

        private void btnFrmDetailsEleve_Click(object sender, EventArgs e)
        {        
            this.Hide(); // fermeture du formulaire actuel
            FrmDetailsEleve frmDetailsEleve = new FrmDetailsEleve();
            frmDetailsEleve.Show(); // ouverture du formulaire   
        }
    }
}
