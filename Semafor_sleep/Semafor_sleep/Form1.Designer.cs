﻿namespace Semafor_sleep
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
            this.panelSemafor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelSemafor
            // 
            this.panelSemafor.Location = new System.Drawing.Point(12, 12);
            this.panelSemafor.Name = "panelSemafor";
            this.panelSemafor.Size = new System.Drawing.Size(221, 426);
            this.panelSemafor.TabIndex = 0;
            this.panelSemafor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSemafor_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSemafor);
            this.Name = "Form1";
            this.Text = "Semafor Sleep";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelSemafor;

        #endregion
    }
}