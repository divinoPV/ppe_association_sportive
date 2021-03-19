
namespace AsoSportiveGUI
{
    partial class FrmModifBudget
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModifBudget = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpBudget = new System.Windows.Forms.NumericUpDown();
            this.lbBudgetMontant = new System.Windows.Forms.Label();
            this.lblBudgetNom = new System.Windows.Forms.Label();
            this.txtBudgetNom = new System.Windows.Forms.TextBox();
            this.lbBudgetTitre = new System.Windows.Forms.Label();
            this.errorBudgetNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBudgetMontant = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAnnulerModifBudget = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBudgetNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBudgetMontant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btnModifBudget);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(38, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 324);
            this.panel1.TabIndex = 0;
            // 
            // btnModifBudget
            // 
            this.btnModifBudget.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModifBudget.FlatAppearance.BorderSize = 0;
            this.btnModifBudget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnModifBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifBudget.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifBudget.Location = new System.Drawing.Point(350, 261);
            this.btnModifBudget.Name = "btnModifBudget";
            this.btnModifBudget.Size = new System.Drawing.Size(106, 30);
            this.btnModifBudget.TabIndex = 1;
            this.btnModifBudget.Text = "Ajouter";
            this.btnModifBudget.UseVisualStyleBackColor = false;
            this.btnModifBudget.Click += new System.EventHandler(this.btnModifBudget_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.numericUpBudget);
            this.panel2.Controls.Add(this.lbBudgetMontant);
            this.panel2.Controls.Add(this.lblBudgetNom);
            this.panel2.Controls.Add(this.txtBudgetNom);
            this.panel2.Location = new System.Drawing.Point(33, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 207);
            this.panel2.TabIndex = 0;
            // 
            // numericUpBudget
            // 
            this.numericUpBudget.DecimalPlaces = 2;
            this.numericUpBudget.Location = new System.Drawing.Point(163, 117);
            this.numericUpBudget.Maximum = new decimal(new int[] {
                    2147483647,
                    0,
                    0,
                    0
                }
            );
            this.numericUpBudget.Name = "numericUpBudget";
            this.numericUpBudget.Size = new System.Drawing.Size(199, 20);
            this.numericUpBudget.TabIndex = 4;
            // 
            // lbBudgetMontant
            // 
            this.lbBudgetMontant.AutoSize = true;
            this.lbBudgetMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBudgetMontant.Location = new System.Drawing.Point(22, 114);
            this.lbBudgetMontant.Name = "lbBudgetMontant";
            this.lbBudgetMontant.Size = new System.Drawing.Size(107, 20);
            this.lbBudgetMontant.TabIndex = 3;
            this.lbBudgetMontant.Text = "Montant initial";
            // 
            // lblBudgetNom
            // 
            this.lblBudgetNom.AutoSize = true;
            this.lblBudgetNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetNom.Location = new System.Drawing.Point(22, 58);
            this.lblBudgetNom.Name = "lblBudgetNom";
            this.lblBudgetNom.Size = new System.Drawing.Size(118, 20);
            this.lblBudgetNom.TabIndex = 2;
            this.lblBudgetNom.Text = "Nom du budget";
            // 
            // txtBudgetNom
            // 
            this.txtBudgetNom.Location = new System.Drawing.Point(163, 58);
            this.txtBudgetNom.Name = "txtBudgetNom";
            this.txtBudgetNom.Size = new System.Drawing.Size(199, 20);
            this.txtBudgetNom.TabIndex = 0;
            // 
            // lbBudgetTitre
            // 
            this.lbBudgetTitre.AutoSize = true;
            this.lbBudgetTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBudgetTitre.Location = new System.Drawing.Point(78, 18);
            this.lbBudgetTitre.Name = "lbBudgetTitre";
            this.lbBudgetTitre.Size = new System.Drawing.Size(277, 31);
            this.lbBudgetTitre.TabIndex = 4;
            this.lbBudgetTitre.Text = "Modifier d\'un budget";
            // 
            // errorBudgetNom
            // 
            this.errorBudgetNom.ContainerControl = this;
            // 
            // errorBudgetMontant
            // 
            this.errorBudgetMontant.ContainerControl = this;
            // 
            // btnAnnulerModifBudget
            // 
            this.btnAnnulerModifBudget.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAnnulerModifBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnulerModifBudget.FlatAppearance.BorderSize = 0;
            this.btnAnnulerModifBudget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnnulerModifBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerModifBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnnulerModifBudget.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnulerModifBudget.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAnnulerModifBudget.Location = new System.Drawing.Point(420, 18);
            this.btnAnnulerModifBudget.Name = "btnAnnulerModifBudget";
            this.btnAnnulerModifBudget.Size = new System.Drawing.Size(99, 31);
            this.btnAnnulerModifBudget.TabIndex = 12;
            this.btnAnnulerModifBudget.Text = "Annuler";
            this.btnAnnulerModifBudget.UseVisualStyleBackColor = false;
            this.btnAnnulerModifBudget.Click += new System.EventHandler(this.btnAnnulerModifBudget_Click);
            // 
            // FrmModifBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(571, 463);
            this.Controls.Add(this.btnAnnulerModifBudget);
            this.Controls.Add(this.lbBudgetTitre);
            this.Controls.Add(this.panel1);
            this.Name = "FrmModifBudget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModifBudget";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBudgetNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBudgetMontant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBudgetNom;
        private System.Windows.Forms.Button btnModifBudget;
        private System.Windows.Forms.Label lbBudgetMontant;
        private System.Windows.Forms.Label lblBudgetNom;
        private System.Windows.Forms.Label lbBudgetTitre;
        private System.Windows.Forms.ErrorProvider errorBudgetNom;
        private System.Windows.Forms.ErrorProvider errorBudgetMontant;
        private System.Windows.Forms.NumericUpDown numericUpBudget;
        private System.Windows.Forms.Button btnAnnulerModifBudget;
    }
}