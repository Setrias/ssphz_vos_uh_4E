namespace indukcnost_civky
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
            this.textBoxNapeti = new System.Windows.Forms.TextBox();
            this.textBoxProud = new System.Windows.Forms.TextBox();
            this.buttonZadat = new System.Windows.Forms.Button();
            this.listBoxHodnoty = new System.Windows.Forms.ListBox();
            this.panelGraf = new System.Windows.Forms.Panel();
            this.textBoxOdporCivky = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIndukcnost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaxIndukcnost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPocetNadPetV = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNapeti
            // 
            this.textBoxNapeti.Location = new System.Drawing.Point(173, 58);
            this.textBoxNapeti.Name = "textBoxNapeti";
            this.textBoxNapeti.Size = new System.Drawing.Size(113, 24);
            this.textBoxNapeti.TabIndex = 1;
            // 
            // textBoxProud
            // 
            this.textBoxProud.Location = new System.Drawing.Point(173, 96);
            this.textBoxProud.Name = "textBoxProud";
            this.textBoxProud.Size = new System.Drawing.Size(113, 24);
            this.textBoxProud.TabIndex = 2;
            // 
            // buttonZadat
            // 
            this.buttonZadat.Location = new System.Drawing.Point(292, 20);
            this.buttonZadat.Name = "buttonZadat";
            this.buttonZadat.Size = new System.Drawing.Size(107, 100);
            this.buttonZadat.TabIndex = 3;
            this.buttonZadat.Text = "Zadat hodnoty";
            this.buttonZadat.UseVisualStyleBackColor = true;
            this.buttonZadat.Click += new System.EventHandler(this.buttonZadat_Click);
            // 
            // listBoxHodnoty
            // 
            this.listBoxHodnoty.FormattingEnabled = true;
            this.listBoxHodnoty.ItemHeight = 16;
            this.listBoxHodnoty.Location = new System.Drawing.Point(12, 258);
            this.listBoxHodnoty.Name = "listBoxHodnoty";
            this.listBoxHodnoty.Size = new System.Drawing.Size(387, 164);
            this.listBoxHodnoty.TabIndex = 4;
            // 
            // panelGraf
            // 
            this.panelGraf.Location = new System.Drawing.Point(416, 12);
            this.panelGraf.Name = "panelGraf";
            this.panelGraf.Size = new System.Drawing.Size(719, 470);
            this.panelGraf.TabIndex = 5;
            this.panelGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraf_Paint);
            // 
            // textBoxOdporCivky
            // 
            this.textBoxOdporCivky.Location = new System.Drawing.Point(173, 20);
            this.textBoxOdporCivky.Name = "textBoxOdporCivky";
            this.textBoxOdporCivky.Size = new System.Drawing.Size(113, 24);
            this.textBoxOdporCivky.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Napětí [V]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Proud [mA]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Odpor cívky [Ohm]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Indukčnost cívky [H]:";
            // 
            // textBoxIndukcnost
            // 
            this.textBoxIndukcnost.Location = new System.Drawing.Point(209, 136);
            this.textBoxIndukcnost.Name = "textBoxIndukcnost";
            this.textBoxIndukcnost.ReadOnly = true;
            this.textBoxIndukcnost.Size = new System.Drawing.Size(190, 24);
            this.textBoxIndukcnost.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Největší indukčnost [H]:";
            // 
            // textBoxMaxIndukcnost
            // 
            this.textBoxMaxIndukcnost.Location = new System.Drawing.Point(209, 174);
            this.textBoxMaxIndukcnost.Name = "textBoxMaxIndukcnost";
            this.textBoxMaxIndukcnost.ReadOnly = true;
            this.textBoxMaxIndukcnost.Size = new System.Drawing.Size(190, 24);
            this.textBoxMaxIndukcnost.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pocet mereni > 5V:";
            // 
            // textBoxPocetNadPetV
            // 
            this.textBoxPocetNadPetV.Location = new System.Drawing.Point(209, 212);
            this.textBoxPocetNadPetV.Name = "textBoxPocetNadPetV";
            this.textBoxPocetNadPetV.ReadOnly = true;
            this.textBoxPocetNadPetV.Size = new System.Drawing.Size(190, 24);
            this.textBoxPocetNadPetV.TabIndex = 13;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 437);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(387, 45);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 497);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPocetNadPetV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMaxIndukcnost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIndukcnost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOdporCivky);
            this.Controls.Add(this.panelGraf);
            this.Controls.Add(this.listBoxHodnoty);
            this.Controls.Add(this.buttonZadat);
            this.Controls.Add(this.textBoxProud);
            this.Controls.Add(this.textBoxNapeti);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Výpočet indukčnosti";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonReset;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaxIndukcnost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPocetNadPetV;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIndukcnost;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBoxOdporCivky;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBoxNapeti;
        private System.Windows.Forms.TextBox textBoxProud;
        private System.Windows.Forms.Button buttonZadat;
        private System.Windows.Forms.ListBox listBoxHodnoty;
        private System.Windows.Forms.Panel panelGraf;

        #endregion
    }
}