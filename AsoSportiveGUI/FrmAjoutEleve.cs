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
    public partial class FrmAjoutEleve : Form
    {
        public FrmAjoutEleve()
        {
            InitializeComponent();
        }


        private void btnAnnulerAjoutEleve_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmRedirection frmRedirection = new FrmRedirection();
            frmRedirection.Show(); // ouverture du formulaire
        }

        private void btnAjoutEleve_Click(object sender, EventArgs e)
        {

        }
    }
}
