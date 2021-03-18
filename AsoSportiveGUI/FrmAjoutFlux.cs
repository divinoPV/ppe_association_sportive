using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsoSportiveBLL; // Référence la couche BLL
using AsoSportiveBO; // Référence la couche BO

namespace AsoSportiveGUI
{
    public partial class FrmAjoutFlux : Form
    {
        public FrmAjoutFlux()
        {
            InitializeComponent();
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
            comboBoxEleve.DataSource = GestionAdherent.GetAdherent();
            comboBoxEleve.DisplayMember = "FullName";
            comboBoxBudget.DataSource = GestionBudget.GetLesBudget();
            comboBoxBudget.DisplayMember = "libelle";
            comboBoxTypeTransac.DataSource = GestionTypeFlux.GetLesTypeFlux();
            comboBoxTypeTransac.DisplayMember = "libelle";
        }

        private void btnAjoutFlux_Click(object sender, EventArgs e)
        {
            bool errorActive = false;

            // verification des champs du formulaire ajout d'un flux
            if (!GestionFlux.GetRegexString(txtNom.Text, Flux.REGEX_STRING1))
            {
                errorNom.SetError(txtNom, "Nom saisi incorrect, aucun caratères spéciaux et aucun espace, 3 à 20 caractères");
                errorActive = true;
            }
            else
            {
                errorNom.SetError(txtNom, "");
            }

            if (!(numUpMontant.Value >= 1))
            {
                errorMontant.SetError(numUpMontant, "Veuillez saisir un montant valide");
                errorActive = true;
            }
            else
            {
                errorMontant.SetError(numUpMontant, "");
            }

            if (errorActive)
            {
                MessageBox.Show("Error : flux non ajouté", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Flux unFlux = new Flux(0, txtNom.Text, dtpDate.Value, numUpMontant.Value, checkPrelevement.Checked,
                    (Adherent)comboBoxEleve.SelectedItem, (Budget)comboBoxBudget.SelectedItem, (TypeFlux)comboBoxTypeTransac.SelectedItem);


                if (GestionFlux.CreerFlux(unFlux))
                {
                    MessageBox.Show("Valide : flux ajouté", "Valide", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.Hide(); // fermeture du formulaire actuel
                    FrmDetailsBudget frmDetailsBudget = new FrmDetailsBudget();
                    frmDetailsBudget.Show(); // ouverture du formulaire
                }
                else
                {
                    MessageBox.Show("Error : error lors de l'insertion", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAnnulerAjoutFlux_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmDetailsBudget frmDetailsBudget = new FrmDetailsBudget();
            frmDetailsBudget.Show(); // ouverture du formulaire
        }
    }
}
