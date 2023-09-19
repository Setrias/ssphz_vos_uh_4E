namespace Buchtík_2023_09_19_test
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
            this.textBoxTepVzduch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTepVoda = new System.Windows.Forms.TextBox();
            this.textBoxTlak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonZapis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTepVzduch
            // 
            this.textBoxTepVzduch.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTepVzduch.Location = new System.Drawing.Point(109, 59);
            this.textBoxTepVzduch.Name = "textBoxTepVzduch";
            this.textBoxTepVzduch.Size = new System.Drawing.Size(100, 23);
            this.textBoxTepVzduch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teplota vody:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teplota vzduchu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tlak:";
            // 
            // textBoxTepVoda
            // 
            this.textBoxTepVoda.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTepVoda.Location = new System.Drawing.Point(109, 88);
            this.textBoxTepVoda.Name = "textBoxTepVoda";
            this.textBoxTepVoda.Size = new System.Drawing.Size(100, 23);
            this.textBoxTepVoda.TabIndex = 4;
            // 
            // textBoxTlak
            // 
            this.textBoxTlak.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTlak.Location = new System.Drawing.Point(109, 117);
            this.textBoxTlak.Name = "textBoxTlak";
            this.textBoxTlak.Size = new System.Drawing.Size(100, 23);
            this.textBoxTlak.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teplota vzduchu:";
            // 
            // buttonZapis
            // 
            this.buttonZapis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZapis.Location = new System.Drawing.Point(12, 149);
            this.buttonZapis.Name = "buttonZapis";
            this.buttonZapis.Size = new System.Drawing.Size(197, 38);
            this.buttonZapis.TabIndex = 7;
            this.buttonZapis.Text = "Zapsat záznamy";
            this.buttonZapis.UseVisualStyleBackColor = true;
            this.buttonZapis.Click += new System.EventHandler(this.buttonZapis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZapis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTlak);
            this.Controls.Add(this.textBoxTepVoda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTepVzduch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonZapis;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTepVoda;
        private System.Windows.Forms.TextBox textBoxTlak;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBoxTepVzduch;

        #endregion
    }
}