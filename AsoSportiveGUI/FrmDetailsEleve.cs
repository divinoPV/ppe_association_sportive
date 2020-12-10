using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsoSportiveBLL; // Référence la couche BLL
using AsoSportiveBO; // Référence la couche BO
using System.Configuration;

namespace AsoSportiveGUI
{
    public partial class FrmDetailsEleve : Form
    {
        public FrmDetailsEleve()
        {
            InitializeComponent();

            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
            List<Adherent> utilisateurs = GestionAdherent.GetAdherent();

            int x = 20;
            int y = 20;

            foreach (Adherent utilisateur in utilisateurs)
            {
                y += 20;
                Label lblLogin = new Label();
                lblLogin.Text = utilisateur.Login;
                lblLogin.AutoSize = true;
                lblLogin.Location = new Point(x, y);
               
                this.Controls.Find("pnl", true)[0].Controls.Add(lblLogin);
            }

        }
    }
}
