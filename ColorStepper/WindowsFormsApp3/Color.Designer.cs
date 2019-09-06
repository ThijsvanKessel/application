namespace WindowsFormsApp3
{
    partial class frmColorTkes
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
            this.pgbBarTkes = new System.Windows.Forms.ProgressBar();
            this.btnStepTkes = new System.Windows.Forms.Button();
            this.btnGreenTkes = new System.Windows.Forms.Button();
            this.btnRedTkes = new System.Windows.Forms.Button();
            this.btnBlueTkes = new System.Windows.Forms.Button();
            this.pcbkleurTkes = new System.Windows.Forms.PictureBox();
            this.gbxStepTkes = new System.Windows.Forms.GroupBox();
            this.lblDotsTkes = new System.Windows.Forms.Label();
            this.lblStepTkes = new System.Windows.Forms.Label();
            this.gbxColorTkes = new System.Windows.Forms.GroupBox();
            this.lblDots2Tkes = new System.Windows.Forms.Label();
            this.lblCurrentcolorTkes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbkleurTkes)).BeginInit();
            this.gbxStepTkes.SuspendLayout();
            this.gbxColorTkes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgbBarTkes
            // 
            this.pgbBarTkes.Location = new System.Drawing.Point(0, 74);
            this.pgbBarTkes.Maximum = 3;
            this.pgbBarTkes.Name = "pgbBarTkes";
            this.pgbBarTkes.Size = new System.Drawing.Size(305, 71);
            this.pgbBarTkes.TabIndex = 0;
            // 
            // btnStepTkes
            // 
            this.btnStepTkes.Location = new System.Drawing.Point(0, 21);
            this.btnStepTkes.Name = "btnStepTkes";
            this.btnStepTkes.Size = new System.Drawing.Size(155, 47);
            this.btnStepTkes.TabIndex = 1;
            this.btnStepTkes.Text = "Step";
            this.btnStepTkes.UseVisualStyleBackColor = true;
            this.btnStepTkes.Click += new System.EventHandler(this.btnStepTkes_Click);
            // 
            // btnGreenTkes
            // 
            this.btnGreenTkes.Location = new System.Drawing.Point(105, 21);
            this.btnGreenTkes.Name = "btnGreenTkes";
            this.btnGreenTkes.Size = new System.Drawing.Size(93, 23);
            this.btnGreenTkes.TabIndex = 2;
            this.btnGreenTkes.Text = "Green";
            this.btnGreenTkes.UseVisualStyleBackColor = true;
            this.btnGreenTkes.Click += new System.EventHandler(this.btnGreenTkes_Click);
            // 
            // btnRedTkes
            // 
            this.btnRedTkes.Location = new System.Drawing.Point(204, 21);
            this.btnRedTkes.Name = "btnRedTkes";
            this.btnRedTkes.Size = new System.Drawing.Size(93, 23);
            this.btnRedTkes.TabIndex = 3;
            this.btnRedTkes.Text = "Red";
            this.btnRedTkes.UseVisualStyleBackColor = true;
            this.btnRedTkes.Click += new System.EventHandler(this.btnRedTkes_Click);
            // 
            // btnBlueTkes
            // 
            this.btnBlueTkes.Location = new System.Drawing.Point(6, 21);
            this.btnBlueTkes.Name = "btnBlueTkes";
            this.btnBlueTkes.Size = new System.Drawing.Size(93, 23);
            this.btnBlueTkes.TabIndex = 4;
            this.btnBlueTkes.Text = "Blue";
            this.btnBlueTkes.UseVisualStyleBackColor = true;
            this.btnBlueTkes.Click += new System.EventHandler(this.btnBlueTkes_Click);
            // 
            // pcbkleurTkes
            // 
            this.pcbkleurTkes.Location = new System.Drawing.Point(0, 50);
            this.pcbkleurTkes.Name = "pcbkleurTkes";
            this.pcbkleurTkes.Size = new System.Drawing.Size(305, 116);
            this.pcbkleurTkes.TabIndex = 5;
            this.pcbkleurTkes.TabStop = false;
            // 
            // gbxStepTkes
            // 
            this.gbxStepTkes.Controls.Add(this.lblDotsTkes);
            this.gbxStepTkes.Controls.Add(this.lblStepTkes);
            this.gbxStepTkes.Controls.Add(this.btnStepTkes);
            this.gbxStepTkes.Controls.Add(this.pgbBarTkes);
            this.gbxStepTkes.Location = new System.Drawing.Point(12, 12);
            this.gbxStepTkes.Name = "gbxStepTkes";
            this.gbxStepTkes.Size = new System.Drawing.Size(307, 156);
            this.gbxStepTkes.TabIndex = 6;
            this.gbxStepTkes.TabStop = false;
            this.gbxStepTkes.Text = "Step";
            // 
            // lblDotsTkes
            // 
            this.lblDotsTkes.AutoSize = true;
            this.lblDotsTkes.Location = new System.Drawing.Point(244, 36);
            this.lblDotsTkes.Name = "lblDotsTkes";
            this.lblDotsTkes.Size = new System.Drawing.Size(20, 17);
            this.lblDotsTkes.TabIndex = 9;
            this.lblDotsTkes.Text = "...";
            // 
            // lblStepTkes
            // 
            this.lblStepTkes.AutoSize = true;
            this.lblStepTkes.Location = new System.Drawing.Point(205, 36);
            this.lblStepTkes.Name = "lblStepTkes";
            this.lblStepTkes.Size = new System.Drawing.Size(41, 17);
            this.lblStepTkes.TabIndex = 8;
            this.lblStepTkes.Text = "Step:";
            // 
            // gbxColorTkes
            // 
            this.gbxColorTkes.Controls.Add(this.lblDots2Tkes);
            this.gbxColorTkes.Controls.Add(this.lblCurrentcolorTkes);
            this.gbxColorTkes.Controls.Add(this.btnRedTkes);
            this.gbxColorTkes.Controls.Add(this.btnGreenTkes);
            this.gbxColorTkes.Controls.Add(this.pcbkleurTkes);
            this.gbxColorTkes.Controls.Add(this.btnBlueTkes);
            this.gbxColorTkes.Location = new System.Drawing.Point(12, 174);
            this.gbxColorTkes.Name = "gbxColorTkes";
            this.gbxColorTkes.Size = new System.Drawing.Size(307, 200);
            this.gbxColorTkes.TabIndex = 7;
            this.gbxColorTkes.TabStop = false;
            this.gbxColorTkes.Text = "Clolor";
            // 
            // lblDots2Tkes
            // 
            this.lblDots2Tkes.AutoSize = true;
            this.lblDots2Tkes.Location = new System.Drawing.Point(108, 169);
            this.lblDots2Tkes.Name = "lblDots2Tkes";
            this.lblDots2Tkes.Size = new System.Drawing.Size(20, 17);
            this.lblDots2Tkes.TabIndex = 8;
            this.lblDots2Tkes.Text = "...";
            // 
            // lblCurrentcolorTkes
            // 
            this.lblCurrentcolorTkes.AutoSize = true;
            this.lblCurrentcolorTkes.Location = new System.Drawing.Point(6, 169);
            this.lblCurrentcolorTkes.Name = "lblCurrentcolorTkes";
            this.lblCurrentcolorTkes.Size = new System.Drawing.Size(96, 17);
            this.lblCurrentcolorTkes.TabIndex = 9;
            this.lblCurrentcolorTkes.Text = "Current Color:";
            // 
            // frmColorTkes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 380);
            this.Controls.Add(this.gbxColorTkes);
            this.Controls.Add(this.gbxStepTkes);
            this.Name = "frmColorTkes";
            this.Text = "Color";
            ((System.ComponentModel.ISupportInitialize)(this.pcbkleurTkes)).EndInit();
            this.gbxStepTkes.ResumeLayout(false);
            this.gbxStepTkes.PerformLayout();
            this.gbxColorTkes.ResumeLayout(false);
            this.gbxColorTkes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbBarTkes;
        private System.Windows.Forms.Button btnStepTkes;
        private System.Windows.Forms.Button btnGreenTkes;
        private System.Windows.Forms.Button btnRedTkes;
        private System.Windows.Forms.Button btnBlueTkes;
        private System.Windows.Forms.PictureBox pcbkleurTkes;
        private System.Windows.Forms.GroupBox gbxStepTkes;
        private System.Windows.Forms.Label lblDotsTkes;
        private System.Windows.Forms.Label lblStepTkes;
        private System.Windows.Forms.GroupBox gbxColorTkes;
        private System.Windows.Forms.Label lblCurrentcolorTkes;
        private System.Windows.Forms.Label lblDots2Tkes;
    }
}

