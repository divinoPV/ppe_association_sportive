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
            this.idLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(51, 60);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(87, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Connexion réussi";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(51, 96);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(87, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Connexion réussi";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(51, 132);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(87, 13);
            this.roleLabel.TabIndex = 2;
            this.roleLabel.Text = "Connexion réussi";
            // 
            // FrmRedirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 187);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "FrmRedirection";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label roleLabel;
    }
}