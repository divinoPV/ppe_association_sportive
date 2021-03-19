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
    public partial class FrmModifFlux : Form
    {
        public FrmModifFlux()
        {
            InitializeComponent();
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
            comboBoxEleve.DataSource = GestionAdherent.GetAdherent();
            comboBoxEleve.DisplayMember = "FullName";
            comboBoxTypeTransac.DataSource = GestionTypeFlux.GetLesTypeFlux();
            comboBoxTypeTransac.DisplayMember = "libelle";

            //récupération du flux sauvegarder via le button modif du FrmDetailsFlux
            Flux fluxSauvegarder = Flux.FluxSauvegarder;

            //initialisation des données par default avec les données du flux récupérer
            txtNom.Text = fluxSauvegarder.Libelle.Trim();
            numUpMontant.Value = fluxSauvegarder.Montant;
            dtpDate.Value = fluxSauvegarder.Date;
            checkPrelevement.Checked = fluxSauvegarder.Prelevement;
            comboBoxEleve.SelectedItem = fluxSauvegarder.Adherent;
            comboBoxTypeTransac.SelectedItem = fluxSauvegarder.TypeFlux;

        }

        private void btnModifFlux_Click(object sender, EventArgs e)
        {
            bool errorActive = false;
            int id = Flux.FluxSauvegarder.Id;

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
                MessageBox.Show("Error : flux non modifié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Flux unFlux = new Flux(id, txtNom.Text, dtpDate.Value, numUpMontant.Value, checkPrelevement.Checked,
                    (Adherent)comboBoxEleve.SelectedItem, Flux.FluxSauvegarder.Budget, (TypeFlux)comboBoxTypeTransac.SelectedItem);


                if (GestionFlux.ModifierFlux(unFlux))
                {
                    MessageBox.Show("Valide : flux modifié", "Valide", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.Hide(); // fermeture du formulaire actuel
                    FrmDetailsBudget frmDetailsBudget = new FrmDetailsBudget();
                    frmDetailsBudget.Show(); // ouverture du formulaire
                }
                else
                {
                    MessageBox.Show("Error : error lors de la modification", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAnnulerModifFlux_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmDetailsBudget frmDetailsBudget = new FrmDetailsBudget();
            frmDetailsBudget.Show(); // ouverture du formulaire
        }
    }
}
