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
            /*bool errorActive = false;
            char sexeSelect = ' ';

            DateTime dateMaj = new DateTime();
            dateMaj = DateTime.Now;

            // verification des champs du formulaire ajour d'un adhérent
            if (!GestionAdherent.GetRegexString(txtNom.Text, Adherent.REGEX_STRING1))
            {
                errorNom.SetError(txtNom, "Nom saisi incorrect, aucun caratères spéciaux et aucun espace, 3 à 20 caractères");
                errorActive = true;
            }
            else
            {
                errorNom.SetError(txtNom, "");
            }

            if (!GestionAdherent.GetRegexString(txtPrenom.Text, Adherent.REGEX_STRING1))
            {
                errorPrenom.SetError(txtPrenom, "Prénom saisi incorrect, aucun caratères spéciaux et aucun espace, 3 à 20 caractères");
                errorActive = true;
            }
            else
            {
                errorPrenom.SetError(txtPrenom, "");
            }

            if (errorActive)
            {
                MessageBox.Show("Error : eleve non ajouté", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                if (GestionAdherent.CreerAdherent(unAdherent))
                {
                    MessageBox.Show("Valide : eleve ajouté", "Valide", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.Hide(); // fermeture du formulaire actuel
                    FrmAjoutEleve frmAjoutEleve = new FrmAjoutEleve();
                    frmAjoutEleve.Show(); // ouverture du formulaire
                }
                else
                {
                    MessageBox.Show("Error : error lors de l'insertion", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/

        }
    }
}
