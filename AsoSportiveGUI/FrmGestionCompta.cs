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
        public const string PnlResultat = "pnlResultat";

        public FrmGestionCompta()
        {
            InitializeComponent();

            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            this.setPnlResultatLabel();
        }

        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                while (pnlResultat.Controls.Count > 13)
                {
                    pnlResultat.Controls.RemoveAt(pnlResultat.Controls.Count - 1);
                }

                this.setPnlAdherent();
            }
        }

        private void setPnlResultatLabel()
        {
            List<Label> labels = new List<Label>();
            labels.Add(FrmUtilitaire.setLabel("Nom complet"));
            labels.Add(FrmUtilitaire.setLabel("Nom"));
            labels.Add(FrmUtilitaire.setLabel("Prénom"));
            labels.Add(FrmUtilitaire.setLabel("Née le"));
            labels.Add(FrmUtilitaire.setLabel("N° tel"));
            labels.Add(FrmUtilitaire.setLabel("Email"));
            labels.Add(FrmUtilitaire.setLabel("N° tel parent"));
            labels.Add(FrmUtilitaire.setLabel("Prélèvement automatique"));
            labels.Add(FrmUtilitaire.setLabel("Genre"));
            labels.Add(FrmUtilitaire.setLabel("Modifier le"));
            labels.Add(FrmUtilitaire.setLabel("Archiver"));
            labels.Add(FrmUtilitaire.setLabel("Créer par"));
            labels.Add(FrmUtilitaire.setLabel("Classe"));

            FrmUtilitaire.init().putLabelInPnl(labels, this.findControl(PnlResultat));
        }

        private void setPnlAdherent()
        {
            List<Adherent> adherents = GestionAdherent.GetAdherentRecherche(this.txtRecherche.Text);

            int y = FrmUtilitaire.Coord;

            foreach (Adherent adherent in adherents)
            {
                List<Label> labels = new List<Label>();
                labels.Add(FrmUtilitaire.setLabel(adherent.Nom.Trim() + ' ' + adherent.Prenom.Trim(), y: FrmUtilitaire.Coord));
                labels.Add(FrmUtilitaire.setLabel(adherent.Nom.Trim(), y: y));
                labels.Add(FrmUtilitaire.setLabel(adherent.Prenom.Trim(), y: y));
                labels.Add(FrmUtilitaire.setLabel(adherent.Ddn.ToString(), y: y));
                labels.Add(FrmUtilitaire.setLabel(adherent.NumTel.Trim(), y: y));
                labels.Add(FrmUtilitaire.setLabel(adherent.Email.Trim(), y: y));
                labels.Add(FrmUtilitaire.setLabel(adherent.NumParnt.Trim(), y: y));
                labels.Add(FrmUtilitaire.setLabel(adherent.AutPrelev.ToString(), y: y));
                labels.Add(FrmUtilitaire.setLabel(adherent.Sexe.ToString(), y: y));
                labels.Add(FrmUtilitaire.setLabel(adherent.DateMaj.ToString(), y: y));
                labels.Add(FrmUtilitaire.setLabel(adherent.Archive.ToString(), y: y));
                labels.Add(FrmUtilitaire.setLabel(adherent.Utilisateur.Login.ToString(), y: y));
                labels.Add(FrmUtilitaire.setLabel(adherent.Classe.Libelle.Trim(), y: y));

                y += 20;

                FrmUtilitaire.init().putLabelInPnl(labels, this.findControl(PnlResultat));
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmRedirection frmRedirection = new FrmRedirection();
            frmRedirection.Show(); // ouverture du formulaire
        }

        public Control[] findControl(string key, bool boolean = true)
        {
            return this.Controls.Find(key, boolean);
        }
    }
}
