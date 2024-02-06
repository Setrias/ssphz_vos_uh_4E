namespace slunecni_soustava
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
            this.textBoxNazevPlanety = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxObeznaDoba = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonZadat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVzdalenostAu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxVzdalenostKm = new System.Windows.Forms.TextBox();
            this.textBoxPrumernaRychlost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonVymaz = new System.Windows.Forms.Button();
            this.listBoxTelesa = new System.Windows.Forms.ListBox();
            this.buttonVypisSouboru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNazevPlanety
            // 
            this.textBoxNazevPlanety.Location = new System.Drawing.Point(192, 48);
            this.textBoxNazevPlanety.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNazevPlanety.Name = "textBoxNazevPlanety";
            this.textBoxNazevPlanety.Size = new System.Drawing.Size(100, 23);
            this.textBoxNazevPlanety.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oběžná doba [roky]:";
            // 
            // textBoxObeznaDoba
            // 
            this.textBoxObeznaDoba.Location = new System.Drawing.Point(192, 79);
            this.textBoxObeznaDoba.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxObeznaDoba.Name = "textBoxObeznaDoba";
            this.textBoxObeznaDoba.Size = new System.Drawing.Size(100, 23);
            this.textBoxObeznaDoba.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Název planety:";
            // 
            // buttonZadat
            // 
            this.buttonZadat.Location = new System.Drawing.Point(12, 109);
            this.buttonZadat.Name = "buttonZadat";
            this.buttonZadat.Size = new System.Drawing.Size(280, 32);
            this.buttonZadat.TabIndex = 4;
            this.buttonZadat.Text = "Zadat";
            this.buttonZadat.UseVisualStyleBackColor = true;
            this.buttonZadat.Click += new System.EventHandler(this.buttonZadat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sluneční soustava";
            // 
            // textBoxVzdalenostAu
            // 
            this.textBoxVzdalenostAu.Location = new System.Drawing.Point(192, 147);
            this.textBoxVzdalenostAu.Name = "textBoxVzdalenostAu";
            this.textBoxVzdalenostAu.Size = new System.Drawing.Size(100, 23);
            this.textBoxVzdalenostAu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vzdálenost tělesa od slunce [AU]:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vzdálenost tělesa od slunce [km]:";
            // 
            // textBoxVzdalenostKm
            // 
            this.textBoxVzdalenostKm.Location = new System.Drawing.Point(192, 176);
            this.textBoxVzdalenostKm.Name = "textBoxVzdalenostKm";
            this.textBoxVzdalenostKm.Size = new System.Drawing.Size(100, 23);
            this.textBoxVzdalenostKm.TabIndex = 9;
            // 
            // textBoxPrumernaRychlost
            // 
            this.textBoxPrumernaRychlost.Location = new System.Drawing.Point(192, 205);
            this.textBoxPrumernaRychlost.Name = "textBoxPrumernaRychlost";
            this.textBoxPrumernaRychlost.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrumernaRychlost.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Průměrná rychlost tělese [kms-]:";
            // 
            // buttonVymaz
            // 
            this.buttonVymaz.Location = new System.Drawing.Point(12, 234);
            this.buttonVymaz.Name = "buttonVymaz";
            this.buttonVymaz.Size = new System.Drawing.Size(280, 32);
            this.buttonVymaz.TabIndex = 12;
            this.buttonVymaz.Text = "Vymaž";
            this.buttonVymaz.UseVisualStyleBackColor = true;
            this.buttonVymaz.Click += new System.EventHandler(this.buttonVymaz_Click);
            // 
            // listBoxTelesa
            // 
            this.listBoxTelesa.FormattingEnabled = true;
            this.listBoxTelesa.ItemHeight = 16;
            this.listBoxTelesa.Location = new System.Drawing.Point(298, 48);
            this.listBoxTelesa.Name = "listBoxTelesa";
            this.listBoxTelesa.Size = new System.Drawing.Size(575, 180);
            this.listBoxTelesa.TabIndex = 13;
            // 
            // buttonVypisSouboru
            // 
            this.buttonVypisSouboru.Location = new System.Drawing.Point(298, 234);
            this.buttonVypisSouboru.Name = "buttonVypisSouboru";
            this.buttonVypisSouboru.Size = new System.Drawing.Size(575, 32);
            this.buttonVypisSouboru.TabIndex = 14;
            this.buttonVypisSouboru.Text = "Vypiš obsah souboru";
            this.buttonVypisSouboru.UseVisualStyleBackColor = true;
            this.buttonVypisSouboru.Click += new System.EventHandler(this.buttonVypisSouboru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 277);
            this.Controls.Add(this.buttonVypisSouboru);
            this.Controls.Add(this.listBoxTelesa);
            this.Controls.Add(this.buttonVymaz);
            this.Controls.Add(this.textBoxPrumernaRychlost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxVzdalenostKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVzdalenostAu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonZadat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxObeznaDoba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNazevPlanety);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonVypisSouboru;

        private System.Windows.Forms.ListBox listBoxTelesa;

        private System.Windows.Forms.Button buttonVymaz;

        private System.Windows.Forms.TextBox textBoxPrumernaRychlost;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxVzdalenostKm;

        private System.Windows.Forms.TextBox textBoxVzdalenostAu;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonZadat;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBoxObeznaDoba;

        private System.Windows.Forms.TextBox textBoxNazevPlanety;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}