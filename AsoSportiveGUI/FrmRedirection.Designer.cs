namespace AsoSportiveGUI
{
    partial class FrmRedirection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRedirection));
            this.btnFrmDetailsEleve = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnGestionCompta = new System.Windows.Forms.Button();
            this.btnFrmDetailsBudget = new System.Windows.Forms.Button();
            this.btnStatistique = new System.Windows.Forms.Button();
            this.lblRedirection = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFrmDetailsEleve
            // 
            this.btnFrmDetailsEleve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFrmDetailsEleve.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFrmDetailsEleve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrmDetailsEleve.FlatAppearance.BorderSize = 0;
            this.btnFrmDetailsEleve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnFrmDetailsEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmDetailsEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmDetailsEleve.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFrmDetailsEleve.Location = new System.Drawing.Point(96, 61);
            this.btnFrmDetailsEleve.Name = "btnFrmDetailsEleve";
            this.btnFrmDetailsEleve.Size = new System.Drawing.Size(108, 23);
            this.btnFrmDetailsEleve.TabIndex = 3;
            this.btnFrmDetailsEleve.Text = "Détails éléves";
            this.btnFrmDetailsEleve.UseVisualStyleBackColor = false;
            this.btnFrmDetailsEleve.Click += new System.EventHandler(this.btnFrmDetailsEleve_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlMenu.Controls.Add(this.lblRedirection);
            this.pnlMenu.Controls.Add(this.btnStatistique);
            this.pnlMenu.Controls.Add(this.btnGestionCompta);
            this.pnlMenu.Controls.Add(this.btnFrmDetailsBudget);
            this.pnlMenu.Controls.Add(this.btnFrmDetailsEleve);
            this.pnlMenu.Location = new System.Drawing.Point(34, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(294, 368);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnGestionCompta
            // 
            this.btnGestionCompta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestionCompta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGestionCompta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionCompta.FlatAppearance.BorderSize = 0;
            this.btnGestionCompta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGestionCompta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionCompta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionCompta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGestionCompta.Location = new System.Drawing.Point(96, 167);
            this.btnGestionCompta.Name = "btnGestionCompta";
            this.btnGestionCompta.Size = new System.Drawing.Size(108, 43);
            this.btnGestionCompta.TabIndex = 6;
            this.btnGestionCompta.Text = "Gestion comptabilité";
            this.btnGestionCompta.UseVisualStyleBackColor = false;
            this.btnGestionCompta.Click += new System.EventHandler(this.btnGestionCompta_Click);
            // 
            // btnFrmDetailsBudget
            // 
            this.btnFrmDetailsBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFrmDetailsBudget.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFrmDetailsBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrmDetailsBudget.FlatAppearance.BorderSize = 0;
            this.btnFrmDetailsBudget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnFrmDetailsBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmDetailsBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmDetailsBudget.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFrmDetailsBudget.Location = new System.Drawing.Point(96, 101);
            this.btnFrmDetailsBudget.Name = "btnFrmDetailsBudget";
            this.btnFrmDetailsBudget.Size = new System.Drawing.Size(108, 23);
            this.btnFrmDetailsBudget.TabIndex = 5;
            this.btnFrmDetailsBudget.Text = "Détails budget";
            this.btnFrmDetailsBudget.UseVisualStyleBackColor = false;
            this.btnFrmDetailsBudget.Click += new System.EventHandler(this.btnFrmDetailsBudget_Click);
            // 
            // btnStatistique
            // 
            this.btnStatistique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistique.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStatistique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistique.FlatAppearance.BorderSize = 0;
            this.btnStatistique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnStatistique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistique.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnStatistique.Location = new System.Drawing.Point(96, 243);
            this.btnStatistique.Name = "btnStatistique";
            this.btnStatistique.Size = new System.Drawing.Size(108, 43);
            this.btnStatistique.TabIndex = 8;
            this.btnStatistique.Text = "Statistique";
            this.btnStatistique.UseVisualStyleBackColor = false;
            // 
            // lblRedirection
            // 
            this.lblRedirection.AutoSize = true;
            this.lblRedirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedirection.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRedirection.Location = new System.Drawing.Point(104, 22);
            this.lblRedirection.Name = "lblRedirection";
            this.lblRedirection.Size = new System.Drawing.Size(90, 20);
            this.lblRedirection.TabIndex = 9;
            this.lblRedirection.Text = "Redirection";
            // 
            // FrmRedirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(368, 393);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRedirection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFrmDetailsEleve;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnFrmDetailsBudget;
        private System.Windows.Forms.Button btnGestionCompta;
        private System.Windows.Forms.Button btnStatistique;
        private System.Windows.Forms.Label lblRedirection;
    }
}