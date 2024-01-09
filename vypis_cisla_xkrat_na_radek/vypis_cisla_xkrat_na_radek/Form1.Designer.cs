namespace vypis_cisla_xkrat_na_radek
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
            this.listBoxZadaneCislo = new System.Windows.Forms.ListBox();
            this.buttonZadaneCislo = new System.Windows.Forms.Button();
            this.numericUpDownZadaneCislo = new System.Windows.Forms.NumericUpDown();
            this.textBoxZadaneCisloRadek = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZadaneCislo)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxZadaneCislo
            // 
            this.listBoxZadaneCislo.FormattingEnabled = true;
            this.listBoxZadaneCislo.ItemHeight = 16;
            this.listBoxZadaneCislo.Location = new System.Drawing.Point(223, 122);
            this.listBoxZadaneCislo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxZadaneCislo.Name = "listBoxZadaneCislo";
            this.listBoxZadaneCislo.Size = new System.Drawing.Size(120, 116);
            this.listBoxZadaneCislo.TabIndex = 0;
            // 
            // buttonZadaneCislo
            // 
            this.buttonZadaneCislo.AutoSize = true;
            this.buttonZadaneCislo.Location = new System.Drawing.Point(54, 161);
            this.buttonZadaneCislo.Name = "buttonZadaneCislo";
            this.buttonZadaneCislo.Size = new System.Drawing.Size(108, 26);
            this.buttonZadaneCislo.TabIndex = 1;
            this.buttonZadaneCislo.Text = "Zadané číslo";
            this.buttonZadaneCislo.UseVisualStyleBackColor = true;
            this.buttonZadaneCislo.Click += new System.EventHandler(this.buttonZadaneCislo_Click);
            // 
            // numericUpDownZadaneCislo
            // 
            this.numericUpDownZadaneCislo.Location = new System.Drawing.Point(54, 132);
            this.numericUpDownZadaneCislo.Name = "numericUpDownZadaneCislo";
            this.numericUpDownZadaneCislo.Size = new System.Drawing.Size(108, 23);
            this.numericUpDownZadaneCislo.TabIndex = 2;
            // 
            // textBoxZadaneCisloRadek
            // 
            this.textBoxZadaneCisloRadek.Location = new System.Drawing.Point(54, 193);
            this.textBoxZadaneCisloRadek.Name = "textBoxZadaneCisloRadek";
            this.textBoxZadaneCisloRadek.Size = new System.Drawing.Size(108, 23);
            this.textBoxZadaneCisloRadek.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.textBoxZadaneCisloRadek);
            this.Controls.Add(this.numericUpDownZadaneCislo);
            this.Controls.Add(this.buttonZadaneCislo);
            this.Controls.Add(this.listBoxZadaneCislo);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZadaneCislo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxZadaneCisloRadek;
        private System.Windows.Forms.NumericUpDown numericUpDownZadaneCislo;

        private System.Windows.Forms.Button buttonZadaneCislo;
        private System.Windows.Forms.TextBox textBoxZadaneCislo;

        private System.Windows.Forms.ListBox listBoxZadaneCislo;

        #endregion
    }
}