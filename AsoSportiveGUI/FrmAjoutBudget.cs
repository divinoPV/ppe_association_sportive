﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using AsoSportiveBLL; // Référence la couche BLL
using AsoSportiveBO; // Référence la couche BO
using System.Globalization;

namespace AsoSportiveGUI
{
    public partial class FrmAjoutBudget : Form
    {
        public FrmAjoutBudget()
        {
            InitializeComponent();
        }

        private void btnAjoutBudget_Click(object sender, EventArgs e)
        {
            bool errorActive = false;

            // verification des champs du formulaire ajour d'un adhérent
            if (!GestionBudget.GetRegexString(txtBudgetNom.Text, Budget.REGEX_STRING1))
            {
                errorBudgetNom.SetError(txtBudgetNom, "Nom saisi incorrect, aucun caratères spéciaux et aucun espace, 3 à 20 caractères");
                errorActive = true;
            }
            else
            {
                errorBudgetNom.SetError(txtBudgetNom, "");
            }

            if (!(numericUpBudget.Value >=1))
            {
                errorBudgetMontant.SetError(numericUpBudget, "Montant saisi incorrect, veuillez saisir un montant valide");
                errorActive = true;
            }
            else
            {
                errorBudgetMontant.SetError(numericUpBudget, "");
            }

            if (errorActive)
            {
                MessageBox.Show("Error : Budget non ajouté", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Budget unBudget = new Budget(0,txtBudgetNom.Text, numericUpBudget.Value);

                if (GestionBudget.CreerBudget(unBudget))
                {
                    MessageBox.Show("Valide : budget ajouté", "Valide", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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

        private void btnAnnulerAjoutBudget_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmDetailsBudget frmDetailsBudget = new FrmDetailsBudget();
            frmDetailsBudget.Show(); // ouverture du formulaire
        }
    }
}
