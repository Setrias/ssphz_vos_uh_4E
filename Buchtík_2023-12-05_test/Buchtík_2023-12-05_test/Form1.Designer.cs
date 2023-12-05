namespace Buchtík_2023_12_05_test
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
            this.panelGraf = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmplituda = new System.Windows.Forms.TextBox();
            this.textBoxPerioda = new System.Windows.Forms.TextBox();
            this.buttonVykreslit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelGraf
            // 
            this.panelGraf.Location = new System.Drawing.Point(186, 34);
            this.panelGraf.Name = "panelGraf";
            this.panelGraf.Size = new System.Drawing.Size(602, 379);
            this.panelGraf.TabIndex = 0;
            this.panelGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraf_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amplituda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Perioda:";
            // 
            // textBoxAmplituda
            // 
            this.textBoxAmplituda.Location = new System.Drawing.Point(80, 34);
            this.textBoxAmplituda.Name = "textBoxAmplituda";
            this.textBoxAmplituda.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmplituda.TabIndex = 3;
            // 
            // textBoxPerioda
            // 
            this.textBoxPerioda.Location = new System.Drawing.Point(80, 63);
            this.textBoxPerioda.Name = "textBoxPerioda";
            this.textBoxPerioda.Size = new System.Drawing.Size(100, 23);
            this.textBoxPerioda.TabIndex = 4;
            // 
            // buttonVykreslit
            // 
            this.buttonVykreslit.Location = new System.Drawing.Point(12, 92);
            this.buttonVykreslit.Name = "buttonVykreslit";
            this.buttonVykreslit.Size = new System.Drawing.Size(168, 48);
            this.buttonVykreslit.TabIndex = 5;
            this.buttonVykreslit.Text = "Vykreslit";
            this.buttonVykreslit.UseVisualStyleBackColor = true;
            this.buttonVykreslit.Click += new System.EventHandler(this.buttonVykreslit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.buttonVykreslit);
            this.Controls.Add(this.textBoxPerioda);
            this.Controls.Add(this.textBoxAmplituda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelGraf);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Cos funkce";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelGraf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmplituda;
        private System.Windows.Forms.TextBox textBoxPerioda;
        private System.Windows.Forms.Button buttonVykreslit;

        #endregion
    }
}