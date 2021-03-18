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
using System.Configuration;

namespace AsoSportiveGUI
{
    public partial class FrmDetailsBudget : Form
    {
        public FrmDetailsBudget()
        {
            InitializeComponent();

            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
            List<Budget> budgets = GestionBudget.GetLesBudget();

            int x = 20;
            int y = 20;

            foreach (Budget budget in budgets)
            {
                y += 20;

                Label lblLibelle = new Label();
                lblLibelle.Text = budget.Libelle.Trim();
                lblLibelle.AutoSize = true;
                lblLibelle.Location = new Point(x, y);
                lblLibelle.Dock = DockStyle.Fill;
                lblLibelle.TextAlign = ContentAlignment.MiddleCenter;

                Label lblMontantInitial = new Label();
                lblMontantInitial.Text = budget.MontantInitial.ToString();
                lblMontantInitial.AutoSize = true;
                lblMontantInitial.Location = new Point(x, y);
                lblMontantInitial.Dock = DockStyle.Fill;
                lblMontantInitial.TextAlign = ContentAlignment.MiddleCenter;

                Button btnUpdate = new Button();
                btnUpdate.Tag = budget;
                btnUpdate.Text = "Modifier";
                btnUpdate.AutoSize = true;
                btnUpdate.Location = new Point(x, y);
                btnUpdate.Dock = DockStyle.Fill;
                btnUpdate.Click += new EventHandler(btnUpdate_Click);
                btnUpdate.TextAlign = ContentAlignment.MiddleCenter;

                Button btnDelete = new Button();
                btnDelete.Tag = budget.Id;
                btnDelete.Text = "Supprimer";
                btnDelete.AutoSize = true;
                btnDelete.Location = new Point(x, y);
                btnDelete.Dock = DockStyle.Fill;
                btnDelete.Click += new EventHandler(btnDelete_Click);
                btnDelete.TextAlign = ContentAlignment.MiddleCenter;

                this.Controls.Find("pnl", true)[0].Controls.Add(lblLibelle);
                this.Controls.Find("pnl", true)[0].Controls.Add(lblMontantInitial);
                this.Controls.Find("pnl", true)[0].Controls.Add(btnUpdate);
                this.Controls.Find("pnl", true)[0].Controls.Add(btnDelete);
            }
        }

        public void btnUpdate_Click(object sender, EventArgs e)
        {
            Button senderButton = sender as Button;
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            Button senderButton = sender as Button;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmAjoutBudget frmAjoutBudget = new FrmAjoutBudget();
            frmAjoutBudget.Show(); // ouverture du formulaire 
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmRedirection frmRedirection = new FrmRedirection();
            frmRedirection.Show(); // ouverture du formulaire
        }

        private void btnAddFlux_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmAjoutFlux frmAjoutFlux = new FrmAjoutFlux();
            frmAjoutFlux.Show(); // ouverture du formulaire  
        }
    }
}
