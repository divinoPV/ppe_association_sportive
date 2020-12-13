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
            List<Adherent> adherents = GestionAdherent.GetAdherent();

            int x = 20;
            int y = 20;

            foreach (Adherent adherent in adherents)
            {
                y += 20;

                Label lblNom = new Label();
                lblNom.Text = adherent.Nom;
                lblNom.AutoSize = true;
                lblNom.Location = new Point(x, y);
                lblNom.Dock = DockStyle.Fill;
                lblNom.TextAlign = ContentAlignment.MiddleCenter;

                Label lblPrenom = new Label();
                lblPrenom.Text = adherent.Prenom;
                lblPrenom.AutoSize = true;
                lblPrenom.Location = new Point(x, y);
                lblPrenom.Dock = DockStyle.Fill;
                lblPrenom.TextAlign = ContentAlignment.MiddleCenter;

                Label lblClasse = new Label();
                lblClasse.Text = adherent.Classe.Libelle;
                lblClasse.AutoSize = true;
                lblClasse.Location = new Point(x, y);
                lblClasse.Dock = DockStyle.Fill;
                lblClasse.TextAlign = ContentAlignment.MiddleCenter;

                Label lblDdn = new Label();
                lblDdn.Text = adherent.Ddn.ToString();
                lblDdn.AutoSize = true;
                lblDdn.Location = new Point(x, y);
                lblDdn.Dock = DockStyle.Fill;
                lblDdn.TextAlign = ContentAlignment.MiddleCenter;

                Label lblSexe = new Label();
                lblSexe.Text = adherent.Sexe.ToString();
                lblSexe.AutoSize = true;
                lblSexe.Location = new Point(x, y);
                lblSexe.Dock = DockStyle.Fill;
                lblSexe.TextAlign = ContentAlignment.MiddleCenter;

                Label lblNum = new Label();
                lblNum.Text = adherent.NumTel;
                lblNum.AutoSize = true;
                lblNum.Location = new Point(x, y);
                lblNum.Dock = DockStyle.Fill;
                lblNum.TextAlign = ContentAlignment.MiddleCenter;

                Label lblNumPrnt = new Label();
                lblNumPrnt.Text = adherent.NumParnt;
                lblNumPrnt.AutoSize = true;
                lblNumPrnt.Location = new Point(x, y);
                lblNumPrnt.Dock = DockStyle.Fill;
                lblNumPrnt.TextAlign = ContentAlignment.MiddleCenter;

                Label lblEmail = new Label();
                lblEmail.Text = adherent.Email;
                lblEmail.AutoSize = true;
                lblEmail.Location = new Point(x, y);
                lblEmail.Dock = DockStyle.Fill;
                lblEmail.TextAlign = ContentAlignment.MiddleCenter;

                Label lblMaj = new Label();
                lblMaj.Text = adherent.DateMaj.ToString();
                lblMaj.AutoSize = true;
                lblMaj.Location = new Point(x, y);
                lblMaj.Dock = DockStyle.Fill;
                lblMaj.TextAlign = ContentAlignment.MiddleCenter;

                Button btnUpdate = new Button();
                btnUpdate.Text = "Modifier";
                btnUpdate.AutoSize = true;
                btnUpdate.Location = new Point(x, y);
                btnUpdate.Dock = DockStyle.Fill;
                btnUpdate.Click += new EventHandler(btnUpdate_Click);
                btnUpdate.TextAlign = ContentAlignment.MiddleCenter;

                Button btnDelete = new Button();
                btnDelete.Text = "Supprimer";
                btnDelete.AutoSize = true;
                btnDelete.Location = new Point(x, y);
                btnDelete.Dock = DockStyle.Fill;
                btnDelete.Click += new EventHandler(btnDelete_Click);
                btnDelete.TextAlign = ContentAlignment.MiddleCenter;

                this.Controls.Find("pnl", true)[0].Controls.Add(lblNom);
                this.Controls.Find("pnl", true)[0].Controls.Add(lblPrenom);
                this.Controls.Find("pnl", true)[0].Controls.Add(lblClasse);
                this.Controls.Find("pnl", true)[0].Controls.Add(lblDdn);
                this.Controls.Find("pnl", true)[0].Controls.Add(lblSexe);
                this.Controls.Find("pnl", true)[0].Controls.Add(lblNum);
                this.Controls.Find("pnl", true)[0].Controls.Add(lblNumPrnt);
                this.Controls.Find("pnl", true)[0].Controls.Add(lblEmail);
                this.Controls.Find("pnl", true)[0].Controls.Add(lblMaj);
                this.Controls.Find("pnl", true)[0].Controls.Add(btnUpdate);
                this.Controls.Find("pnl", true)[0].Controls.Add(btnDelete);
            }
        }
        public void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }
        public void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("au revoir");
        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxStVincent_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmAjoutEleve frmAjoutEleve = new FrmAjoutEleve();
            frmAjoutEleve.Show(); // ouverture du formulaire
        }
    }
}
