namespace ukladani_cisel
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
            this.textBoxZadavani = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZadej = new System.Windows.Forms.Button();
            this.listBoxSude = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaxLiche = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVetsiSto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMinKladne = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxZadavani
            // 
            this.textBoxZadavani.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZadavani.Location = new System.Drawing.Point(192, 12);
            this.textBoxZadavani.Name = "textBoxZadavani";
            this.textBoxZadavani.Size = new System.Drawing.Size(100, 23);
            this.textBoxZadavani.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zadej číslo nebo \'x\' pro ukončení:";
            // 
            // buttonZadej
            // 
            this.buttonZadej.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZadej.Location = new System.Drawing.Point(298, 12);
            this.buttonZadej.Name = "buttonZadej";
            this.buttonZadej.Size = new System.Drawing.Size(75, 23);
            this.buttonZadej.TabIndex = 2;
            this.buttonZadej.Text = "Zadej číslo";
            this.buttonZadej.UseVisualStyleBackColor = true;
            this.buttonZadej.Click += new System.EventHandler(this.buttonZadej_Click);
            // 
            // listBoxSude
            // 
            this.listBoxSude.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSude.FormattingEnabled = true;
            this.listBoxSude.ItemHeight = 16;
            this.listBoxSude.Location = new System.Drawing.Point(12, 72);
            this.listBoxSude.Name = "listBoxSude";
            this.listBoxSude.Size = new System.Drawing.Size(96, 260);
            this.listBoxSude.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sudá čísla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Největší číslo z lichých čísel:";
            // 
            // textBoxMaxLiche
            // 
            this.textBoxMaxLiche.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxLiche.Location = new System.Drawing.Point(273, 79);
            this.textBoxMaxLiche.Name = "textBoxMaxLiche";
            this.textBoxMaxLiche.ReadOnly = true;
            this.textBoxMaxLiche.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaxLiche.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Počet čísel větších než 100:";
            // 
            // textBoxVetsiSto
            // 
            this.textBoxVetsiSto.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVetsiSto.Location = new System.Drawing.Point(273, 108);
            this.textBoxVetsiSto.Name = "textBoxVetsiSto";
            this.textBoxVetsiSto.ReadOnly = true;
            this.textBoxVetsiSto.Size = new System.Drawing.Size(100, 23);
            this.textBoxVetsiSto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nejmenší kladné číslo:";
            // 
            // textBoxMinKladne
            // 
            this.textBoxMinKladne.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMinKladne.Location = new System.Drawing.Point(273, 137);
            this.textBoxMinKladne.Name = "textBoxMinKladne";
            this.textBoxMinKladne.ReadOnly = true;
            this.textBoxMinKladne.Size = new System.Drawing.Size(100, 23);
            this.textBoxMinKladne.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 345);
            this.Controls.Add(this.textBoxMinKladne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxVetsiSto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMaxLiche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxSude);
            this.Controls.Add(this.buttonZadej);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxZadavani);
            this.Name = "Form1";
            this.Text = "Ukládání čísel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMinKladne;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVetsiSto;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaxLiche;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ListBox listBoxSude;

        private System.Windows.Forms.Button buttonZadej;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBoxZadavani;

        #endregion
    }
}