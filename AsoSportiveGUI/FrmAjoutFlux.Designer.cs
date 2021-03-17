
namespace AsoSportiveGUI
{
    partial class FrmAjoutFlux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutFlux));
            this.pnlAjoutFlux = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxBudget = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeTransac = new System.Windows.Forms.ComboBox();
            this.btnAjoutFlux = new System.Windows.Forms.Button();
            this.checkPrelevement = new System.Windows.Forms.CheckBox();
            this.lbPrelevement = new System.Windows.Forms.Label();
            this.lbBudget = new System.Windows.Forms.Label();
            this.lbTypeTransac = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numUpMontant = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEleve = new System.Windows.Forms.ComboBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbEleve = new System.Windows.Forms.Label();
            this.lbMontant = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lbAjoutFlux = new System.Windows.Forms.Label();
            this.errorNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMontant = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAnnulerAjoutFlux = new System.Windows.Forms.Button();
            this.pnlAjoutFlux.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMontant)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAjoutFlux
            // 
            this.pnlAjoutFlux.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlAjoutFlux.Controls.Add(this.panel4);
            this.pnlAjoutFlux.Controls.Add(this.panel3);
            this.pnlAjoutFlux.Location = new System.Drawing.Point(18, 55);
            this.pnlAjoutFlux.Name = "pnlAjoutFlux";
            this.pnlAjoutFlux.Size = new System.Drawing.Size(513, 487);
            this.pnlAjoutFlux.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.comboBoxBudget);
            this.panel4.Controls.Add(this.comboBoxTypeTransac);
            this.panel4.Controls.Add(this.btnAjoutFlux);
            this.panel4.Controls.Add(this.checkPrelevement);
            this.panel4.Controls.Add(this.lbPrelevement);
            this.panel4.Controls.Add(this.lbBudget);
            this.panel4.Controls.Add(this.lbTypeTransac);
            this.panel4.Location = new System.Drawing.Point(37, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(442, 212);
            this.panel4.TabIndex = 8;
            // 
            // comboBoxBudget
            // 
            this.comboBoxBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBudget.FormattingEnabled = true;
            this.comboBoxBudget.Location = new System.Drawing.Point(134, 66);
            this.comboBoxBudget.Name = "comboBoxBudget";
            this.comboBoxBudget.Size = new System.Drawing.Size(235, 21);
            this.comboBoxBudget.TabIndex = 14;
            // 
            // comboBoxTypeTransac
            // 
            this.comboBoxTypeTransac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeTransac.FormattingEnabled = true;
            this.comboBoxTypeTransac.Location = new System.Drawing.Point(134, 23);
            this.comboBoxTypeTransac.Name = "comboBoxTypeTransac";
            this.comboBoxTypeTransac.Size = new System.Drawing.Size(235, 21);
            this.comboBoxTypeTransac.TabIndex = 12;
            // 
            // btnAjoutFlux
            // 
            this.btnAjoutFlux.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjoutFlux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjoutFlux.FlatAppearance.BorderSize = 0;
            this.btnAjoutFlux.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAjoutFlux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutFlux.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjoutFlux.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjoutFlux.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAjoutFlux.Location = new System.Drawing.Point(303, 145);
            this.btnAjoutFlux.Name = "btnAjoutFlux";
            this.btnAjoutFlux.Size = new System.Drawing.Size(127, 48);
            this.btnAjoutFlux.TabIndex = 4;
            this.btnAjoutFlux.Text = "Ajouter\r\n";
            this.btnAjoutFlux.UseVisualStyleBackColor = false;
            this.btnAjoutFlux.Click += new System.EventHandler(this.btnAjoutFlux_Click);
            // 
            // checkPrelevement
            // 
            this.checkPrelevement.AutoSize = true;
            this.checkPrelevement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkPrelevement.Location = new System.Drawing.Point(150, 119);
            this.checkPrelevement.Name = "checkPrelevement";
            this.checkPrelevement.Size = new System.Drawing.Size(15, 14);
            this.checkPrelevement.TabIndex = 10;
            this.checkPrelevement.UseVisualStyleBackColor = true;
            // 
            // lbPrelevement
            // 
            this.lbPrelevement.AutoSize = true;
            this.lbPrelevement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbPrelevement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPrelevement.Location = new System.Drawing.Point(34, 114);
            this.lbPrelevement.Name = "lbPrelevement";
            this.lbPrelevement.Size = new System.Drawing.Size(97, 20);
            this.lbPrelevement.TabIndex = 11;
            this.lbPrelevement.Text = "Prélèvement";
            // 
            // lbBudget
            // 
            this.lbBudget.AutoSize = true;
            this.lbBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbBudget.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBudget.Location = new System.Drawing.Point(34, 67);
            this.lbBudget.Name = "lbBudget";
            this.lbBudget.Size = new System.Drawing.Size(61, 20);
            this.lbBudget.TabIndex = 6;
            this.lbBudget.Text = "Budget";
            // 
            // lbTypeTransac
            // 
            this.lbTypeTransac.AutoSize = true;
            this.lbTypeTransac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTypeTransac.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTypeTransac.Location = new System.Drawing.Point(5, 24);
            this.lbTypeTransac.Name = "lbTypeTransac";
            this.lbTypeTransac.Size = new System.Drawing.Size(126, 20);
            this.lbTypeTransac.TabIndex = 0;
            this.lbTypeTransac.Text = "Type transaction";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.numUpMontant);
            this.panel3.Controls.Add(this.dtpDate);
            this.panel3.Controls.Add(this.comboBoxEleve);
            this.panel3.Controls.Add(this.lbDate);
            this.panel3.Controls.Add(this.lbEleve);
            this.panel3.Controls.Add(this.lbMontant);
            this.panel3.Controls.Add(this.lbNom);
            this.panel3.Controls.Add(this.txtNom);
            this.panel3.Location = new System.Drawing.Point(37, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 189);
            this.panel3.TabIndex = 1;
            // 
            // numUpMontant
            // 
            this.numUpMontant.DecimalPlaces = 2;
            this.numUpMontant.Location = new System.Drawing.Point(134, 67);
            this.numUpMontant.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpMontant.Name = "numUpMontant";
            this.numUpMontant.Size = new System.Drawing.Size(235, 20);
            this.numUpMontant.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(134, 146);
            this.dtpDate.MinDate = new System.DateTime(2021, 2, 27, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(235, 20);
            this.dtpDate.TabIndex = 8;
            this.dtpDate.Value = new System.DateTime(2021, 2, 27, 0, 0, 0, 0);
            // 
            // comboBoxEleve
            // 
            this.comboBoxEleve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEleve.FormattingEnabled = true;
            this.comboBoxEleve.Location = new System.Drawing.Point(134, 106);
            this.comboBoxEleve.Name = "comboBoxEleve";
            this.comboBoxEleve.Size = new System.Drawing.Size(235, 21);
            this.comboBoxEleve.TabIndex = 7;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDate.Location = new System.Drawing.Point(34, 146);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(44, 20);
            this.lbDate.TabIndex = 6;
            this.lbDate.Text = "Date";
            // 
            // lbEleve
            // 
            this.lbEleve.AutoSize = true;
            this.lbEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbEleve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbEleve.Location = new System.Drawing.Point(35, 107);
            this.lbEleve.Name = "lbEleve";
            this.lbEleve.Size = new System.Drawing.Size(48, 20);
            this.lbEleve.TabIndex = 5;
            this.lbEleve.Text = "Elève";
            // 
            // lbMontant
            // 
            this.lbMontant.AutoSize = true;
            this.lbMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMontant.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMontant.Location = new System.Drawing.Point(34, 64);
            this.lbMontant.Name = "lbMontant";
            this.lbMontant.Size = new System.Drawing.Size(68, 20);
            this.lbMontant.TabIndex = 4;
            this.lbMontant.Text = "Montant";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNom.Location = new System.Drawing.Point(4, 22);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(124, 20);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom débit/crédit";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(134, 24);
            this.txtNom.MaxLength = 50;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(235, 20);
            this.txtNom.TabIndex = 0;
            // 
            // lbAjoutFlux
            // 
            this.lbAjoutFlux.AutoSize = true;
            this.lbAjoutFlux.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbAjoutFlux.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbAjoutFlux.Location = new System.Drawing.Point(12, 9);
            this.lbAjoutFlux.Name = "lbAjoutFlux";
            this.lbAjoutFlux.Size = new System.Drawing.Size(301, 31);
            this.lbAjoutFlux.TabIndex = 10;
            this.lbAjoutFlux.Text = "Ajouter un débit/crédit";
            this.lbAjoutFlux.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorNom
            // 
            this.errorNom.ContainerControl = this;
            // 
            // errorMontant
            // 
            this.errorMontant.ContainerControl = this;
            // 
            // btnAnnulerAjoutFlux
            // 
            this.btnAnnulerAjoutFlux.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAnnulerAjoutFlux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnulerAjoutFlux.FlatAppearance.BorderSize = 0;
            this.btnAnnulerAjoutFlux.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnnulerAjoutFlux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerAjoutFlux.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnnulerAjoutFlux.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnulerAjoutFlux.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAnnulerAjoutFlux.Location = new System.Drawing.Point(432, 9);
            this.btnAnnulerAjoutFlux.Name = "btnAnnulerAjoutFlux";
            this.btnAnnulerAjoutFlux.Size = new System.Drawing.Size(99, 31);
            this.btnAnnulerAjoutFlux.TabIndex = 11;
            this.btnAnnulerAjoutFlux.Text = "Annuler";
            this.btnAnnulerAjoutFlux.UseVisualStyleBackColor = false;
            this.btnAnnulerAjoutFlux.Click += new System.EventHandler(this.btnAnnulerAjoutFlux_Click);
            // 
            // FrmAjoutFlux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(564, 562);
            this.Controls.Add(this.btnAnnulerAjoutFlux);
            this.Controls.Add(this.lbAjoutFlux);
            this.Controls.Add(this.pnlAjoutFlux);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAjoutFlux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAjoutFlux";
            this.pnlAjoutFlux.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMontant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAjoutFlux;
        private System.Windows.Forms.Button btnAjoutFlux;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkPrelevement;
        private System.Windows.Forms.Label lbPrelevement;
        private System.Windows.Forms.Label lbBudget;
        private System.Windows.Forms.Label lbTypeTransac;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox comboBoxEleve;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbEleve;
        private System.Windows.Forms.Label lbMontant;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lbAjoutFlux;
        private System.Windows.Forms.ComboBox comboBoxBudget;
        private System.Windows.Forms.ComboBox comboBoxTypeTransac;
        private System.Windows.Forms.ErrorProvider errorNom;
        private System.Windows.Forms.ErrorProvider errorMontant;
        private System.Windows.Forms.NumericUpDown numUpMontant;
        private System.Windows.Forms.Button btnAnnulerAjoutFlux;
    }
}