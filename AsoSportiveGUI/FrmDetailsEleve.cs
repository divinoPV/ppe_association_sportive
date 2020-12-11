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

            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Local"]);
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

                Label lblPrenom = new Label();
                lblPrenom.Text = adherent.Prenom;
                lblPrenom.AutoSize = true;
                lblPrenom.Location = new Point(x, y);

                Label lblClasse = new Label();
                lblClasse.Text = adherent.Classe.Libelle;
                lblClasse.AutoSize = true;
                lblClasse.Location = new Point(x, y);

                Label lblDdn = new Label();
                lblDdn.Text = adherent.Ddn.ToString();
                lblDdn.AutoSize = true;
                lblDdn.Location = new Point(x, y);

                Label lblSexe = new Label();
                lblSexe.Text = adherent.Sexe.ToString();
                lblSexe.AutoSize = true;
                lblSexe.Location = new Point(x, y);

                Label lblNum = new Label();
                lblNum.Text = adherent.NumTel;
                lblNum.AutoSize = true;
                lblNum.Location = new Point(x, y);

                Label lblNumPrnt = new Label();
                lblNumPrnt.Text = adherent.NumParnt;
                lblNumPrnt.AutoSize = true;
                lblNumPrnt.Location = new Point(x, y);

                Label lblEmail = new Label();
                lblEmail.Text = adherent.Email;
                lblEmail.AutoSize = true;
                lblEmail.Location = new Point(x, y);

                Label lblMaj = new Label();
                lblMaj.Text = adherent.DateMaj.ToString();
                lblMaj.AutoSize = true;
                lblMaj.Location = new Point(x, y);

                Button btnUpdate = new Button();
                btnUpdate.Text = "Modifier";
                btnUpdate.AutoSize = true;
                btnUpdate.Location = new Point(x, y);

                Button btnDelete = new Button();
                btnDelete.Text = "Supprimer";
                btnDelete.AutoSize = true;
                btnDelete.Location = new Point(x, y);

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
    }
}
