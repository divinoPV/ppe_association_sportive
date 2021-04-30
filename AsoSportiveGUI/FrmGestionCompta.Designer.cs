
using System.Windows.Forms;

namespace AsoSportiveGUI
{
    partial class FrmGestionCompta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionCompta));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lbGestionComptabilite = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lbRecherche = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.pnlResultat = new System.Windows.Forms.TableLayoutPanel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dgvFlux = new System.Windows.Forms.DataGridView();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prelevement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_flux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlux)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(24, -16);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(104, 88);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 4;
            this.pbxLogo.TabStop = false;
            // 
            // lbGestionComptabilite
            // 
            this.lbGestionComptabilite.AutoSize = true;
            this.lbGestionComptabilite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbGestionComptabilite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbGestionComptabilite.Location = new System.Drawing.Point(256, 16);
            this.lbGestionComptabilite.Name = "lbGestionComptabilite";
            this.lbGestionComptabilite.Size = new System.Drawing.Size(280, 31);
            this.lbGestionComptabilite.TabIndex = 11;
            this.lbGestionComptabilite.Text = "Gestion comptabilité";
            this.lbGestionComptabilite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(544, 64);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(228, 20);
            this.txtRecherche.TabIndex = 12;
            this.txtRecherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRecherche_KeyDown);
            // 
            // lbRecherche
            // 
            this.lbRecherche.AutoSize = true;
            this.lbRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRecherche.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbRecherche.Location = new System.Drawing.Point(368, 64);
            this.lbRecherche.Name = "lbRecherche";
            this.lbRecherche.Size = new System.Drawing.Size(163, 20);
            this.lbRecherche.TabIndex = 13;
            this.lbRecherche.Text = "Rechercher un élève :";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(24, 104);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(152, 18);
            this.lblResultat.TabIndex = 0;
            this.lblResultat.Text = "Résultat de recherche";
            // 
            // pnlResultat
            // 
            this.pnlResultat.AutoScroll = true;
            this.pnlResultat.AutoSize = true;
            this.pnlResultat.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.pnlResultat.ColumnCount = 13;
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlResultat.Location = new System.Drawing.Point(24, 128);
            this.pnlResultat.Name = "pnlResultat";
            this.pnlResultat.RowCount = 1;
            this.pnlResultat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlResultat.Size = new System.Drawing.Size(744, 10);
            this.pnlResultat.TabIndex = 15;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(696, 16);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dgvFlux
            // 
            this.dgvFlux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlux.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libelle,
            this.date,
            this.montant,
            this.prelevement,
            this.budget,
            this.type_flux});
            this.dgvFlux.Location = new System.Drawing.Point(71, 230);
            this.dgvFlux.Name = "dgvFlux";
            this.dgvFlux.Size = new System.Drawing.Size(643, 150);
            this.dgvFlux.TabIndex = 16;
            // 
            // libelle
            // 
            this.libelle.DataPropertyName = "libelle";
            this.libelle.HeaderText = "Nom";
            this.libelle.Name = "libelle";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // montant
            // 
            this.montant.DataPropertyName = "montant";
            this.montant.HeaderText = "Montant";
            this.montant.Name = "montant";
            // 
            // prelevement
            // 
            this.prelevement.DataPropertyName = "prelevement";
            this.prelevement.HeaderText = "Prélèvement";
            this.prelevement.Name = "prelevement";
            // 
            // budget
            // 
            this.budget.DataPropertyName = "budget";
            this.budget.HeaderText = "Budget";
            this.budget.Name = "budget";
            // 
            // type_flux
            // 
            this.type_flux.DataPropertyName = "typeFlux";
            this.type_flux.HeaderText = "Type de flux";
            this.type_flux.Name = "type_flux";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Liste des flux";
            // 
            // FrmGestionCompta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFlux);
            this.Controls.Add(this.pnlResultat);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lbRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lbGestionComptabilite);
            this.Controls.Add(this.pbxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionCompta";
            this.Text = "Gestion comptabilité";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lbGestionComptabilite;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lbRecherche;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.TableLayoutPanel pnlResultat;
        private DataGridView dgvFlux;
        private DataGridViewTextBoxColumn libelle;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn montant;
        private DataGridViewTextBoxColumn prelevement;
        private DataGridViewTextBoxColumn budget;
        private DataGridViewTextBoxColumn type_flux;
        private Label label1;
    }
}