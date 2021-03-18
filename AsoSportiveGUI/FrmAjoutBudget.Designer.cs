
namespace AsoSportiveGUI
{
    partial class FrmAjoutBudget
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
            this.btnAjoutBudget = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbBudgetMontant = new System.Windows.Forms.Label();
            this.lblBudgetNom = new System.Windows.Forms.Label();
            this.txtBudgetMontant = new System.Windows.Forms.TextBox();
            this.txtBudgetNom = new System.Windows.Forms.TextBox();
            this.lbBudgetTitre = new System.Windows.Forms.Label();
            this.errorBudgetNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBudgetMontant = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorBudgetNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBudgetMontant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btnAjoutBudget);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(38, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 324);
            this.panel1.TabIndex = 0;
            // 
            // btnAjoutBudget
            // 
            this.btnAjoutBudget.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjoutBudget.FlatAppearance.BorderSize = 0;
            this.btnAjoutBudget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAjoutBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutBudget.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjoutBudget.Location = new System.Drawing.Point(350, 261);
            this.btnAjoutBudget.Name = "btnAjoutBudget";
            this.btnAjoutBudget.Size = new System.Drawing.Size(106, 30);
            this.btnAjoutBudget.TabIndex = 1;
            this.btnAjoutBudget.Text = "Ajouter";
            this.btnAjoutBudget.UseVisualStyleBackColor = false;
            this.btnAjoutBudget.Click += new System.EventHandler(this.btnAjoutBudget_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lbBudgetMontant);
            this.panel2.Controls.Add(this.lblBudgetNom);
            this.panel2.Controls.Add(this.txtBudgetMontant);
            this.panel2.Controls.Add(this.txtBudgetNom);
            this.panel2.Location = new System.Drawing.Point(33, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 207);
            this.panel2.TabIndex = 0;
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
            // txtBudgetMontant
            // 
            this.txtBudgetMontant.Location = new System.Drawing.Point(163, 116);
            this.txtBudgetMontant.Name = "txtBudgetMontant";
            this.txtBudgetMontant.Size = new System.Drawing.Size(199, 20);
            this.txtBudgetMontant.TabIndex = 1;
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
            this.lbBudgetTitre.Location = new System.Drawing.Point(151, 18);
            this.lbBudgetTitre.Name = "lbBudgetTitre";
            this.lbBudgetTitre.Size = new System.Drawing.Size(240, 31);
            this.lbBudgetTitre.TabIndex = 4;
            this.lbBudgetTitre.Text = "Ajout d\'un budget";
            // 
            // errorBudgetNom
            // 
            this.errorBudgetNom.ContainerControl = this;
            // 
            // errorBudgetMontant
            // 
            this.errorBudgetMontant.ContainerControl = this;
            // 
            // FrmAjoutBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(571, 463);
            this.Controls.Add(this.lbBudgetTitre);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAjoutBudget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAjoutBudget";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorBudgetNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBudgetMontant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBudgetMontant;
        private System.Windows.Forms.TextBox txtBudgetNom;
        private System.Windows.Forms.Button btnAjoutBudget;
        private System.Windows.Forms.Label lbBudgetMontant;
        private System.Windows.Forms.Label lblBudgetNom;
        private System.Windows.Forms.Label lbBudgetTitre;
        private System.Windows.Forms.ErrorProvider errorBudgetNom;
        private System.Windows.Forms.ErrorProvider errorBudgetMontant;
    }
}