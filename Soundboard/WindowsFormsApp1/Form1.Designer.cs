namespace Radio

{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPianoManTkes = new System.Windows.Forms.Button();
            this.btnNeverGonnaGiveYouUpTkes = new System.Windows.Forms.Button();
            this.btnRingOfFireTkes = new System.Windows.Forms.Button();
            this.btnHotelCaliforniaTkes = new System.Windows.Forms.Button();
            this.btnStopTkes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPianoManTkes
            // 
            this.btnPianoManTkes.Location = new System.Drawing.Point(12, 12);
            this.btnPianoManTkes.Name = "btnPianoManTkes";
            this.btnPianoManTkes.Size = new System.Drawing.Size(100, 100);
            this.btnPianoManTkes.TabIndex = 0;
            this.btnPianoManTkes.Text = "Piano Man";
            this.btnPianoManTkes.UseVisualStyleBackColor = true;
            this.btnPianoManTkes.Click += new System.EventHandler(this.btnPianoManTkes_Click);
            // 
            // btnNeverGonnaGiveYouUpTkes
            // 
            this.btnNeverGonnaGiveYouUpTkes.Location = new System.Drawing.Point(118, 118);
            this.btnNeverGonnaGiveYouUpTkes.Name = "btnNeverGonnaGiveYouUpTkes";
            this.btnNeverGonnaGiveYouUpTkes.Size = new System.Drawing.Size(100, 100);
            this.btnNeverGonnaGiveYouUpTkes.TabIndex = 2;
            this.btnNeverGonnaGiveYouUpTkes.Text = "Never Gonna Give You Up";
            this.btnNeverGonnaGiveYouUpTkes.UseVisualStyleBackColor = true;
            this.btnNeverGonnaGiveYouUpTkes.Click += new System.EventHandler(this.btnNeverGonnaGiveYouUpTkes_Click);
            // 
            // btnRingOfFireTkes
            // 
            this.btnRingOfFireTkes.Location = new System.Drawing.Point(12, 118);
            this.btnRingOfFireTkes.Name = "btnRingOfFireTkes";
            this.btnRingOfFireTkes.Size = new System.Drawing.Size(100, 100);
            this.btnRingOfFireTkes.TabIndex = 6;
            this.btnRingOfFireTkes.Text = "Ring of Fire";
            this.btnRingOfFireTkes.UseVisualStyleBackColor = true;
            this.btnRingOfFireTkes.Click += new System.EventHandler(this.btnRingOfFireTkes_Click);
            // 
            // btnHotelCaliforniaTkes
            // 
            this.btnHotelCaliforniaTkes.Location = new System.Drawing.Point(118, 12);
            this.btnHotelCaliforniaTkes.Name = "btnHotelCaliforniaTkes";
            this.btnHotelCaliforniaTkes.Size = new System.Drawing.Size(100, 100);
            this.btnHotelCaliforniaTkes.TabIndex = 7;
            this.btnHotelCaliforniaTkes.Text = "Hotel California";
            this.btnHotelCaliforniaTkes.UseVisualStyleBackColor = true;
            this.btnHotelCaliforniaTkes.Click += new System.EventHandler(this.btnHotelCaliforniaTkes_Click);
            // 
            // btnStopTkes
            // 
            this.btnStopTkes.Location = new System.Drawing.Point(12, 224);
            this.btnStopTkes.Name = "btnStopTkes";
            this.btnStopTkes.Size = new System.Drawing.Size(206, 47);
            this.btnStopTkes.TabIndex = 9;
            this.btnStopTkes.Text = "Stop";
            this.btnStopTkes.UseVisualStyleBackColor = true;
            this.btnStopTkes.Click += new System.EventHandler(this.btnStopTkes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 276);
            this.Controls.Add(this.btnStopTkes);
            this.Controls.Add(this.btnHotelCaliforniaTkes);
            this.Controls.Add(this.btnRingOfFireTkes);
            this.Controls.Add(this.btnNeverGonnaGiveYouUpTkes);
            this.Controls.Add(this.btnPianoManTkes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Soundboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPianoManTkes;
        private System.Windows.Forms.Button btnNeverGonnaGiveYouUpTkes;
        private System.Windows.Forms.Button btnRingOfFireTkes;
        private System.Windows.Forms.Button btnHotelCaliforniaTkes;
        private System.Windows.Forms.Button btnStopTkes;
    }
}

