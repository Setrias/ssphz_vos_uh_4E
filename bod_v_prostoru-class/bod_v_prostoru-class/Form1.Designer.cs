namespace bod_v_prostoru_class
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
            this.textBoxCisloRe = new System.Windows.Forms.TextBox();
            this.textBoxCisloIm = new System.Windows.Forms.TextBox();
            this.buttonUloz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVypisRe = new System.Windows.Forms.TextBox();
            this.textBoxVypisIm = new System.Windows.Forms.TextBox();
            this.textBoxVypisAbs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxVzdalenostOdPocatku = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonBod3D = new System.Windows.Forms.Button();
            this.textBoxSourY = new System.Windows.Forms.TextBox();
            this.textBoxSourX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSourZ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCisloRe
            // 
            this.textBoxCisloRe.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCisloRe.Location = new System.Drawing.Point(80, 56);
            this.textBoxCisloRe.Name = "textBoxCisloRe";
            this.textBoxCisloRe.Size = new System.Drawing.Size(120, 23);
            this.textBoxCisloRe.TabIndex = 0;
            // 
            // textBoxCisloIm
            // 
            this.textBoxCisloIm.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCisloIm.Location = new System.Drawing.Point(80, 85);
            this.textBoxCisloIm.Name = "textBoxCisloIm";
            this.textBoxCisloIm.Size = new System.Drawing.Size(120, 23);
            this.textBoxCisloIm.TabIndex = 1;
            // 
            // buttonUloz
            // 
            this.buttonUloz.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUloz.Location = new System.Drawing.Point(206, 56);
            this.buttonUloz.Name = "buttonUloz";
            this.buttonUloz.Size = new System.Drawing.Size(75, 52);
            this.buttonUloz.TabIndex = 2;
            this.buttonUloz.Text = "Ulož čísla";
            this.buttonUloz.UseVisualStyleBackColor = true;
            this.buttonUloz.Click += new System.EventHandler(this.buttonUloz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bod v prostoru, třídy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Realne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Imaginární";
            // 
            // textBoxVypisRe
            // 
            this.textBoxVypisRe.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVypisRe.Location = new System.Drawing.Point(119, 128);
            this.textBoxVypisRe.Name = "textBoxVypisRe";
            this.textBoxVypisRe.ReadOnly = true;
            this.textBoxVypisRe.Size = new System.Drawing.Size(120, 23);
            this.textBoxVypisRe.TabIndex = 6;
            // 
            // textBoxVypisIm
            // 
            this.textBoxVypisIm.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVypisIm.Location = new System.Drawing.Point(119, 157);
            this.textBoxVypisIm.Name = "textBoxVypisIm";
            this.textBoxVypisIm.ReadOnly = true;
            this.textBoxVypisIm.Size = new System.Drawing.Size(120, 23);
            this.textBoxVypisIm.TabIndex = 7;
            // 
            // textBoxVypisAbs
            // 
            this.textBoxVypisAbs.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVypisAbs.Location = new System.Drawing.Point(119, 186);
            this.textBoxVypisAbs.Name = "textBoxVypisAbs";
            this.textBoxVypisAbs.ReadOnly = true;
            this.textBoxVypisAbs.Size = new System.Drawing.Size(120, 23);
            this.textBoxVypisAbs.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Realne:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Imaginární:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Absolutní hodnota:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Class Bod3D";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Vzdálenost od počátečního bodu:";
            // 
            // textBoxVzdalenostOdPocatku
            // 
            this.textBoxVzdalenostOdPocatku.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVzdalenostOdPocatku.Location = new System.Drawing.Point(190, 367);
            this.textBoxVzdalenostOdPocatku.Name = "textBoxVzdalenostOdPocatku";
            this.textBoxVzdalenostOdPocatku.ReadOnly = true;
            this.textBoxVzdalenostOdPocatku.Size = new System.Drawing.Size(120, 23);
            this.textBoxVzdalenostOdPocatku.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "X:";
            // 
            // buttonBod3D
            // 
            this.buttonBod3D.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBod3D.Location = new System.Drawing.Point(161, 276);
            this.buttonBod3D.Name = "buttonBod3D";
            this.buttonBod3D.Size = new System.Drawing.Size(100, 81);
            this.buttonBod3D.TabIndex = 17;
            this.buttonBod3D.Text = "Ulož souřadnice";
            this.buttonBod3D.UseVisualStyleBackColor = true;
            this.buttonBod3D.Click += new System.EventHandler(this.buttonBod3D_Click);
            // 
            // textBoxSourY
            // 
            this.textBoxSourY.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSourY.Location = new System.Drawing.Point(35, 305);
            this.textBoxSourY.Name = "textBoxSourY";
            this.textBoxSourY.Size = new System.Drawing.Size(120, 23);
            this.textBoxSourY.TabIndex = 16;
            // 
            // textBoxSourX
            // 
            this.textBoxSourX.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSourX.Location = new System.Drawing.Point(35, 276);
            this.textBoxSourX.Name = "textBoxSourX";
            this.textBoxSourX.Size = new System.Drawing.Size(120, 23);
            this.textBoxSourX.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Z:";
            // 
            // textBoxSourZ
            // 
            this.textBoxSourZ.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSourZ.Location = new System.Drawing.Point(35, 334);
            this.textBoxSourZ.Name = "textBoxSourZ";
            this.textBoxSourZ.Size = new System.Drawing.Size(120, 23);
            this.textBoxSourZ.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 493);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxSourZ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonBod3D);
            this.Controls.Add(this.textBoxSourY);
            this.Controls.Add(this.textBoxSourX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxVzdalenostOdPocatku);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVypisAbs);
            this.Controls.Add(this.textBoxVypisIm);
            this.Controls.Add(this.textBoxVypisRe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUloz);
            this.Controls.Add(this.textBoxCisloIm);
            this.Controls.Add(this.textBoxCisloRe);
            this.Name = "Form1";
            this.Text = "Bod v prostoru";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonBod3D;
        private System.Windows.Forms.TextBox textBoxSourY;
        private System.Windows.Forms.TextBox textBoxSourX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSourZ;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxVzdalenostOdPocatku;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox textBoxVypisIm;
        private System.Windows.Forms.TextBox textBoxVypisAbs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVypisRe;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBoxCisloIm;
        private System.Windows.Forms.Button buttonUloz;

        private System.Windows.Forms.TextBox textBoxCisloRe;

        #endregion
    }
}