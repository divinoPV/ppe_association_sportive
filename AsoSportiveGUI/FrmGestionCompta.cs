using AsoSportiveBLL;
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
using AsoSportiveBO;

namespace AsoSportiveGUI
{
    public partial class FrmGestionCompta : Form
    {
        public const int Coord = 20;
        public const string PnlResultat = "pnlResultat";

        public FrmGestionCompta()
        {
            InitializeComponent();

            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            this.setPnlResultatLabel();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            while (pnlResultat.Controls.Count > 13)
            {
                pnlResultat.Controls.RemoveAt(pnlResultat.Controls.Count - 1);
            }
            
            this.resultat();
        }

        private void resultat()
        {
            this.setPnlAdherent();
        }

        private void setPnlResultatLabel()
        {
            List<Label> labels = new List<Label>();
            labels.Add(this.setLabel("Nom complet"));
            labels.Add(this.setLabel("Nom"));
            labels.Add(this.setLabel("Prénom"));
            labels.Add(this.setLabel("Née le"));
            labels.Add(this.setLabel("N° tel"));
            labels.Add(this.setLabel("Email"));
            labels.Add(this.setLabel("N° tel parent"));
            labels.Add(this.setLabel("Prélèvement automatique"));
            labels.Add(this.setLabel("Genre"));
            labels.Add(this.setLabel("Modifier le"));
            labels.Add(this.setLabel("Archiver"));
            labels.Add(this.setLabel("Créer par"));
            labels.Add(this.setLabel("Classe"));

            this.putLabelInPnl(labels);
        }

        private void setPnlAdherent()
        {
            List<Adherent> adherents = GestionAdherent.GetAdherentRecherche(this.txtRecherche.Text);

            int y = Coord;

            foreach (Adherent adherent in adherents)
            {
                List<Label> labels = new List<Label>();
                labels.Add(this.setLabel(adherent.Nom.Trim() + ' ' + adherent.Prenom.Trim(), y: Coord));
                labels.Add(this.setLabel(adherent.Nom.Trim(), y: y));
                labels.Add(this.setLabel(adherent.Prenom.Trim(), y: y));
                labels.Add(this.setLabel(adherent.Ddn.ToString(), y: y));
                labels.Add(this.setLabel(adherent.NumTel.Trim(), y: y));
                labels.Add(this.setLabel(adherent.Email.Trim(), y: y));
                labels.Add(this.setLabel(adherent.NumParnt.Trim(), y: y));
                labels.Add(this.setLabel(adherent.AutPrelev.ToString(), y: y));
                labels.Add(this.setLabel(adherent.Sexe.ToString(), y: y));
                labels.Add(this.setLabel(adherent.DateMaj.ToString(), y: y));
                labels.Add(this.setLabel(adherent.Archive.ToString(), y: y));
                labels.Add(this.setLabel(adherent.Utilisateur.Login.ToString(), y: y));
                labels.Add(this.setLabel(adherent.Classe.Libelle.Trim(), y: y));

                y += 20;

                this.putLabelInPnl(labels);
            }
        }

        private void putLabelInPnl(List<Label> labels)
        {
            foreach (Label label in labels) { this.Controls.Find(PnlResultat, true)[0].Controls.Add(label); }
        }

        private Label setLabel(string text, int x = Coord, int y = Coord)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.AutoSize = true;
            lbl.Location = new Point(x, y);
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;

            return lbl;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmRedirection frmRedirection = new FrmRedirection();
            frmRedirection.Show(); // ouverture du formulaire
        }
    }
}
