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
            btnFrmAjout.Visible = false;
            // affiche les données de l'utilisateur connecté 
            if(role == "a")
            {
                btnFrmAjout.Visible = true;
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
