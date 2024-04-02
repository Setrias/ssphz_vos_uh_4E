namespace Buchtík_2024_04_02_test
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
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.buttonVypocitat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOmega = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOmegaNula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(117, 35);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 23);
            this.textBoxR.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "R [Ohm]:";
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(117, 64);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(100, 23);
            this.textBoxL.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "L [H]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "C [F]:";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(117, 93);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 23);
            this.textBoxC.TabIndex = 4;
            // 
            // buttonVypocitat
            // 
            this.buttonVypocitat.Location = new System.Drawing.Point(12, 122);
            this.buttonVypocitat.Name = "buttonVypocitat";
            this.buttonVypocitat.Size = new System.Drawing.Size(205, 37);
            this.buttonVypocitat.TabIndex = 6;
            this.buttonVypocitat.Text = "Vypočítat";
            this.buttonVypocitat.UseVisualStyleBackColor = true;
            this.buttonVypocitat.Click += new System.EventHandler(this.buttonVypocitat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Úhlová frekvence:";
            // 
            // textBoxOmega
            // 
            this.textBoxOmega.Location = new System.Drawing.Point(117, 165);
            this.textBoxOmega.Name = "textBoxOmega";
            this.textBoxOmega.Size = new System.Drawing.Size(100, 23);
            this.textBoxOmega.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Omega0:";
            // 
            // textBoxOmegaNula
            // 
            this.textBoxOmegaNula.Location = new System.Drawing.Point(117, 194);
            this.textBoxOmegaNula.Name = "textBoxOmegaNula";
            this.textBoxOmegaNula.Size = new System.Drawing.Size(100, 23);
            this.textBoxOmegaNula.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tlumení:";
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(117, 223);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(100, 23);
            this.textBoxDelta.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDelta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOmegaNula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOmega);
            this.Controls.Add(this.buttonVypocitat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxR);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Parametry RLC obvodu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOmegaNula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDelta;

        private System.Windows.Forms.TextBox textBoxOmega;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonVypocitat;

        private System.Windows.Forms.TextBox textBoxR;

        #endregion
    }
}