
namespace AsoSportiveGUI
{
    partial class FrmAjoutEleve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutEleve));
            this.pnlAjoutEleve = new System.Windows.Forms.Panel();
            this.btnAjoutEleve = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbTelParent = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelParent = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxSexe = new System.Windows.Forms.ComboBox();
            this.lbNaissance = new System.Windows.Forms.Label();
            this.lbSexe = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.txtNaissance = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkPrelevement = new System.Windows.Forms.CheckBox();
            this.lbPrelevement = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbAjoutEleve = new System.Windows.Forms.Label();
            this.btnAnnulerAjoutEleve = new System.Windows.Forms.Button();
            this.pnlAjoutEleve.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAjoutEleve
            // 
            this.pnlAjoutEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlAjoutEleve.Controls.Add(this.btnAjoutEleve);
            this.pnlAjoutEleve.Controls.Add(this.panel4);
            this.pnlAjoutEleve.Controls.Add(this.panel3);
            this.pnlAjoutEleve.Controls.Add(this.panel2);
            resources.ApplyResources(this.pnlAjoutEleve, "pnlAjoutEleve");
            this.pnlAjoutEleve.Name = "pnlAjoutEleve";
            // 
            // btnAjoutEleve
            // 
            this.btnAjoutEleve.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjoutEleve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjoutEleve.FlatAppearance.BorderSize = 0;
            this.btnAjoutEleve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btnAjoutEleve, "btnAjoutEleve");
            this.btnAjoutEleve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjoutEleve.Name = "btnAjoutEleve";
            this.btnAjoutEleve.UseVisualStyleBackColor = false;
            this.btnAjoutEleve.Click += new System.EventHandler(this.btnAjoutEleve_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.lbMail);
            this.panel4.Controls.Add(this.lbTelParent);
            this.panel4.Controls.Add(this.lbTel);
            this.panel4.Controls.Add(this.txtMail);
            this.panel4.Controls.Add(this.txtTelParent);
            this.panel4.Controls.Add(this.txtTel);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // lbMail
            // 
            resources.ApplyResources(this.lbMail, "lbMail");
            this.lbMail.Name = "lbMail";
            // 
            // lbTelParent
            // 
            resources.ApplyResources(this.lbTelParent, "lbTelParent");
            this.lbTelParent.Name = "lbTelParent";
            // 
            // lbTel
            // 
            resources.ApplyResources(this.lbTel, "lbTel");
            this.lbTel.Name = "lbTel";
            // 
            // txtMail
            // 
            resources.ApplyResources(this.txtMail, "txtMail");
            this.txtMail.Name = "txtMail";
            // 
            // txtTelParent
            // 
            resources.ApplyResources(this.txtTelParent, "txtTelParent");
            this.txtTelParent.Name = "txtTelParent";
            // 
            // txtTel
            // 
            resources.ApplyResources(this.txtTel, "txtTel");
            this.txtTel.Name = "txtTel";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.comboBoxSexe);
            this.panel3.Controls.Add(this.lbNaissance);
            this.panel3.Controls.Add(this.lbSexe);
            this.panel3.Controls.Add(this.lbPrenom);
            this.panel3.Controls.Add(this.lbNom);
            this.panel3.Controls.Add(this.txtNaissance);
            this.panel3.Controls.Add(this.txtPrenom);
            this.panel3.Controls.Add(this.txtNom);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // comboBoxSexe
            // 
            this.comboBoxSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexe.FormattingEnabled = true;
            this.comboBoxSexe.Items.AddRange(new object[] {
            resources.GetString("comboBoxSexe.Items"),
            resources.GetString("comboBoxSexe.Items1")});
            resources.ApplyResources(this.comboBoxSexe, "comboBoxSexe");
            this.comboBoxSexe.Name = "comboBoxSexe";
            // 
            // lbNaissance
            // 
            resources.ApplyResources(this.lbNaissance, "lbNaissance");
            this.lbNaissance.Name = "lbNaissance";
            // 
            // lbSexe
            // 
            resources.ApplyResources(this.lbSexe, "lbSexe");
            this.lbSexe.Name = "lbSexe";
            // 
            // lbPrenom
            // 
            resources.ApplyResources(this.lbPrenom, "lbPrenom");
            this.lbPrenom.Name = "lbPrenom";
            // 
            // lbNom
            // 
            resources.ApplyResources(this.lbNom, "lbNom");
            this.lbNom.Name = "lbNom";
            // 
            // txtNaissance
            // 
            resources.ApplyResources(this.txtNaissance, "txtNaissance");
            this.txtNaissance.Name = "txtNaissance";
            // 
            // txtPrenom
            // 
            resources.ApplyResources(this.txtPrenom, "txtPrenom");
            this.txtPrenom.Name = "txtPrenom";
            // 
            // txtNom
            // 
            resources.ApplyResources(this.txtNom, "txtNom");
            this.txtNom.Name = "txtNom";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.checkPrelevement);
            this.panel2.Controls.Add(this.lbPrelevement);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // checkPrelevement
            // 
            resources.ApplyResources(this.checkPrelevement, "checkPrelevement");
            this.checkPrelevement.Name = "checkPrelevement";
            this.checkPrelevement.UseVisualStyleBackColor = true;
            // 
            // lbPrelevement
            // 
            resources.ApplyResources(this.lbPrelevement, "lbPrelevement");
            this.lbPrelevement.Name = "lbPrelevement";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lbAjoutEleve
            // 
            resources.ApplyResources(this.lbAjoutEleve, "lbAjoutEleve");
            this.lbAjoutEleve.Name = "lbAjoutEleve";
            // 
            // btnAnnulerAjoutEleve
            // 
            this.btnAnnulerAjoutEleve.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAnnulerAjoutEleve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnulerAjoutEleve.FlatAppearance.BorderSize = 0;
            this.btnAnnulerAjoutEleve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btnAnnulerAjoutEleve, "btnAnnulerAjoutEleve");
            this.btnAnnulerAjoutEleve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnulerAjoutEleve.Name = "btnAnnulerAjoutEleve";
            this.btnAnnulerAjoutEleve.UseVisualStyleBackColor = false;
            this.btnAnnulerAjoutEleve.Click += new System.EventHandler(this.btnAnnulerAjoutEleve_Click);
            // 
            // FrmAjoutEleve
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnAnnulerAjoutEleve);
            this.Controls.Add(this.lbAjoutEleve);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlAjoutEleve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmAjoutEleve";
            this.pnlAjoutEleve.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAjoutEleve;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbAjoutEleve;
        private System.Windows.Forms.Button btnAnnulerAjoutEleve;
        private System.Windows.Forms.ComboBox comboBoxSexe;
        private System.Windows.Forms.Label lbNaissance;
        private System.Windows.Forms.Label lbSexe;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox txtNaissance;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbTelParent;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelParent;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.CheckBox checkPrelevement;
        private System.Windows.Forms.Label lbPrelevement;
        private System.Windows.Forms.Button btnAjoutEleve;
    }
}