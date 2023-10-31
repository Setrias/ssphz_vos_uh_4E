namespace ctverec_class
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDelkaStrany = new System.Windows.Forms.TextBox();
            this.buttonVypocitat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxObvod = new System.Windows.Forms.TextBox();
            this.textBoxObsah = new System.Windows.Forms.TextBox();
            this.textBoxUhlopricka = new System.Windows.Forms.TextBox();
            this.textBoxKrOpsana = new System.Windows.Forms.TextBox();
            this.textBoxKrVepsana = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Délka strany:";
            // 
            // textBoxDelkaStrany
            // 
            this.textBoxDelkaStrany.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDelkaStrany.Location = new System.Drawing.Point(92, 55);
            this.textBoxDelkaStrany.Name = "textBoxDelkaStrany";
            this.textBoxDelkaStrany.Size = new System.Drawing.Size(127, 23);
            this.textBoxDelkaStrany.TabIndex = 1;
            // 
            // buttonVypocitat
            // 
            this.buttonVypocitat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVypocitat.Location = new System.Drawing.Point(12, 84);
            this.buttonVypocitat.Name = "buttonVypocitat";
            this.buttonVypocitat.Size = new System.Drawing.Size(207, 35);
            this.buttonVypocitat.TabIndex = 2;
            this.buttonVypocitat.Text = "Vypočítat";
            this.buttonVypocitat.UseVisualStyleBackColor = true;
            this.buttonVypocitat.Click += new System.EventHandler(this.buttonVypocitat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Obvod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Obsah:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Úhlopříčka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kružnice opsaná:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kružnice vepsaná:";
            // 
            // textBoxObvod
            // 
            this.textBoxObvod.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxObvod.Location = new System.Drawing.Point(119, 140);
            this.textBoxObvod.Name = "textBoxObvod";
            this.textBoxObvod.Size = new System.Drawing.Size(100, 23);
            this.textBoxObvod.TabIndex = 8;
            // 
            // textBoxObsah
            // 
            this.textBoxObsah.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxObsah.Location = new System.Drawing.Point(119, 169);
            this.textBoxObsah.Name = "textBoxObsah";
            this.textBoxObsah.Size = new System.Drawing.Size(100, 23);
            this.textBoxObsah.TabIndex = 9;
            // 
            // textBoxUhlopricka
            // 
            this.textBoxUhlopricka.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUhlopricka.Location = new System.Drawing.Point(119, 198);
            this.textBoxUhlopricka.Name = "textBoxUhlopricka";
            this.textBoxUhlopricka.Size = new System.Drawing.Size(100, 23);
            this.textBoxUhlopricka.TabIndex = 10;
            // 
            // textBoxKrOpsana
            // 
            this.textBoxKrOpsana.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKrOpsana.Location = new System.Drawing.Point(119, 227);
            this.textBoxKrOpsana.Name = "textBoxKrOpsana";
            this.textBoxKrOpsana.Size = new System.Drawing.Size(100, 23);
            this.textBoxKrOpsana.TabIndex = 11;
            // 
            // textBoxKrVepsana
            // 
            this.textBoxKrVepsana.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKrVepsana.Location = new System.Drawing.Point(119, 256);
            this.textBoxKrVepsana.Name = "textBoxKrVepsana";
            this.textBoxKrVepsana.Size = new System.Drawing.Size(100, 23);
            this.textBoxKrVepsana.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Čtverec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 291);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKrVepsana);
            this.Controls.Add(this.textBoxKrOpsana);
            this.Controls.Add(this.textBoxUhlopricka);
            this.Controls.Add(this.textBoxObsah);
            this.Controls.Add(this.textBoxObvod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonVypocitat);
            this.Controls.Add(this.textBoxDelkaStrany);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Čtverec";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxObvod;
        private System.Windows.Forms.TextBox textBoxObsah;
        private System.Windows.Forms.TextBox textBoxUhlopricka;
        private System.Windows.Forms.TextBox textBoxKrOpsana;
        private System.Windows.Forms.TextBox textBoxKrVepsana;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button buttonVypocitat;

        private System.Windows.Forms.TextBox textBoxDelkaStrany;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}