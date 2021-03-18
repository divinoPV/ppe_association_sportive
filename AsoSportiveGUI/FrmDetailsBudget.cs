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

            int x = 20;
            int y = 20;

            this.budget(x, y);
            this.flux(x, y);
        }

        public void budget(int x, int y)
        {
            List<Budget> budgets = GestionBudget.GetLesBudget();

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

        public void flux(int x, int y)
        {
            List<Flux> fluxs = GestionFlux.GetLesFlux();

            foreach (Flux flux in fluxs)
            {
                y += 20;

                Label lblLibelle = new Label();
                lblLibelle.Text = flux.Libelle.Trim();
                lblLibelle.AutoSize = true;
                lblLibelle.Location = new Point(x, y);
                lblLibelle.Dock = DockStyle.Fill;
                lblLibelle.TextAlign = ContentAlignment.MiddleCenter;

                Label lblAdherent = new Label();
                lblAdherent.Text = flux.Adherent.Nom.Trim();
                lblAdherent.AutoSize = true;
                lblAdherent.Location = new Point(x, y);
                lblAdherent.Dock = DockStyle.Fill;
                lblAdherent.TextAlign = ContentAlignment.MiddleCenter;

                Label lblMontant = new Label();
                lblMontant.Text = flux.Montant.ToString();
                lblMontant.AutoSize = true;
                lblMontant.Location = new Point(x, y);
                lblMontant.Dock = DockStyle.Fill;
                lblMontant.TextAlign = ContentAlignment.MiddleCenter;

                Label lblPrelevement = new Label();
                lblPrelevement.Text = flux.Prelevement.ToString();
                lblPrelevement.AutoSize = true;
                lblPrelevement.Location = new Point(x, y);
                lblPrelevement.Dock = DockStyle.Fill;
                lblPrelevement.TextAlign = ContentAlignment.MiddleCenter;

                Button btnUpdate = new Button();
                btnUpdate.Tag = flux;
                btnUpdate.Text = "Modifier";
                btnUpdate.AutoSize = true;
                btnUpdate.Location = new Point(x, y);
                btnUpdate.Dock = DockStyle.Fill;
                btnUpdate.Click += new EventHandler(btnUpdate_Click);
                btnUpdate.TextAlign = ContentAlignment.MiddleCenter;

                Button btnDelete = new Button();
                btnDelete.Tag = flux.Id;
                btnDelete.Text = "Supprimer";
                btnDelete.AutoSize = true;
                btnDelete.Location = new Point(x, y);
                btnDelete.Dock = DockStyle.Fill;
                btnDelete.Click += new EventHandler(btnDelete_Click);
                btnDelete.TextAlign = ContentAlignment.MiddleCenter;

                this.Controls.Find("pnl", true)[0].Controls.Add(lblLibelle);
                this.Controls.Find("pnl", true)[0].Controls.Add(lblAdherent);
                this.Controls.Find("pnl", true)[0].Controls.Add(lblMontant);
                this.Controls.Find("pnl", true)[0].Controls.Add(lblPrelevement);
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
