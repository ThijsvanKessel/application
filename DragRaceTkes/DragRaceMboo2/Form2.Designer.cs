﻿namespace DragRaceTkes2
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
            this.btnClear = new System.Windows.Forms.Button();
            this.rtbSerialMonitor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(458, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // rtbSerialMonitor
            // 
            this.rtbSerialMonitor.BackColor = System.Drawing.Color.Black;
            this.rtbSerialMonitor.ForeColor = System.Drawing.Color.White;
            this.rtbSerialMonitor.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rtbSerialMonitor.Location = new System.Drawing.Point(12, 12);
            this.rtbSerialMonitor.Name = "rtbSerialMonitor";
            this.rtbSerialMonitor.Size = new System.Drawing.Size(521, 208);
            this.rtbSerialMonitor.TabIndex = 2;
            this.rtbSerialMonitor.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 258);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtbSerialMonitor);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtbSerialMonitor;
    }
}