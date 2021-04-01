using AsoSportiveBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsoSportiveGUI
{
    public partial class FrmGestionCompta : Form
    {
        public FrmGestionCompta()
        {
            InitializeComponent();
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            dgvRecherche.DataSource = GestionAdherent.GetAdherentRecherche(txtRecherche.Text);
        }
    }
}
