namespace uverova_kalkulacka
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxVysePujcky = new System.Windows.Forms.TextBox();
            this.textBoxDobaSplaceni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonZadat = new System.Windows.Forms.Button();
            this.textBoxCelkemZaplati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPreplatek = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVyseSplatky = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUrok = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(131, 19);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxVysePujcky
            // 
            this.textBoxVysePujcky.Location = new System.Drawing.Point(131, 50);
            this.textBoxVysePujcky.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxVysePujcky.Name = "textBoxVysePujcky";
            this.textBoxVysePujcky.Size = new System.Drawing.Size(100, 23);
            this.textBoxVysePujcky.TabIndex = 1;
            // 
            // textBoxDobaSplaceni
            // 
            this.textBoxDobaSplaceni.Location = new System.Drawing.Point(131, 81);
            this.textBoxDobaSplaceni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDobaSplaceni.Name = "textBoxDobaSplaceni";
            this.textBoxDobaSplaceni.Size = new System.Drawing.Size(100, 23);
            this.textBoxDobaSplaceni.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jméno klienta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Výše půjčky:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doba splácení [roky]:";
            // 
            // buttonZadat
            // 
            this.buttonZadat.Location = new System.Drawing.Point(12, 111);
            this.buttonZadat.Name = "buttonZadat";
            this.buttonZadat.Size = new System.Drawing.Size(219, 33);
            this.buttonZadat.TabIndex = 6;
            this.buttonZadat.Text = "Zadat";
            this.buttonZadat.UseVisualStyleBackColor = true;
            this.buttonZadat.Click += new System.EventHandler(this.buttonZadat_Click);
            // 
            // textBoxCelkemZaplati
            // 
            this.textBoxCelkemZaplati.Location = new System.Drawing.Point(131, 151);
            this.textBoxCelkemZaplati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCelkemZaplati.Name = "textBoxCelkemZaplati";
            this.textBoxCelkemZaplati.Size = new System.Drawing.Size(100, 23);
            this.textBoxCelkemZaplati.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Celkem zaplatí:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Přeplatek:";
            // 
            // textBoxPreplatek
            // 
            this.textBoxPreplatek.Location = new System.Drawing.Point(131, 182);
            this.textBoxPreplatek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPreplatek.Name = "textBoxPreplatek";
            this.textBoxPreplatek.Size = new System.Drawing.Size(100, 23);
            this.textBoxPreplatek.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Výše splátky:";
            // 
            // textBoxVyseSplatky
            // 
            this.textBoxVyseSplatky.Location = new System.Drawing.Point(131, 213);
            this.textBoxVyseSplatky.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxVyseSplatky.Name = "textBoxVyseSplatky";
            this.textBoxVyseSplatky.Size = new System.Drawing.Size(100, 23);
            this.textBoxVyseSplatky.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Úroková sazba:";
            // 
            // textBoxUrok
            // 
            this.textBoxUrok.Location = new System.Drawing.Point(131, 244);
            this.textBoxUrok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUrok.Name = "textBoxUrok";
            this.textBoxUrok.Size = new System.Drawing.Size(100, 23);
            this.textBoxUrok.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxUrok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxVyseSplatky);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPreplatek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCelkemZaplati);
            this.Controls.Add(this.buttonZadat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDobaSplaceni);
            this.Controls.Add(this.textBoxVysePujcky);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Úvěrová kalkulačka";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUrok;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVyseSplatky;

        private System.Windows.Forms.TextBox textBoxCelkemZaplati;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox textBoxPreplatek;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxVysePujcky;
        private System.Windows.Forms.Button buttonZadat;

        private System.Windows.Forms.TextBox textBoxDobaSplaceni;

        #endregion
    }
}