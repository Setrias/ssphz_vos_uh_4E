namespace Soubory_jmeno_rok
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
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.textBoxRok = new System.Windows.Forms.TextBox();
            this.buttonPrecist = new System.Windows.Forms.Button();
            this.buttonVyberRok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxVyber = new System.Windows.Forms.ListBox();
            this.numericUpDownVyberRok = new System.Windows.Forms.NumericUpDown();
            this.buttonVybratSoubor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVyberRok)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(292, 22);
            this.buttonUlozit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(107, 27);
            this.buttonUlozit.TabIndex = 0;
            this.buttonUlozit.Text = "Uložit do souboru";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jméno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rok narození:";
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Location = new System.Drawing.Point(94, 24);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(100, 23);
            this.textBoxJmeno.TabIndex = 3;
            // 
            // textBoxRok
            // 
            this.textBoxRok.Location = new System.Drawing.Point(94, 59);
            this.textBoxRok.Name = "textBoxRok";
            this.textBoxRok.Size = new System.Drawing.Size(100, 23);
            this.textBoxRok.TabIndex = 4;
            // 
            // buttonPrecist
            // 
            this.buttonPrecist.Location = new System.Drawing.Point(200, 57);
            this.buttonPrecist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrecist.Name = "buttonPrecist";
            this.buttonPrecist.Size = new System.Drawing.Size(199, 27);
            this.buttonPrecist.TabIndex = 9;
            this.buttonPrecist.Text = "Vybrat a přečíst soubor";
            this.buttonPrecist.UseVisualStyleBackColor = true;
            this.buttonPrecist.Click += new System.EventHandler(this.buttonPrecist_Click);
            // 
            // buttonVyberRok
            // 
            this.buttonVyberRok.Location = new System.Drawing.Point(200, 165);
            this.buttonVyberRok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonVyberRok.Name = "buttonVyberRok";
            this.buttonVyberRok.Size = new System.Drawing.Size(199, 38);
            this.buttonVyberRok.TabIndex = 12;
            this.buttonVyberRok.Text = "Vypsat lidi";
            this.buttonVyberRok.UseVisualStyleBackColor = true;
            this.buttonVyberRok.Click += new System.EventHandler(this.buttonVyberRok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Zadaný rok [1900 - 2100]:";
            // 
            // listBoxVyber
            // 
            this.listBoxVyber.FormattingEnabled = true;
            this.listBoxVyber.ItemHeight = 16;
            this.listBoxVyber.Location = new System.Drawing.Point(12, 112);
            this.listBoxVyber.Name = "listBoxVyber";
            this.listBoxVyber.Size = new System.Drawing.Size(182, 260);
            this.listBoxVyber.TabIndex = 13;
            // 
            // numericUpDownVyberRok
            // 
            this.numericUpDownVyberRok.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownVyberRok.Location = new System.Drawing.Point(200, 131);
            this.numericUpDownVyberRok.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            this.numericUpDownVyberRok.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            this.numericUpDownVyberRok.Name = "numericUpDownVyberRok";
            this.numericUpDownVyberRok.Size = new System.Drawing.Size(199, 27);
            this.numericUpDownVyberRok.TabIndex = 14;
            this.numericUpDownVyberRok.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // buttonVybratSoubor
            // 
            this.buttonVybratSoubor.Location = new System.Drawing.Point(200, 22);
            this.buttonVybratSoubor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonVybratSoubor.Name = "buttonVybratSoubor";
            this.buttonVybratSoubor.Size = new System.Drawing.Size(86, 27);
            this.buttonVybratSoubor.TabIndex = 15;
            this.buttonVybratSoubor.Text = "Vybrat soubor";
            this.buttonVybratSoubor.UseVisualStyleBackColor = true;
            this.buttonVybratSoubor.Click += new System.EventHandler(this.buttonVybratSoubor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 388);
            this.Controls.Add(this.buttonVybratSoubor);
            this.Controls.Add(this.numericUpDownVyberRok);
            this.Controls.Add(this.listBoxVyber);
            this.Controls.Add(this.buttonVyberRok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPrecist);
            this.Controls.Add(this.textBoxRok);
            this.Controls.Add(this.textBoxJmeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUlozit);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Soubory";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVyberRok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonVybratSoubor;

        private System.Windows.Forms.NumericUpDown numericUpDownVyberRok;

        private System.Windows.Forms.ListBox listBoxVyber;

        private System.Windows.Forms.Button buttonVyberRok;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button buttonUlozit;

        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.TextBox textBoxRok;

        private System.Windows.Forms.Button buttonPrecist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}