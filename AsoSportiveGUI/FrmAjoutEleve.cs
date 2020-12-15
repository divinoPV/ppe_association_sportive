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
            //liste des sexes d'adhérent
            List<string> lesSexes = new List<string>();

            InitializeComponent();

            //insère les objects classes issus de la BDD dans le comboBoxClasses
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
            comboBoxClasse.DataSource = GestionClasse.GetLesClasses();
            comboBoxClasse.DisplayMember = "libelle";

            lesSexes.Add("Femme");
            lesSexes.Add("Homme");
            comboBoxSexe.DataSource = lesSexes;

        }

        private void btnAnnulerAjoutEleve_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmDetailsEleve frmDetailsEleve = new FrmDetailsEleve();
            frmDetailsEleve.Show(); // ouverture du formulaire
        }

        private void btnAjoutEleve_Click(object sender, EventArgs e)
        {
            bool errorActive = false;
            char sexeSelect = ' ';

            DateTime dateMaj = new DateTime();
            dateMaj = DateTime.Now;

            // verification des champs du formulaire ajour d'un adhérent
            if(!GestionAdherent.GetRegexString(txtNom.Text, Adherent.REGEX_STRING1))
            {
                errorNom.SetError(txtNom,"Nom saisi incorrect");
                errorActive = true;
            }
            else
            {
                errorNom.SetError(txtNom, "");
            }

            if (!GestionAdherent.GetRegexString(txtPrenom.Text, Adherent.REGEX_STRING1))
            {
                errorPrenom.SetError(txtPrenom, "Prenom saisi incorrect");
                errorActive = true;
            }
            else
            {
                errorPrenom.SetError(txtPrenom, "");
            }

            if (Convert.ToString(comboBoxSexe.SelectedValue) == "Femme")
            {
                sexeSelect = 'F';
            }
            else
            {
                sexeSelect = 'H';
            }

            if (!GestionAdherent.GetRegexString(txtTel.Text, Adherent.REGEX_DIGIT1))
            {
                errorTel.SetError(txtTel, "Numéro de téléphone incorrect << exemple : 0102030102 >>");
                errorActive = true;
            }
            else
            {
                errorTel.SetError(txtTel, "");
            }

            if (!GestionAdherent.GetRegexString(txtTelParent.Text, Adherent.REGEX_DIGIT1))
            {
                errorTelParent.SetError(txtTelParent, "Numéro de téléphone incorrect << exemple : 0102030102 >>");
                errorActive = true;
            }
            else
            {
                errorTelParent.SetError(txtTelParent, "");
            }
            
            if (string.IsNullOrEmpty(txtMail.Text))
            {
                errorMail.SetError(txtMail, "Veuillez saisir un mail");
                errorActive = true;
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
                    errorActive = true;
                }                       
            }

            if (!GestionAdherent.GetRegexString(txtId.Text, Adherent.REGEX_STRING_LOGIN1))
            {
                errorId.SetError(txtId, "Identifiant saisi incorrect << exemple : nom.prenom >>");
                errorActive = true;
            }
            else
            {
                if (GestionAdherent.VerifAdherent(txtId.Text))
                {
                    errorId.SetError(txtId, "Identifiant déjà utilisé");
                }
                else
                {
                    errorId.SetError(txtId, "");
                }               
            }

            if (!GestionAdherent.GetRegexString(txtMdp.Text, Adherent.REGEX_PASSWORD1))
            {
                errorMdp.SetError(txtMdp, "Votre mot de passe doit comporter au minimum '1 miniscule, 1 majuscule, 1 chiffre, 1 charactère spécial");
                errorActive = true;
            }
            else
            {
                errorMdp.SetError(txtMdp, "");
            }

            if (txtMdp.Text != txtConfirmMdp.Text)
            {
                errorConfirmMdp.SetError(txtConfirmMdp, "Veuillez saisir le même mot de passe");
                errorActive = true;
            }

            if (errorActive)
            {
                MessageBox.Show("Error : eleve non ajouté","Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Adherent unAdherent = new Adherent(0, txtNom.Text, txtPrenom.Text, dtpNaissance.Value, txtTel.Text, 
                    txtMail.Text, txtTelParent.Text, checkPrelevement.Checked, sexeSelect, txtId.Text, txtMdp.Text, dateMaj, false, Utilisateur.UtilisateurLog, (Classe)comboBoxClasse.SelectedItem);
                
                

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
            }
        }
    }
}
