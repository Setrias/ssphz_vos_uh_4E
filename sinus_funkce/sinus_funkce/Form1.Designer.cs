namespace sinus_funkce
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
            this.panelSinus = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAmplituda = new System.Windows.Forms.TextBox();
            this.textBoxPerioda = new System.Windows.Forms.TextBox();
            this.textBoxFi = new System.Windows.Forms.TextBox();
            this.buttonVykreslit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonVykreslitDruhou = new System.Windows.Forms.Button();
            this.textBoxFiDruhe = new System.Windows.Forms.TextBox();
            this.textBoxPeriodaDruha = new System.Windows.Forms.TextBox();
            this.textBoxAmplitudaDruha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelSinus
            // 
            this.panelSinus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSinus.Location = new System.Drawing.Point(12, 193);
            this.panelSinus.Name = "panelSinus";
            this.panelSinus.Size = new System.Drawing.Size(600, 400);
            this.panelSinus.TabIndex = 0;
            this.panelSinus.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSinus_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amplituda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Perioda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fí [rad]:";
            // 
            // textBoxAmplituda
            // 
            this.textBoxAmplituda.Location = new System.Drawing.Point(80, 49);
            this.textBoxAmplituda.Name = "textBoxAmplituda";
            this.textBoxAmplituda.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmplituda.TabIndex = 4;
            // 
            // textBoxPerioda
            // 
            this.textBoxPerioda.Location = new System.Drawing.Point(80, 78);
            this.textBoxPerioda.Name = "textBoxPerioda";
            this.textBoxPerioda.Size = new System.Drawing.Size(100, 23);
            this.textBoxPerioda.TabIndex = 5;
            // 
            // textBoxFi
            // 
            this.textBoxFi.Location = new System.Drawing.Point(80, 107);
            this.textBoxFi.Name = "textBoxFi";
            this.textBoxFi.Size = new System.Drawing.Size(100, 23);
            this.textBoxFi.TabIndex = 6;
            // 
            // buttonVykreslit
            // 
            this.buttonVykreslit.Location = new System.Drawing.Point(186, 49);
            this.buttonVykreslit.Name = "buttonVykreslit";
            this.buttonVykreslit.Size = new System.Drawing.Size(92, 81);
            this.buttonVykreslit.TabIndex = 7;
            this.buttonVykreslit.Text = "Vykreslit";
            this.buttonVykreslit.UseVisualStyleBackColor = true;
            this.buttonVykreslit.Click += new System.EventHandler(this.buttonVykreslit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "První sinusovka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(311, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Druhá sinusovka";
            // 
            // buttonVykreslitDruhou
            // 
            this.buttonVykreslitDruhou.Location = new System.Drawing.Point(485, 49);
            this.buttonVykreslitDruhou.Name = "buttonVykreslitDruhou";
            this.buttonVykreslitDruhou.Size = new System.Drawing.Size(92, 81);
            this.buttonVykreslitDruhou.TabIndex = 15;
            this.buttonVykreslitDruhou.Text = "Vykreslit";
            this.buttonVykreslitDruhou.UseVisualStyleBackColor = true;
            this.buttonVykreslitDruhou.Click += new System.EventHandler(this.buttonVykreslitDruhou_Click);
            // 
            // textBoxFiDruhe
            // 
            this.textBoxFiDruhe.Location = new System.Drawing.Point(379, 107);
            this.textBoxFiDruhe.Name = "textBoxFiDruhe";
            this.textBoxFiDruhe.Size = new System.Drawing.Size(100, 23);
            this.textBoxFiDruhe.TabIndex = 14;
            // 
            // textBoxPeriodaDruha
            // 
            this.textBoxPeriodaDruha.Location = new System.Drawing.Point(379, 78);
            this.textBoxPeriodaDruha.Name = "textBoxPeriodaDruha";
            this.textBoxPeriodaDruha.Size = new System.Drawing.Size(100, 23);
            this.textBoxPeriodaDruha.TabIndex = 13;
            // 
            // textBoxAmplitudaDruha
            // 
            this.textBoxAmplitudaDruha.Location = new System.Drawing.Point(379, 49);
            this.textBoxAmplitudaDruha.Name = "textBoxAmplitudaDruha";
            this.textBoxAmplitudaDruha.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmplitudaDruha.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fí [rad]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Perioda:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Amplituda:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Součet sinusovek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 605);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonVykreslitDruhou);
            this.Controls.Add(this.textBoxFiDruhe);
            this.Controls.Add(this.textBoxPeriodaDruha);
            this.Controls.Add(this.textBoxAmplitudaDruha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonVykreslit);
            this.Controls.Add(this.textBoxFi);
            this.Controls.Add(this.textBoxPerioda);
            this.Controls.Add(this.textBoxAmplituda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSinus);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Sinus funkce";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonVykreslitDruhou;
        private System.Windows.Forms.TextBox textBoxFiDruhe;
        private System.Windows.Forms.TextBox textBoxPeriodaDruha;
        private System.Windows.Forms.TextBox textBoxAmplitudaDruha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button buttonVykreslit;

        private System.Windows.Forms.Panel panelSinus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAmplituda;
        private System.Windows.Forms.TextBox textBoxPerioda;
        private System.Windows.Forms.TextBox textBoxFi;

        #endregion
    }
}