namespace AsoSportiveGUI
{
    partial class FrmDetailsEleve
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(712, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRetour.Location = new System.Drawing.Point(616, 16);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            // 
            // pnl
            // 
            this.pnl.AutoSize = true;
            this.pnl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.pnl.ColumnCount = 11;
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl.Location = new System.Drawing.Point(16, 56);
            this.pnl.Name = "pnl";
            this.pnl.RowCount = 1;
            this.pnl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl.Size = new System.Drawing.Size(768, 376);
            this.pnl.TabIndex = 2;
            // 
            // FrmDetailsEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmDetailsEleve";
            this.Text = "Détails Elève";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.TableLayoutPanel pnl;
    }
}