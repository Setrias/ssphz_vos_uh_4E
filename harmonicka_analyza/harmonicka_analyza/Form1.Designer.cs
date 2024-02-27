namespace harmonicka_analyza
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
            this.buttonVypocitat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxA0 = new System.Windows.Forms.TextBox();
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxA3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxA4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxB1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxB2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxB3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxB4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelHarmonicka = new System.Windows.Forms.Panel();
            this.listBoxHodnoty = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonVypocitat
            // 
            this.buttonVypocitat.Location = new System.Drawing.Point(12, 46);
            this.buttonVypocitat.Name = "buttonVypocitat";
            this.buttonVypocitat.Size = new System.Drawing.Size(159, 38);
            this.buttonVypocitat.TabIndex = 1;
            this.buttonVypocitat.Text = "Vypočítat a nakreslit";
            this.buttonVypocitat.UseVisualStyleBackColor = true;
            this.buttonVypocitat.Click += new System.EventHandler(this.buttonVypocitat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Harmonická analýza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "a0:";
            // 
            // textBoxA0
            // 
            this.textBoxA0.Location = new System.Drawing.Point(61, 99);
            this.textBoxA0.Name = "textBoxA0";
            this.textBoxA0.ReadOnly = true;
            this.textBoxA0.Size = new System.Drawing.Size(110, 23);
            this.textBoxA0.TabIndex = 3;
            // 
            // textBoxA1
            // 
            this.textBoxA1.Location = new System.Drawing.Point(61, 128);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.ReadOnly = true;
            this.textBoxA1.Size = new System.Drawing.Size(110, 23);
            this.textBoxA1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "a1:";
            // 
            // textBoxA2
            // 
            this.textBoxA2.Location = new System.Drawing.Point(61, 157);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.ReadOnly = true;
            this.textBoxA2.Size = new System.Drawing.Size(110, 23);
            this.textBoxA2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "a2:";
            // 
            // textBoxA3
            // 
            this.textBoxA3.Location = new System.Drawing.Point(61, 186);
            this.textBoxA3.Name = "textBoxA3";
            this.textBoxA3.ReadOnly = true;
            this.textBoxA3.Size = new System.Drawing.Size(110, 23);
            this.textBoxA3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "a3:";
            // 
            // textBoxA4
            // 
            this.textBoxA4.Location = new System.Drawing.Point(61, 215);
            this.textBoxA4.Name = "textBoxA4";
            this.textBoxA4.ReadOnly = true;
            this.textBoxA4.Size = new System.Drawing.Size(110, 23);
            this.textBoxA4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "a4:";
            // 
            // textBoxB1
            // 
            this.textBoxB1.Location = new System.Drawing.Point(61, 260);
            this.textBoxB1.Name = "textBoxB1";
            this.textBoxB1.ReadOnly = true;
            this.textBoxB1.Size = new System.Drawing.Size(110, 23);
            this.textBoxB1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "b1:";
            // 
            // textBoxB2
            // 
            this.textBoxB2.Location = new System.Drawing.Point(61, 289);
            this.textBoxB2.Name = "textBoxB2";
            this.textBoxB2.ReadOnly = true;
            this.textBoxB2.Size = new System.Drawing.Size(110, 23);
            this.textBoxB2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "b2:";
            // 
            // textBoxB3
            // 
            this.textBoxB3.Location = new System.Drawing.Point(61, 318);
            this.textBoxB3.Name = "textBoxB3";
            this.textBoxB3.ReadOnly = true;
            this.textBoxB3.Size = new System.Drawing.Size(110, 23);
            this.textBoxB3.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "b3:";
            // 
            // textBoxB4
            // 
            this.textBoxB4.Location = new System.Drawing.Point(61, 347);
            this.textBoxB4.Name = "textBoxB4";
            this.textBoxB4.ReadOnly = true;
            this.textBoxB4.Size = new System.Drawing.Size(110, 23);
            this.textBoxB4.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "b4:";
            // 
            // panelHarmonicka
            // 
            this.panelHarmonicka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHarmonicka.Location = new System.Drawing.Point(189, 12);
            this.panelHarmonicka.Name = "panelHarmonicka";
            this.panelHarmonicka.Size = new System.Drawing.Size(573, 357);
            this.panelHarmonicka.TabIndex = 20;
            this.panelHarmonicka.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHarmonicka_Paint);
            // 
            // listBoxHodnoty
            // 
            this.listBoxHodnoty.FormattingEnabled = true;
            this.listBoxHodnoty.ItemHeight = 16;
            this.listBoxHodnoty.Location = new System.Drawing.Point(779, 12);
            this.listBoxHodnoty.Name = "listBoxHodnoty";
            this.listBoxHodnoty.Size = new System.Drawing.Size(171, 356);
            this.listBoxHodnoty.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 382);
            this.Controls.Add(this.listBoxHodnoty);
            this.Controls.Add(this.panelHarmonicka);
            this.Controls.Add(this.textBoxB4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxB3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxB2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxB1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxA4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxA3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxA2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxA1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxA0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonVypocitat);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Harmonická analýza";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox listBoxHodnoty;

        private System.Windows.Forms.Panel panelHarmonicka;

        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxA3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxA4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxB1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxB2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxB3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxB4;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxA0;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button buttonVypocitat;

        #endregion
    }
}