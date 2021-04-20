
namespace AsoSportiveGUI
{
    partial class FrmStatistique
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblStatistique = new System.Windows.Forms.Label();
            this.pnlStatistiqueParEleve = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlStatistiqueGenre = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(713, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblStatistique
            // 
            this.lblStatistique.AutoSize = true;
            this.lblStatistique.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistique.Location = new System.Drawing.Point(12, 22);
            this.lblStatistique.Name = "lblStatistique";
            this.lblStatistique.Size = new System.Drawing.Size(208, 25);
            this.lblStatistique.TabIndex = 0;
            this.lblStatistique.Text = "Statistique par élève";
            // 
            // pnlStatistiqueParEleve
            // 
            this.pnlStatistiqueParEleve.AutoScroll = true;
            this.pnlStatistiqueParEleve.AutoSize = true;
            this.pnlStatistiqueParEleve.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.pnlStatistiqueParEleve.ColumnCount = 3;
            this.pnlStatistiqueParEleve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlStatistiqueParEleve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlStatistiqueParEleve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlStatistiqueParEleve.Location = new System.Drawing.Point(3, 3);
            this.pnlStatistiqueParEleve.Name = "pnlStatistiqueParEleve";
            this.pnlStatistiqueParEleve.RowCount = 1;
            this.pnlStatistiqueParEleve.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlStatistiqueParEleve.Size = new System.Drawing.Size(8, 4);
            this.pnlStatistiqueParEleve.TabIndex = 1;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.Controls.Add(this.pnlStatistiqueParEleve);
            this.flowLayoutPanel.Controls.Add(this.pnlStatistiqueGenre);
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(17, 50);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(14, 20);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // pnlStatistiqueGenre
            // 
            this.pnlStatistiqueGenre.AutoScroll = true;
            this.pnlStatistiqueGenre.AutoSize = true;
            this.pnlStatistiqueGenre.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.pnlStatistiqueGenre.ColumnCount = 2;
            this.pnlStatistiqueGenre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlStatistiqueGenre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlStatistiqueGenre.Location = new System.Drawing.Point(3, 13);
            this.pnlStatistiqueGenre.Name = "pnlStatistiqueGenre";
            this.pnlStatistiqueGenre.RowCount = 1;
            this.pnlStatistiqueGenre.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlStatistiqueGenre.Size = new System.Drawing.Size(8, 4);
            this.pnlStatistiqueGenre.TabIndex = 2;
            // 
            // FrmStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.lblStatistique);
            this.Controls.Add(this.btnRetour);
            this.Name = "FrmStatistique";
            this.Text = "Statistique";
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblStatistique;
        private System.Windows.Forms.TableLayoutPanel pnlStatistiqueParEleve;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel pnlStatistiqueGenre;
    }
}