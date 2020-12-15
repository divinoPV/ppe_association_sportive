
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutEleve));
            this.pnlAjoutEleve = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbConfirmMdp = new System.Windows.Forms.Label();
            this.txtConfirmMdp = new System.Windows.Forms.TextBox();
            this.comboBoxClasse = new System.Windows.Forms.ComboBox();
            this.lbClasse = new System.Windows.Forms.Label();
            this.lbMdp = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAjoutEleve = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkPrelevement = new System.Windows.Forms.CheckBox();
            this.lbPrelevement = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbTelParent = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelParent = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSexe = new System.Windows.Forms.ComboBox();
            this.lbNaissance = new System.Windows.Forms.Label();
            this.lbSexe = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbAjoutEleve = new System.Windows.Forms.Label();
            this.btnAnnulerAjoutEleve = new System.Windows.Forms.Button();
            this.errorNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTelParent = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMdp = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorConfirmMdp = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlAjoutEleve.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMdp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConfirmMdp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAjoutEleve
            // 
            this.pnlAjoutEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlAjoutEleve.Controls.Add(this.panel1);
            this.pnlAjoutEleve.Controls.Add(this.btnAjoutEleve);
            this.pnlAjoutEleve.Controls.Add(this.panel4);
            this.pnlAjoutEleve.Controls.Add(this.panel3);
            resources.ApplyResources(this.pnlAjoutEleve, "pnlAjoutEleve");
            this.pnlAjoutEleve.Name = "pnlAjoutEleve";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbConfirmMdp);
            this.panel1.Controls.Add(this.txtConfirmMdp);
            this.panel1.Controls.Add(this.comboBoxClasse);
            this.panel1.Controls.Add(this.lbClasse);
            this.panel1.Controls.Add(this.lbMdp);
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Controls.Add(this.txtMdp);
            this.panel1.Controls.Add(this.txtId);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lbConfirmMdp
            // 
            resources.ApplyResources(this.lbConfirmMdp, "lbConfirmMdp");
            this.lbConfirmMdp.Name = "lbConfirmMdp";
            // 
            // txtConfirmMdp
            // 
            resources.ApplyResources(this.txtConfirmMdp, "txtConfirmMdp");
            this.txtConfirmMdp.Name = "txtConfirmMdp";
            this.txtConfirmMdp.UseSystemPasswordChar = true;
            // 
            // comboBoxClasse
            // 
            this.comboBoxClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxClasse, "comboBoxClasse");
            this.comboBoxClasse.Name = "comboBoxClasse";
            // 
            // lbClasse
            // 
            resources.ApplyResources(this.lbClasse, "lbClasse");
            this.lbClasse.Name = "lbClasse";
            // 
            // lbMdp
            // 
            resources.ApplyResources(this.lbMdp, "lbMdp");
            this.lbMdp.Name = "lbMdp";
            // 
            // lbId
            // 
            resources.ApplyResources(this.lbId, "lbId");
            this.lbId.Name = "lbId";
            // 
            // txtMdp
            // 
            resources.ApplyResources(this.txtMdp, "txtMdp");
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.UseSystemPasswordChar = true;
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
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
            this.panel4.Controls.Add(this.checkPrelevement);
            this.panel4.Controls.Add(this.lbPrelevement);
            this.panel4.Controls.Add(this.lbMail);
            this.panel4.Controls.Add(this.lbTelParent);
            this.panel4.Controls.Add(this.lbTel);
            this.panel4.Controls.Add(this.txtMail);
            this.panel4.Controls.Add(this.txtTelParent);
            this.panel4.Controls.Add(this.txtTel);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
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
            this.panel3.Controls.Add(this.dtpNaissance);
            this.panel3.Controls.Add(this.comboBoxSexe);
            this.panel3.Controls.Add(this.lbNaissance);
            this.panel3.Controls.Add(this.lbSexe);
            this.panel3.Controls.Add(this.lbPrenom);
            this.panel3.Controls.Add(this.lbNom);
            this.panel3.Controls.Add(this.txtPrenom);
            this.panel3.Controls.Add(this.txtNom);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // dtpNaissance
            // 
            resources.ApplyResources(this.dtpNaissance, "dtpNaissance");
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Value = new System.DateTime(2020, 12, 13, 0, 0, 0, 0);
            // 
            // comboBoxSexe
            // 
            this.comboBoxSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexe.FormattingEnabled = true;
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
            // errorNom
            // 
            this.errorNom.ContainerControl = this;
            // 
            // errorPrenom
            // 
            this.errorPrenom.ContainerControl = this;
            // 
            // errorTel
            // 
            this.errorTel.ContainerControl = this;
            // 
            // errorTelParent
            // 
            this.errorTelParent.ContainerControl = this;
            // 
            // errorMail
            // 
            this.errorMail.ContainerControl = this;
            // 
            // errorId
            // 
            this.errorId.ContainerControl = this;
            // 
            // errorMdp
            // 
            this.errorMdp.ContainerControl = this;
            // 
            // errorConfirmMdp
            // 
            this.errorConfirmMdp.ContainerControl = this;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMdp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConfirmMdp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAjoutEleve;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbAjoutEleve;
        private System.Windows.Forms.Button btnAnnulerAjoutEleve;
        private System.Windows.Forms.ComboBox comboBoxSexe;
        private System.Windows.Forms.Label lbNaissance;
        private System.Windows.Forms.Label lbSexe;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbNom;
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
        private System.Windows.Forms.Button btnAjoutEleve;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbClasse;
        private System.Windows.Forms.Label lbMdp;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox comboBoxClasse;
        private System.Windows.Forms.Label lbPrelevement;
        private System.Windows.Forms.ErrorProvider errorNom;
        private System.Windows.Forms.ErrorProvider errorPrenom;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.ErrorProvider errorTel;
        private System.Windows.Forms.ErrorProvider errorTelParent;
        private System.Windows.Forms.ErrorProvider errorMail;
        private System.Windows.Forms.ErrorProvider errorId;
        private System.Windows.Forms.ErrorProvider errorMdp;
        private System.Windows.Forms.Label lbConfirmMdp;
        private System.Windows.Forms.TextBox txtConfirmMdp;
        private System.Windows.Forms.ErrorProvider errorConfirmMdp;
    }
}