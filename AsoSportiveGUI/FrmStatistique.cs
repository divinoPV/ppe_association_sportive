﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsoSportiveBLL;
using AsoSportiveBO;

namespace AsoSportiveGUI
{
    public partial class FrmStatistique : Form
    {
        public const string PnlStatistiqueParEleve = "pnlStatistiqueParEleve";
        public const string PnlStatistiqueGenre = "pnlStatistiqueGenre";
        public const string BudgetSport = "budget sport";
        public const string Inscription = "inscription";

        public FrmStatistique()
        {
            InitializeComponent();

            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            this.setPnlStatistiqueParEleveLabel();
            this.setPnlStatistiqueParEleveResultat();

            this.setPnlStatistiqueGenreLabel();
            this.setPnlStatistiqueGenreResultat();

            lblNombreAdherent.Text += " " + GestionAdherent.GetAdherent().Count.ToString();

            List<Adherent> lesAdherents = GestionAdherent.GetLesAdherentByNaissance();
            var _bind = from a in lesAdherents
                        select new
                        {
                            nom = a.Nom,
                            prenom = a.Prenom,
                            naissance = a.Ddn,
                            classe = a.Classe.Libelle
                        };

            dgvNaissance.DataSource = _bind.ToList();
        }

        private void setPnlStatistiqueParEleveLabel()
        {
            List<Label> labels = new List<Label>();
            labels.Add(FrmUtilitaire.setLabel("Nom"));
            labels.Add(FrmUtilitaire.setLabel("Prénom"));
            labels.Add(FrmUtilitaire.setLabel("Nombre de participation aux évènements"));

            FrmUtilitaire.init().putLabelInPnl(labels, this.findControl(PnlStatistiqueParEleve));
        }

        private void setPnlStatistiqueParEleveResultat()
        {
            List<Adherent> adherents = GestionAdherent.GetAdherent();
            List<Flux> fluxs = GestionFlux.GetLesFlux();

            int y = FrmUtilitaire.Coord;

            foreach (Adherent adherent in adherents)
            {
                int nbFlux = 0;

                List<Label> labels = new List<Label>();
                labels.Add(FrmUtilitaire.setLabel(adherent.Nom.Trim(), y: y));
                labels.Add(FrmUtilitaire.setLabel(adherent.Prenom.Trim(), y: y));

                foreach (Flux flux in fluxs)
           {
                    if (flux.TypeFlux.Libelle.Trim() == Inscription && flux.Adherent.Id == adherent.Id)
                    {
                        nbFlux += 1;
                    }
                }

                labels.Add(FrmUtilitaire.setLabel(nbFlux.ToString(), y: y));

                y += 20;

                FrmUtilitaire.init().putLabelInPnl(labels, this.findControl(PnlStatistiqueParEleve));
            }
        }

        private void setPnlStatistiqueGenreLabel()
        {
            List<Label> labels = new List<Label>();
            labels.Add(FrmUtilitaire.setLabel("Genre"));
            labels.Add(FrmUtilitaire.setLabel("Nombre d'élève"));

            FrmUtilitaire.init().putLabelInPnl(labels, this.findControl(PnlStatistiqueGenre));
        }

        private void setPnlStatistiqueGenreResultat()
        {
            Dictionary<string, int> genres = new Dictionary<string, int>();
            genres.Add(FrmAjoutEleve.GenreHomme, 0);
            genres.Add(FrmAjoutEleve.GenreFemme, 0);


            List<Adherent> adherents = GestionAdherent.GetAdherent();

            foreach (Adherent adherent in adherents)
            {
                if (adherent.Sexe == 'H') {
                    genres[FrmAjoutEleve.GenreHomme] += 1;
                } 
                else {
                    genres[FrmAjoutEleve.GenreFemme] += 1;
                }
            }

            foreach (KeyValuePair<string, int> genre in genres)
            {
                List<Label> labels = new List<Label>();
                labels.Add(FrmUtilitaire.setLabel(genre.Key));
                labels.Add(FrmUtilitaire.setLabel(genre.Value.ToString()));

                FrmUtilitaire.init().putLabelInPnl(labels, this.findControl(PnlStatistiqueGenre));
            }
        }

        public Control[] findControl(string key, bool boolean = true)
        {
            return this.Controls.Find(key, boolean);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide(); // fermeture du formulaire actuel
            FrmRedirection frmRedirection = new FrmRedirection();
            frmRedirection.Show(); // ouverture du formulaire
        }
    }
}
