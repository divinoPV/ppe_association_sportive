namespace AsoSportiveGUI
{
    partial class FrmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblCo = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblForget = new System.Windows.Forms.Label();
            this.ckbRemember = new System.Windows.Forms.CheckBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(16, 96);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(80, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Identifiant";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(16, 128);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(354, 24);
            this.txtId.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(16, 216);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(354, 24);
            this.txtPass.TabIndex = 2;
            // 
            // lblCo
            // 
            this.lblCo.AutoSize = true;
            this.lblCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCo.Location = new System.Drawing.Point(120, 32);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(143, 31);
            this.lblCo.TabIndex = 3;
            this.lblCo.Text = "Connexion";
            this.lblCo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(16, 352);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(352, 32);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Envoyer";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblForget
            // 
            this.lblForget.AutoSize = true;
            this.lblForget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForget.Location = new System.Drawing.Point(208, 280);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(164, 20);
            this.lblForget.TabIndex = 5;
            this.lblForget.Text = "Mot de passe oublié ?";
            this.lblForget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbRemember
            // 
            this.ckbRemember.AutoSize = true;
            this.ckbRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRemember.Location = new System.Drawing.Point(16, 280);
            this.ckbRemember.Name = "ckbRemember";
            this.ckbRemember.Size = new System.Drawing.Size(162, 24);
            this.ckbRemember.TabIndex = 6;
            this.ckbRemember.Text = "Se souvenir de moi";
            this.ckbRemember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbRemember.UseVisualStyleBackColor = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(16, 184);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(105, 20);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Mot de passe";
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(389, 422);
            this.Controls.Add(this.lblCo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.ckbRemember);
            this.Controls.Add(this.lblForget);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblCo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblForget;
        private System.Windows.Forms.CheckBox ckbRemember;
        private System.Windows.Forms.Label lblPass;
    }
}

