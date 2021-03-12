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
using AsoSportiveBLL; // Référence la couche BLL
using AsoSportiveBO; // Référence la couche BO

namespace AsoSportiveGUI
{
    public partial class FrmAjoutFlux : Form
    {
        public FrmAjoutFlux()
        {
            InitializeComponent();
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
            comboBoxEleve.DataSource = GestionAdherent.GetAdherent();
            comboBoxEleve.DisplayMember = "FullName";
            comboBoxBudget.DataSource = GestionBudget.GetLesBudget();
            comboBoxBudget.DisplayMember = "libelle";
            comboBoxTypeTransac.DataSource = GestionTypeFlux.GetLesTypeFlux();
            comboBoxTypeTransac.DisplayMember = "libelle";
        }

        private void btnAjoutFlux_Click(object sender, EventArgs e)
        {

        }
    }
}
