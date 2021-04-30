
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
            this.lblStatistiqueParEleve = new System.Windows.Forms.Label();
            this.pnlStatistiqueParEleve = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStatistiqueGenre = new System.Windows.Forms.Label();
            this.pnlStatistiqueGenre = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombreAdherent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNaissance = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaissance)).BeginInit();
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
            // lblStatistiqueParEleve
            // 
            this.lblStatistiqueParEleve.AutoSize = true;
            this.lblStatistiqueParEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistiqueParEleve.Location = new System.Drawing.Point(3, 25);
            this.lblStatistiqueParEleve.Name = "lblStatistiqueParEleve";
            this.lblStatistiqueParEleve.Size = new System.Drawing.Size(499, 25);
            this.lblStatistiqueParEleve.TabIndex = 0;
            this.lblStatistiqueParEleve.Text = "Nombre de participation aux événements par élève";
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
            this.pnlStatistiqueParEleve.Location = new System.Drawing.Point(3, 53);
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
            this.flowLayoutPanel.Controls.Add(this.lblNombreAdherent);
            this.flowLayoutPanel.Controls.Add(this.lblStatistiqueParEleve);
            this.flowLayoutPanel.Controls.Add(this.pnlStatistiqueParEleve);
            this.flowLayoutPanel.Controls.Add(this.lblStatistiqueGenre);
            this.flowLayoutPanel.Controls.Add(this.pnlStatistiqueGenre);
            this.flowLayoutPanel.Controls.Add(this.label1);
            this.flowLayoutPanel.Controls.Add(this.dgvNaissance);
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(22, 40);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(505, 276);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // lblStatistiqueGenre
            // 
            this.lblStatistiqueGenre.AutoSize = true;
            this.lblStatistiqueGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistiqueGenre.Location = new System.Drawing.Point(3, 60);
            this.lblStatistiqueGenre.Name = "lblStatistiqueGenre";
            this.lblStatistiqueGenre.Size = new System.Drawing.Size(214, 25);
            this.lblStatistiqueGenre.TabIndex = 3;
            this.lblStatistiqueGenre.Text = "Répartition par genre";
            // 
            // pnlStatistiqueGenre
            // 
            this.pnlStatistiqueGenre.AutoScroll = true;
            this.pnlStatistiqueGenre.AutoSize = true;
            this.pnlStatistiqueGenre.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.pnlStatistiqueGenre.ColumnCount = 2;
            this.pnlStatistiqueGenre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlStatistiqueGenre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlStatistiqueGenre.Location = new System.Drawing.Point(3, 88);
            this.pnlStatistiqueGenre.Name = "pnlStatistiqueGenre";
            this.pnlStatistiqueGenre.RowCount = 1;
            this.pnlStatistiqueGenre.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlStatistiqueGenre.Size = new System.Drawing.Size(6, 4);
            this.pnlStatistiqueGenre.TabIndex = 2;
            // 
            // lblNombreAdherent
            // 
            this.lblNombreAdherent.AutoSize = true;
            this.lblNombreAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAdherent.Location = new System.Drawing.Point(3, 0);
            this.lblNombreAdherent.Name = "lblNombreAdherent";
            this.lblNombreAdherent.Size = new System.Drawing.Size(219, 25);
            this.lblNombreAdherent.TabIndex = 3;
            this.lblNombreAdherent.Text = "Nombre de licenciés :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(3, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Répartition par date de naissance";
            // 
            // dgvNaissance
            // 
            this.dgvNaissance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaissance.Location = new System.Drawing.Point(3, 123);
            this.dgvNaissance.Name = "dgvNaissance";
            this.dgvNaissance.Size = new System.Drawing.Size(499, 150);
            this.dgvNaissance.TabIndex = 5;
            // 
            // FrmStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btnRetour);
            this.Name = "FrmStatistique";
            this.Text = "Statistique";
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaissance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblStatistiqueParEleve;
        private System.Windows.Forms.TableLayoutPanel pnlStatistiqueParEleve;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel pnlStatistiqueGenre;
        private System.Windows.Forms.Label lblStatistiqueGenre;
        private System.Windows.Forms.Label lblNombreAdherent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNaissance;
    }
}