
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
            this.dgvRecherche = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecherche)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(12, -14);
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
            this.lbGestionComptabilite.Location = new System.Drawing.Point(260, 9);
            this.lbGestionComptabilite.Name = "lbGestionComptabilite";
            this.lbGestionComptabilite.Size = new System.Drawing.Size(280, 31);
            this.lbGestionComptabilite.TabIndex = 11;
            this.lbGestionComptabilite.Text = "Gestion comptabilité";
            this.lbGestionComptabilite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(560, 54);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(228, 20);
            this.txtRecherche.TabIndex = 12;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // lbRecherche
            // 
            this.lbRecherche.AutoSize = true;
            this.lbRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRecherche.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbRecherche.Location = new System.Drawing.Point(385, 54);
            this.lbRecherche.Name = "lbRecherche";
            this.lbRecherche.Size = new System.Drawing.Size(163, 20);
            this.lbRecherche.TabIndex = 13;
            this.lbRecherche.Text = "Rechercher un élève :";
            // 
            // dgvRecherche
            // 
            this.dgvRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecherche.Location = new System.Drawing.Point(73, 109);
            this.dgvRecherche.Name = "dgvRecherche";
            this.dgvRecherche.Size = new System.Drawing.Size(645, 150);
            this.dgvRecherche.TabIndex = 14;
            // 
            // FrmGestionCompta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRecherche);
            this.Controls.Add(this.lbRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lbGestionComptabilite);
            this.Controls.Add(this.pbxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionCompta";
            this.Text = "FrmGestionCompta";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecherche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lbGestionComptabilite;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lbRecherche;
        private System.Windows.Forms.DataGridView dgvRecherche;
    }
}