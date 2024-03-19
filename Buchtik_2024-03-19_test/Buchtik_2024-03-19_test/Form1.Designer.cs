namespace Buchtik_2024_03_19_test
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
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFyz = new System.Windows.Forms.TextBox();
            this.buttonUloz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxZakNejBody = new System.Windows.Forms.TextBox();
            this.listBoxVypis = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(100, 49);
            this.textBoxKod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(89, 23);
            this.textBoxKod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kód žáka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bodů z testu:";
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(100, 80);
            this.textBoxTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(89, 23);
            this.textBoxTest.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Známka z MAT:";
            // 
            // textBoxMat
            // 
            this.textBoxMat.Location = new System.Drawing.Point(100, 111);
            this.textBoxMat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMat.Name = "textBoxMat";
            this.textBoxMat.Size = new System.Drawing.Size(89, 23);
            this.textBoxMat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Známka z FYZ:";
            // 
            // textBoxFyz
            // 
            this.textBoxFyz.Location = new System.Drawing.Point(100, 142);
            this.textBoxFyz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFyz.Name = "textBoxFyz";
            this.textBoxFyz.Size = new System.Drawing.Size(89, 23);
            this.textBoxFyz.TabIndex = 6;
            // 
            // buttonUloz
            // 
            this.buttonUloz.Location = new System.Drawing.Point(12, 179);
            this.buttonUloz.Name = "buttonUloz";
            this.buttonUloz.Size = new System.Drawing.Size(376, 33);
            this.buttonUloz.TabIndex = 8;
            this.buttonUloz.Text = "Uložit";
            this.buttonUloz.UseVisualStyleBackColor = true;
            this.buttonUloz.Click += new System.EventHandler(this.buttonUloz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Přijímací řízení na VŠ";
            // 
            // textBoxZakNejBody
            // 
            this.textBoxZakNejBody.Location = new System.Drawing.Point(177, 225);
            this.textBoxZakNejBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxZakNejBody.Name = "textBoxZakNejBody";
            this.textBoxZakNejBody.ReadOnly = true;
            this.textBoxZakNejBody.Size = new System.Drawing.Size(211, 23);
            this.textBoxZakNejBody.TabIndex = 10;
            // 
            // listBoxVypis
            // 
            this.listBoxVypis.FormattingEnabled = true;
            this.listBoxVypis.ItemHeight = 16;
            this.listBoxVypis.Location = new System.Drawing.Point(195, 9);
            this.listBoxVypis.Name = "listBoxVypis";
            this.listBoxVypis.Size = new System.Drawing.Size(193, 164);
            this.listBoxVypis.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Žák s největším počtem bodů:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxVypis);
            this.Controls.Add(this.textBoxZakNejBody);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonUloz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFyz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKod);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Přijímací řízení na VŠ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxKod;

        private System.Windows.Forms.ListBox listBoxVypis;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox textBoxZakNejBody;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFyz;
        private System.Windows.Forms.Button buttonUloz;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}