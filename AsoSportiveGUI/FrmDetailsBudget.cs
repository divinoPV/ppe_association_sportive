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

            Label lblHeadLibelle = new Label();
            lblHeadLibelle.Text = "Libelle";
            lblHeadLibelle.AutoSize = true;
            lblHeadLibelle.Location = new Point(x, y);
            lblHeadLibelle.Dock = DockStyle.Fill;
            lblHeadLibelle.TextAlign = ContentAlignment.MiddleCenter;

            Label lblHeadMontant = new Label();
            lblHeadMontant.Text = "Montant";
            lblHeadMontant.AutoSize = true;
            lblHeadMontant.Location = new Point(x, y);
            lblHeadMontant.Dock = DockStyle.Fill;
            lblHeadMontant.TextAlign = ContentAlignment.MiddleCenter;

            Label lblHeadModifier = new Label();
            lblHeadModifier.Text = "Modifier";
            lblHeadModifier.AutoSize = true;
            lblHeadModifier.Location = new Point(x, y);
            lblHeadModifier.Dock = DockStyle.Fill;
            lblHeadModifier.TextAlign = ContentAlignment.MiddleCenter;

            Label lblHeadDelete = new Label();
            lblHeadDelete.Text = "Supprimer";
            lblHeadDelete.AutoSize = true;
            lblHeadDelete.Location = new Point(x, y);
            lblHeadDelete.Dock = DockStyle.Fill;
            lblHeadDelete.TextAlign = ContentAlignment.MiddleCenter;

            this.Controls.Find("pnl", true)[0].Controls.Add(lblHeadLibelle);
            this.Controls.Find("pnl", true)[0].Controls.Add(lblHeadMontant);
            this.Controls.Find("pnl", true)[0].Controls.Add(lblHeadModifier);
            this.Controls.Find("pnl", true)[0].Controls.Add(lblHeadDelete);

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
                btnDelete.Tag = budget;
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

            List<string> LesBudgets = new List<string>();
            foreach (Flux flux in fluxs)
            {
                LesBudgets.Add(flux.Budget.Libelle.Trim());
            }

            LesBudgets = (List<string>)LesBudgets.Distinct().ToList();

            Label lblHeadLibelle = new Label();
            lblHeadLibelle.Text = "Libelle";
            lblHeadLibelle.AutoSize = true;
            lblHeadLibelle.Location = new Point(x, y);
            lblHeadLibelle.Dock = DockStyle.Fill;
            lblHeadLibelle.TextAlign = ContentAlignment.MiddleCenter;

            Label lblHeadAdherent = new Label();
            lblHeadAdherent.Text = "Adherent";
            lblHeadAdherent.AutoSize = true;
            lblHeadAdherent.Location = new Point(x, y);
            lblHeadAdherent.Dock = DockStyle.Fill;
            lblHeadAdherent.TextAlign = ContentAlignment.MiddleCenter;

            Label lblHeadMontant = new Label();
            lblHeadMontant.Text = "Montant";
            lblHeadMontant.AutoSize = true;
            lblHeadMontant.Location = new Point(x, y);
            lblHeadMontant.Dock = DockStyle.Fill;
            lblHeadMontant.TextAlign = ContentAlignment.MiddleCenter;

            Label lblHeadPrelevement = new Label();
            lblHeadPrelevement.Text = "Prelevement";
            lblHeadPrelevement.AutoSize = true;
            lblHeadPrelevement.Location = new Point(x, y);
            lblHeadPrelevement.Dock = DockStyle.Fill;
            lblHeadPrelevement.TextAlign = ContentAlignment.MiddleCenter;

            Label lblHeadTypeFlux = new Label();
            lblHeadTypeFlux.Text = "Type flux";
            lblHeadTypeFlux.AutoSize = true;
            lblHeadTypeFlux.Location = new Point(x, y);
            lblHeadTypeFlux.Dock = DockStyle.Fill;
            lblHeadTypeFlux.TextAlign = ContentAlignment.MiddleCenter;

            Label lblHeadDate = new Label();
            lblHeadDate.Text = "Date";
            lblHeadDate.AutoSize = true;
            lblHeadDate.Location = new Point(x, y);
            lblHeadDate.Dock = DockStyle.Fill;
            lblHeadDate.TextAlign = ContentAlignment.MiddleCenter;

            Label btnHeadUpdate = new Label();
            btnHeadUpdate.Text = "Modifier";
            btnHeadUpdate.AutoSize = true;
            btnHeadUpdate.Location = new Point(x, y);
            btnHeadUpdate.Dock = DockStyle.Fill;
            btnHeadUpdate.TextAlign = ContentAlignment.MiddleCenter;

            Label btnHeadDelete = new Label();
            btnHeadDelete.Text = "Supprimer";
            btnHeadDelete.AutoSize = true;
            btnHeadDelete.Location = new Point(x, y);
            btnHeadDelete.Dock = DockStyle.Fill;
            btnHeadDelete.TextAlign = ContentAlignment.MiddleCenter;

            this.Controls.Find("pnl2", true)[0].Controls.Add(lblHeadLibelle);
            this.Controls.Find("pnl2", true)[0].Controls.Add(lblHeadAdherent);
            this.Controls.Find("pnl2", true)[0].Controls.Add(lblHeadMontant);
            this.Controls.Find("pnl2", true)[0].Controls.Add(lblHeadTypeFlux);
            this.Controls.Find("pnl2", true)[0].Controls.Add(lblHeadPrelevement);
            this.Controls.Find("pnl2", true)[0].Controls.Add(lblHeadDate);
            this.Controls.Find("pnl2", true)[0].Controls.Add(btnHeadUpdate);
            this.Controls.Find("pnl2", true)[0].Controls.Add(btnHeadDelete);

            foreach (string budget in LesBudgets)
            {
                Label lblBudget = new Label();
                lblBudget.Text = budget.Trim();
                lblBudget.AutoSize = true;
                lblBudget.Location = new Point(x, y);
                lblBudget.Dock = DockStyle.Fill;
                lblBudget.TextAlign = ContentAlignment.MiddleCenter;
                lblBudget.Margin = new Padding(5);
                lblBudget.Font = new Font("Arial", 16, FontStyle.Bold);

                Label lblSpace = new Label();
                lblSpace.Text = "";
                lblSpace.AutoSize = true;
                lblSpace.Location = new Point(x, y);
                lblSpace.Dock = DockStyle.Fill;
                lblSpace.TextAlign = ContentAlignment.MiddleCenter;

                Label lblSpace2 = new Label();
                lblSpace2.Text = "";
                lblSpace2.AutoSize = true;
                lblSpace2.Location = new Point(x, y);
                lblSpace2.Dock = DockStyle.Fill;
                lblSpace2.TextAlign = ContentAlignment.MiddleCenter;

                Label lblSpace3 = new Label();
                lblSpace3.Text = "";
                lblSpace3.AutoSize = true;
                lblSpace3.Location = new Point(x, y);
                lblSpace3.Dock = DockStyle.Fill;
                lblSpace3.TextAlign = ContentAlignment.MiddleCenter;

                Label lblSpace4 = new Label();
                lblSpace4.Text = "";
                lblSpace4.AutoSize = true;
                lblSpace4.Location = new Point(x, y);
                lblSpace4.Dock = DockStyle.Fill;
                lblSpace4.TextAlign = ContentAlignment.MiddleCenter;

                Label lblSpace5 = new Label();
                lblSpace5.Text = "";
                lblSpace5.AutoSize = true;
                lblSpace5.Location = new Point(x, y);
                lblSpace5.Dock = DockStyle.Fill;
                lblSpace5.TextAlign = ContentAlignment.MiddleCenter;

                Label lblSpace6 = new Label();
                lblSpace6.Text = "";
                lblSpace6.AutoSize = true;
                lblSpace6.Location = new Point(x, y);
                lblSpace6.Dock = DockStyle.Fill;
                lblSpace6.TextAlign = ContentAlignment.MiddleCenter;

                Label lblSpace7 = new Label();
                lblSpace7.Text = "";
                lblSpace7.AutoSize = true;
                lblSpace7.Location = new Point(x, y);
                lblSpace7.Dock = DockStyle.Fill;
                lblSpace7.TextAlign = ContentAlignment.MiddleCenter;

                this.Controls.Find("pnl2", true)[0].Controls.Add(lblBudget);
                this.Controls.Find("pnl2", true)[0].Controls.Add(lblSpace);
                this.Controls.Find("pnl2", true)[0].Controls.Add(lblSpace2);
                this.Controls.Find("pnl2", true)[0].Controls.Add(lblSpace3);
                this.Controls.Find("pnl2", true)[0].Controls.Add(lblSpace4);
                this.Controls.Find("pnl2", true)[0].Controls.Add(lblSpace5);
                this.Controls.Find("pnl2", true)[0].Controls.Add(lblSpace6);
                this.Controls.Find("pnl2", true)[0].Controls.Add(lblSpace7);

                foreach (Flux flux in fluxs)
                {
                    if (budget == flux.Budget.Libelle.Trim())
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

                        Label lblTypeFlux = new Label();
                        lblTypeFlux.Text = flux.TypeFlux.Libelle;
                        lblTypeFlux.AutoSize = true;
                        lblTypeFlux.Location = new Point(x, y);
                        lblTypeFlux.Dock = DockStyle.Fill;
                        lblTypeFlux.TextAlign = ContentAlignment.MiddleCenter;

                        string pre = flux.Prelevement == false ? "Non" : "Oui";

                        Label lblPrelevement = new Label();
                        lblPrelevement.Text = pre;
                        lblPrelevement.AutoSize = true;
                        lblPrelevement.Location = new Point(x, y);
                        lblPrelevement.Dock = DockStyle.Fill;
                        lblPrelevement.TextAlign = ContentAlignment.MiddleCenter;

                        Label lblDate = new Label();
                        lblDate.Text = flux.Date.ToString();
                        lblDate.AutoSize = true;
                        lblDate.Location = new Point(x, y);
                        lblDate.Dock = DockStyle.Fill;
                        lblDate.TextAlign = ContentAlignment.MiddleCenter;

                        Button btnUpdate = new Button();
                        btnUpdate.Tag = flux;
                        btnUpdate.Text = "Modifier";
                        btnUpdate.AutoSize = true;
                        btnUpdate.Location = new Point(x, y);
                        btnUpdate.Dock = DockStyle.Fill;
                        btnUpdate.Click += new EventHandler(btnUpdate_Click);
                        btnUpdate.TextAlign = ContentAlignment.MiddleCenter;

                        Button btnDelete = new Button();
                        btnDelete.Tag = flux;
                        btnDelete.Text = "Supprimer";
                        btnDelete.AutoSize = true;
                        btnDelete.Location = new Point(x, y);
                        btnDelete.Dock = DockStyle.Fill;
                        btnDelete.Click += new EventHandler(btnDelete_Click);
                        btnDelete.TextAlign = ContentAlignment.MiddleCenter;

                        this.Controls.Find("pnl2", true)[0].Controls.Add(lblLibelle);
                        this.Controls.Find("pnl2", true)[0].Controls.Add(lblAdherent);
                        this.Controls.Find("pnl2", true)[0].Controls.Add(lblMontant);
                        this.Controls.Find("pnl2", true)[0].Controls.Add(lblTypeFlux);
                        this.Controls.Find("pnl2", true)[0].Controls.Add(lblPrelevement);
                        this.Controls.Find("pnl2", true)[0].Controls.Add(lblDate);
                        this.Controls.Find("pnl2", true)[0].Controls.Add(btnUpdate);
                        this.Controls.Find("pnl2", true)[0].Controls.Add(btnDelete);
                    }
                }
            }   
        }

        public void btnUpdate_Click(object sender, EventArgs e)
        {
            Button senderButton = sender as Button;
            if (senderButton.Tag is Flux)
            {
                Flux.FluxSauvegarder = (Flux)senderButton.Tag;

                this.Hide(); // fermeture du formulaire actuel
                FrmModifFlux frmModifFlux = new FrmModifFlux();
                frmModifFlux.Show(); // ouverture du formulaire
            } else
            {
                Budget.BudgetSauvegarder = (Budget)senderButton.Tag;

                this.Hide(); // fermeture du formulaire actuel
                FrmModifBudget frmModifBudget = new FrmModifBudget();
                frmModifBudget.Show(); // ouverture du formulaire
            } 
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            Button senderButton = sender as Button;
            DialogResult dialogResult;

            if (senderButton.Tag is Flux)
            {
                dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer le flux ?", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    GestionFlux.SupprimerFlux(Convert.ToInt32(((Flux)senderButton.Tag).Id));

                    this.Hide(); // fermeture du formulaire actuel
                    FrmDetailsBudget frmDetailsBudget = new FrmDetailsBudget();
                    frmDetailsBudget.Show(); // ouverture du formulaire
                }

            }
            else
            {
                dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer le budget ? Cela entrainera la suppréssion des flux liés", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    GestionFlux.SupprimerFluxBudget(Convert.ToInt32(((Budget)senderButton.Tag).Id));
                    GestionBudget.SupprimerBudget(Convert.ToInt32(((Budget)senderButton.Tag).Id));

                    this.Hide(); // fermeture du formulaire actuel
                    FrmDetailsBudget frmDetailsBudget = new FrmDetailsBudget();
                    frmDetailsBudget.Show(); // ouverture du formulaire
                }
            }
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
