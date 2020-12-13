using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using AsoSportiveBLL; // Référence la couche BLL
using AsoSportiveBO; // Référence la couche BO
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace AsoSportiveGUI
{
    public partial class FrmAjoutEleve : Form
    {
        public FrmAjoutEleve()
        {
            InitializeComponent();
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
            comboBoxClasse.DataSource = GestionClasse.GetLesClasses();
            comboBoxClasse.DisplayMember = "libelle";

        }

        private void btnAnnulerAjoutEleve_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmDetailsEleve frmDetailsEleve = new FrmDetailsEleve();
            frmDetailsEleve.Show(); // ouverture du formulaire
        }

        private void btnAjoutEleve_Click(object sender, EventArgs e)
        {
            if(!GestionAdherent.GetRegexString(txtNom.Text, Adherent.REGEX_STRING1))
            {
                errorNom.SetError(txtNom,"Nom saisi incorrect");
            }
            else
            {
                errorNom.SetError(txtNom, "");
            }

            if (!GestionAdherent.GetRegexString(txtPrenom.Text, Adherent.REGEX_STRING1))
            {
                errorPrenom.SetError(txtPrenom, "Prenom saisi incorrect");
            }
            else
            {
                errorPrenom.SetError(txtPrenom, "");
            }

            if (!GestionAdherent.GetRegexString(txtTel.Text, Adherent.REGEX_DIGIT1))
            {
                errorTel.SetError(txtTel, "Numéro de téléphone incorrect");
            }
            else
            {
                errorTel.SetError(txtTel, "");
            }
            if (comboBoxSexe.SelectedIndex != -1)
            {
                errorSexe.SetError(comboBoxSexe, "");               
            }
            else
            {
                errorSexe.SetError(comboBoxSexe, "Veuillez sélectionner un sexe");
            }

            if (!GestionAdherent.GetRegexString(txtTelParent.Text, Adherent.REGEX_DIGIT1))
            {
                errorTelParent.SetError(txtTelParent, "Numéro de téléphone incorrect");
            }
            else
            {
                errorTelParent.SetError(txtTelParent, "");
            }
            
            if (string.IsNullOrEmpty(txtMail.Text))
            {
                errorMail.SetError(txtMail, "Mail saisie incorrect");
            }
            else
            {
                try
                {
                    string addressMail = new MailAddress(txtMail.Text).Address;
                    errorMail.SetError(txtMail, "");
                }
                catch (Exception ex)
                {
                    errorMail.SetError(txtMail, ex.Message);
                }                       
            }

            if (!GestionAdherent.GetRegexString(txtId.Text, Adherent.REGEX_STRING1))
            {
                errorId.SetError(txtId, "Identifiant saisi incorrect");
            }
            else
            {
                errorId.SetError(txtId, "");
            }

            if (!GestionAdherent.GetRegexString(txtMdp.Text, Adherent.REGEX_STRING1))
            {
                errorMdp.SetError(txtMdp, "Mot de passe saisi incorrect");
            }
            else
            {
                errorMdp.SetError(txtMdp, "");
            }
        }
    }
}
