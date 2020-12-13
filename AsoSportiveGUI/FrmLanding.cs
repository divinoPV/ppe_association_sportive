using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AsoSportiveGUI
{
    public partial class FrmLanding : Form
    {
        private Thread thread;

        public FrmLanding(Thread thread)
        {
            InitializeComponent();
            this.thread = thread;
        }

        private void btnLanding_Click(object sender, EventArgs e)
        {
            FrmConnexion frmConnexion = new FrmConnexion();
            this.thread.Start();
            this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close(); // fermeture du formulaire actuel
        }
    }
}
