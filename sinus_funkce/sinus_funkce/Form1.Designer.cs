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
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amplituda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Perioda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fí [rad]:";
            // 
            // textBoxAmplituda
            // 
            this.textBoxAmplituda.Location = new System.Drawing.Point(80, 25);
            this.textBoxAmplituda.Name = "textBoxAmplituda";
            this.textBoxAmplituda.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmplituda.TabIndex = 4;
            // 
            // textBoxPerioda
            // 
            this.textBoxPerioda.Location = new System.Drawing.Point(80, 54);
            this.textBoxPerioda.Name = "textBoxPerioda";
            this.textBoxPerioda.Size = new System.Drawing.Size(100, 23);
            this.textBoxPerioda.TabIndex = 5;
            // 
            // textBoxFi
            // 
            this.textBoxFi.Location = new System.Drawing.Point(80, 83);
            this.textBoxFi.Name = "textBoxFi";
            this.textBoxFi.Size = new System.Drawing.Size(100, 23);
            this.textBoxFi.TabIndex = 6;
            // 
            // buttonVykreslit
            // 
            this.buttonVykreslit.Location = new System.Drawing.Point(186, 25);
            this.buttonVykreslit.Name = "buttonVykreslit";
            this.buttonVykreslit.Size = new System.Drawing.Size(92, 81);
            this.buttonVykreslit.TabIndex = 7;
            this.buttonVykreslit.Text = "Vykreslit";
            this.buttonVykreslit.UseVisualStyleBackColor = true;
            this.buttonVykreslit.Click += new System.EventHandler(this.buttonVykreslit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 605);
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