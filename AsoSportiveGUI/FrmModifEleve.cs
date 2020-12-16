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
    public partial class FrmModifEleve : Form
    {
        public FrmModifEleve()
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

            //récupération de l'adhérent sauvegarder via le button modife du FrmDetailsEleve
            Adherent adherentSauvegarder = Adherent.AdherentSauvegarder;

            //initialisation des données par default avec les données de l'adhérent récupérer
            txtNom.Text = adherentSauvegarder.Nom.Trim();
            txtPrenom.Text = adherentSauvegarder.Prenom.Trim();
            if (adherentSauvegarder.Sexe == 'F')
            {
                comboBoxSexe.SelectedIndex = 0;
            }
            else
            {
                comboBoxSexe.SelectedIndex = 1;
            }
            dtpNaissance.Value = adherentSauvegarder.Ddn;
            txtTel.Text = adherentSauvegarder.NumTel.Trim();
            txtTelParent.Text = adherentSauvegarder.NumParnt.Trim();
            txtMail.Text = adherentSauvegarder.Email.Trim();
            checkPrelevement.Checked = adherentSauvegarder.AutPrelev;
            checkArchivage.Checked = adherentSauvegarder.Archive;
            txtId.Text = adherentSauvegarder.Login.Trim();
            txtMdp.Text = adherentSauvegarder.Mdp.Trim();
            txtConfirmMdp.Text = adherentSauvegarder.Mdp.Trim();
            comboBoxClasse.SelectedIndex = adherentSauvegarder.Classe.Id - 1;

        }

        private void btnAnnulerModifEleve_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmDetailsEleve frmDetailsEleve = new FrmDetailsEleve();
            frmDetailsEleve.Show(); // ouverture du formulaire
        }

        private void btnModifEleve_Click(object sender, EventArgs e)
        {
           
            bool errorActive = false;
            char sexeSelect = Adherent.AdherentSauvegarder.Sexe;
            int id = Adherent.AdherentSauvegarder.Id;

            DateTime dateMaj = new DateTime();
            dateMaj = DateTime.Now;

            // verification des champs du formulaire ajour d'un adhérent
            // verification du champs nom
            if (!GestionAdherent.GetRegexString(txtNom.Text, Adherent.REGEX_STRING1))
            {
                errorNom.SetError(txtNom,"Nom saisi incorrect");
                errorActive = true;
            }
            else
            {
                errorNom.SetError(txtNom, "");
            }

            // verification du champs prenom
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

            // verification du champs telephone
            if (!GestionAdherent.GetRegexString(txtTel.Text, Adherent.REGEX_DIGIT1))
            {
                errorTel.SetError(txtTel, "Numéro de téléphone incorrect << exemple : 0102030102 >>");
                errorActive = true;
            }
            else
            {
                errorTel.SetError(txtTel, "");
            }

            // verification du champs tel parent
            if (!GestionAdherent.GetRegexString(txtTelParent.Text, Adherent.REGEX_DIGIT1))
            {
                errorTelParent.SetError(txtTelParent, "Numéro de téléphone incorrect << exemple : 0102030102 >>");
                errorActive = true;
            }
            else
            {
                errorTelParent.SetError(txtTelParent, "");
            }

            // verification du champs mail
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

            // verification du champs identifiant
            if (!GestionAdherent.GetRegexString(txtId.Text, Adherent.REGEX_STRING_LOGIN1))
            {
                errorId.SetError(txtId, "Identifiant saisi incorrect << exemple : nom.prenom >>");
                errorActive = true;
            }
            else
            {
                if (GestionAdherent.VerifAdherentByLoginAndId(txtId.Text, Adherent.AdherentSauvegarder.Id))
                {
                    errorId.SetError(txtId, "Identifiant déjà utilisé");
                    errorActive = true;
                }
                else
                {
                    errorId.SetError(txtId, "");
                }               
            }

            // verification du champs mot de passe
            if (!GestionAdherent.GetRegexString(txtMdp.Text, Adherent.REGEX_PASSWORD1))
            {
                errorMdp.SetError(txtMdp, "Votre mot de passe doit comporter au minimum '1 miniscule, 1 majuscule, 1 chiffre, 1 charactère spécial");
                errorActive = true;
            }
            else
            {
                errorMdp.SetError(txtMdp, "");
            }

            // verification du champs confirmation mot de passe si il egale au champs mot de passe
            if (txtMdp.Text != txtConfirmMdp.Text)
            {
                errorConfirmMdp.SetError(txtConfirmMdp, "Veuillez saisir le même mot de passe");
                errorActive = true;
            }

            // verification si aucune erreur n'a été déclencher
            if (errorActive)
            {
                MessageBox.Show("Error : eleve non modifié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Adherent unAdherent = new Adherent(id, txtNom.Text, txtPrenom.Text, dtpNaissance.Value, txtTel.Text, 
                    txtMail.Text, txtTelParent.Text, checkPrelevement.Checked, sexeSelect, txtId.Text, txtMdp.Text, dateMaj, 
                    checkArchivage.Checked, Utilisateur.UtilisateurLog, (Classe)comboBoxClasse.SelectedItem);

                // modification de l'adherent
                if (GestionAdherent.ModifierAdherent(unAdherent))
                {
                    MessageBox.Show("Valide : eleve modifié", "Valide", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.Hide(); // fermeture du formulaire actuel
                    FrmDetailsEleve frmDetailsEleve = new FrmDetailsEleve();
                    frmDetailsEleve.Show(); // ouverture du formulaire
                }
                else
                {
                    MessageBox.Show("Error : error lors de l'update", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
