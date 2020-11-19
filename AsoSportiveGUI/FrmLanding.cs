using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsoSportiveGUI
{
    public partial class FrmLanding : Form
    {
        public FrmLanding()
        {
            InitializeComponent();
        }

        private void btnLanding_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmConnexion frmConnexion= new FrmConnexion();
            frmConnexion.Show(); // ouverture du formulaire
        }
    }
}
