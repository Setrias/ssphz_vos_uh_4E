namespace ukol_3
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
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.textBoxVysledek = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownC.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownC.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numericUpDownC.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(196, 30);
            this.numericUpDownC.TabIndex = 0;
            this.numericUpDownC.Value = new decimal(new int[] { 4, 0, 0, 0 });
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.numericUpDownC_ValueChanged);
            // 
            // textBoxVysledek
            // 
            this.textBoxVysledek.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVysledek.Location = new System.Drawing.Point(12, 48);
            this.textBoxVysledek.Name = "textBoxVysledek";
            this.textBoxVysledek.Size = new System.Drawing.Size(196, 27);
            this.textBoxVysledek.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 89);
            this.Controls.Add(this.textBoxVysledek);
            this.Controls.Add(this.numericUpDownC);
            this.Name = "Form1";
            this.Text = "Koeficient";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxVysledek;

        private System.Windows.Forms.NumericUpDown numericUpDownC;

        #endregion
    }
}