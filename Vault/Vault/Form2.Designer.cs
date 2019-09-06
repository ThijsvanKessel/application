namespace safeprojectname
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.rtbSerialMonitorTkes = new System.Windows.Forms.RichTextBox();
            this.btnClearTkes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSerialMonitorTkes
            // 
            this.rtbSerialMonitorTkes.Location = new System.Drawing.Point(0, 0);
            this.rtbSerialMonitorTkes.Name = "rtbSerialMonitorTkes";
            this.rtbSerialMonitorTkes.Size = new System.Drawing.Size(222, 284);
            this.rtbSerialMonitorTkes.TabIndex = 0;
            this.rtbSerialMonitorTkes.Text = "";
            // 
            // btnClearTkes
            // 
            this.btnClearTkes.Location = new System.Drawing.Point(12, 290);
            this.btnClearTkes.Name = "btnClearTkes";
            this.btnClearTkes.Size = new System.Drawing.Size(75, 23);
            this.btnClearTkes.TabIndex = 1;
            this.btnClearTkes.Text = "Clear";
            this.btnClearTkes.UseVisualStyleBackColor = true;
            this.btnClearTkes.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 320);
            this.ControlBox = false;
            this.Controls.Add(this.btnClearTkes);
            this.Controls.Add(this.rtbSerialMonitorTkes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Serial Monitor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSerialMonitorTkes;
        private System.Windows.Forms.Button btnClearTkes;
    }
}