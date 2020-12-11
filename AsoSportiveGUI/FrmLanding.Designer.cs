namespace AsoSportiveGUI
{
    partial class FrmLanding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLanding));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.picBoxAs = new System.Windows.Forms.PictureBox();
            this.btnLanding = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.picBoxStVincent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStVincent)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxAs
            // 
            this.picBoxAs.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAs.Image")));
            this.picBoxAs.Location = new System.Drawing.Point(157, 169);
            this.picBoxAs.Name = "picBoxAs";
            this.picBoxAs.Size = new System.Drawing.Size(194, 167);
            this.picBoxAs.TabIndex = 1;
            this.picBoxAs.TabStop = false;
            // 
            // btnLanding
            // 
            this.btnLanding.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnLanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanding.Location = new System.Drawing.Point(176, 377);
            this.btnLanding.Name = "btnLanding";
            this.btnLanding.Size = new System.Drawing.Size(159, 52);
            this.btnLanding.TabIndex = 2;
            this.btnLanding.Text = "connexion";
            this.btnLanding.UseVisualStyleBackColor = false;
            this.btnLanding.Click += new System.EventHandler(this.btnLanding_Click);
            // 
            // picBoxStVincent
            // 
            this.picBoxStVincent.Image = ((System.Drawing.Image)(resources.GetObject("picBoxStVincent.Image")));
            this.picBoxStVincent.Location = new System.Drawing.Point(-4, -55);
            this.picBoxStVincent.Name = "picBoxStVincent";
            this.picBoxStVincent.Size = new System.Drawing.Size(182, 142);
            this.picBoxStVincent.TabIndex = 3;
            this.picBoxStVincent.TabStop = false;
            // 
            // FrmLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(497, 525);
            this.Controls.Add(this.picBoxStVincent);
            this.Controls.Add(this.btnLanding);
            this.Controls.Add(this.picBoxAs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmLanding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLanding";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStVincent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox picBoxAs;
        private System.Windows.Forms.Button btnLanding;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox picBoxStVincent;
    }
}