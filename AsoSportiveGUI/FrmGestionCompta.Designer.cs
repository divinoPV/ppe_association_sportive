
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
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
            this.txtRecherche.KeyDown += new KeyEventHandler(this.txtRecherche_KeyDown);
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
            this.pnlResultat.Size = new System.Drawing.Size(744, 8);
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
            // FrmGestionCompta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}