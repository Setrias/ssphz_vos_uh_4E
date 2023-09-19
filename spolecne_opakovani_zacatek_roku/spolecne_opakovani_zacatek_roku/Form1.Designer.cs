namespace spolecne_opakovani_zacatek_roku
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
            this.buttonMail = new System.Windows.Forms.Button();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelCisloMereni = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxVypocetOdporu = new System.Windows.Forms.GroupBox();
            this.groupBoxVypocetFrekvence = new System.Windows.Forms.GroupBox();
            this.textBoxUhlovaFrekvence = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonZadatHodnotyFrekvence = new System.Windows.Forms.Button();
            this.textBoxKapacita = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIndukcnost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVyslednyOdpor = new System.Windows.Forms.TextBox();
            this.buttonHodnotyMereni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProud = new System.Windows.Forms.TextBox();
            this.textBoxNapeti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxVypocetOdporu.SuspendLayout();
            this.groupBoxVypocetFrekvence.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMail
            // 
            this.buttonMail.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMail.Location = new System.Drawing.Point(241, 17);
            this.buttonMail.Name = "buttonMail";
            this.buttonMail.Size = new System.Drawing.Size(101, 23);
            this.buttonMail.TabIndex = 14;
            this.buttonMail.Text = "Zadat Mail";
            this.buttonMail.UseVisualStyleBackColor = true;
            this.buttonMail.Click += new System.EventHandler(this.buttonMail_Click);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMail.Location = new System.Drawing.Point(62, 17);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(173, 23);
            this.textBoxMail.TabIndex = 12;
            // 
            // labelCisloMereni
            // 
            this.labelCisloMereni.AutoSize = true;
            this.labelCisloMereni.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCisloMereni.Location = new System.Drawing.Point(87, 76);
            this.labelCisloMereni.Name = "labelCisloMereni";
            this.labelCisloMereni.Size = new System.Drawing.Size(12, 16);
            this.labelCisloMereni.TabIndex = 13;
            this.labelCisloMereni.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Číslo měření:";
            // 
            // groupBoxVypocetOdporu
            // 
            this.groupBoxVypocetOdporu.Controls.Add(this.labelCisloMereni);
            this.groupBoxVypocetOdporu.Controls.Add(this.label8);
            this.groupBoxVypocetOdporu.Controls.Add(this.groupBoxVypocetFrekvence);
            this.groupBoxVypocetOdporu.Controls.Add(this.label4);
            this.groupBoxVypocetOdporu.Controls.Add(this.textBoxVyslednyOdpor);
            this.groupBoxVypocetOdporu.Controls.Add(this.buttonHodnotyMereni);
            this.groupBoxVypocetOdporu.Controls.Add(this.label2);
            this.groupBoxVypocetOdporu.Controls.Add(this.textBoxProud);
            this.groupBoxVypocetOdporu.Controls.Add(this.textBoxNapeti);
            this.groupBoxVypocetOdporu.Controls.Add(this.label3);
            this.groupBoxVypocetOdporu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxVypocetOdporu.Location = new System.Drawing.Point(15, 46);
            this.groupBoxVypocetOdporu.Name = "groupBoxVypocetOdporu";
            this.groupBoxVypocetOdporu.Size = new System.Drawing.Size(327, 276);
            this.groupBoxVypocetOdporu.TabIndex = 15;
            this.groupBoxVypocetOdporu.TabStop = false;
            this.groupBoxVypocetOdporu.Text = "Výpočet odporu";
            // 
            // groupBoxVypocetFrekvence
            // 
            this.groupBoxVypocetFrekvence.Controls.Add(this.textBoxUhlovaFrekvence);
            this.groupBoxVypocetFrekvence.Controls.Add(this.label7);
            this.groupBoxVypocetFrekvence.Controls.Add(this.buttonZadatHodnotyFrekvence);
            this.groupBoxVypocetFrekvence.Controls.Add(this.textBoxKapacita);
            this.groupBoxVypocetFrekvence.Controls.Add(this.label6);
            this.groupBoxVypocetFrekvence.Controls.Add(this.textBoxIndukcnost);
            this.groupBoxVypocetFrekvence.Controls.Add(this.label5);
            this.groupBoxVypocetFrekvence.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxVypocetFrekvence.Location = new System.Drawing.Point(6, 140);
            this.groupBoxVypocetFrekvence.Name = "groupBoxVypocetFrekvence";
            this.groupBoxVypocetFrekvence.Size = new System.Drawing.Size(315, 130);
            this.groupBoxVypocetFrekvence.TabIndex = 11;
            this.groupBoxVypocetFrekvence.TabStop = false;
            this.groupBoxVypocetFrekvence.Text = "Výpočet frekvence oscilátoru";
            // 
            // textBoxUhlovaFrekvence
            // 
            this.textBoxUhlovaFrekvence.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUhlovaFrekvence.Location = new System.Drawing.Point(154, 96);
            this.textBoxUhlovaFrekvence.Name = "textBoxUhlovaFrekvence";
            this.textBoxUhlovaFrekvence.ReadOnly = true;
            this.textBoxUhlovaFrekvence.Size = new System.Drawing.Size(148, 23);
            this.textBoxUhlovaFrekvence.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Úhlová frekvence [omega]:";
            // 
            // buttonZadatHodnotyFrekvence
            // 
            this.buttonZadatHodnotyFrekvence.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZadatHodnotyFrekvence.Location = new System.Drawing.Point(221, 26);
            this.buttonZadatHodnotyFrekvence.Name = "buttonZadatHodnotyFrekvence";
            this.buttonZadatHodnotyFrekvence.Size = new System.Drawing.Size(88, 52);
            this.buttonZadatHodnotyFrekvence.TabIndex = 12;
            this.buttonZadatHodnotyFrekvence.Text = "Zadat hodnoty";
            this.buttonZadatHodnotyFrekvence.UseVisualStyleBackColor = true;
            this.buttonZadatHodnotyFrekvence.Click += new System.EventHandler(this.buttonZadatHodnotyFrekvence_Click);
            // 
            // textBoxKapacita
            // 
            this.textBoxKapacita.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKapacita.Location = new System.Drawing.Point(94, 55);
            this.textBoxKapacita.Name = "textBoxKapacita";
            this.textBoxKapacita.Size = new System.Drawing.Size(121, 23);
            this.textBoxKapacita.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kapacita [F]:";
            // 
            // textBoxIndukcnost
            // 
            this.textBoxIndukcnost.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndukcnost.Location = new System.Drawing.Point(94, 26);
            this.textBoxIndukcnost.Name = "textBoxIndukcnost";
            this.textBoxIndukcnost.Size = new System.Drawing.Size(121, 23);
            this.textBoxIndukcnost.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Indukčnost [H]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Výsledný odpor [Ohm]:";
            // 
            // textBoxVyslednyOdpor
            // 
            this.textBoxVyslednyOdpor.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVyslednyOdpor.Location = new System.Drawing.Point(132, 98);
            this.textBoxVyslednyOdpor.Name = "textBoxVyslednyOdpor";
            this.textBoxVyslednyOdpor.ReadOnly = true;
            this.textBoxVyslednyOdpor.Size = new System.Drawing.Size(76, 23);
            this.textBoxVyslednyOdpor.TabIndex = 9;
            // 
            // buttonHodnotyMereni
            // 
            this.buttonHodnotyMereni.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHodnotyMereni.Location = new System.Drawing.Point(226, 16);
            this.buttonHodnotyMereni.Name = "buttonHodnotyMereni";
            this.buttonHodnotyMereni.Size = new System.Drawing.Size(95, 52);
            this.buttonHodnotyMereni.TabIndex = 8;
            this.buttonHodnotyMereni.Text = "Zadat hodnoty";
            this.buttonHodnotyMereni.UseVisualStyleBackColor = true;
            this.buttonHodnotyMereni.Click += new System.EventHandler(this.buttonHodnotyMereni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Napětí [V]:";
            // 
            // textBoxProud
            // 
            this.textBoxProud.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProud.Location = new System.Drawing.Point(99, 45);
            this.textBoxProud.Name = "textBoxProud";
            this.textBoxProud.Size = new System.Drawing.Size(121, 23);
            this.textBoxProud.TabIndex = 6;
            // 
            // textBoxNapeti
            // 
            this.textBoxNapeti.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNapeti.Location = new System.Drawing.Point(99, 16);
            this.textBoxNapeti.Name = "textBoxNapeti";
            this.textBoxNapeti.Size = new System.Drawing.Size(121, 23);
            this.textBoxNapeti.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Proud [A]:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "E-mail:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 334);
            this.Controls.Add(this.buttonMail);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.groupBoxVypocetOdporu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxVypocetOdporu.ResumeLayout(false);
            this.groupBoxVypocetOdporu.PerformLayout();
            this.groupBoxVypocetFrekvence.ResumeLayout(false);
            this.groupBoxVypocetFrekvence.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonMail;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelCisloMereni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxVypocetOdporu;
        private System.Windows.Forms.GroupBox groupBoxVypocetFrekvence;
        private System.Windows.Forms.TextBox textBoxUhlovaFrekvence;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonZadatHodnotyFrekvence;
        private System.Windows.Forms.TextBox textBoxKapacita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIndukcnost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVyslednyOdpor;
        private System.Windows.Forms.Button buttonHodnotyMereni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProud;
        private System.Windows.Forms.TextBox textBoxNapeti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}