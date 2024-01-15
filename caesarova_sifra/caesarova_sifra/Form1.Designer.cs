namespace caesarova_sifra
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
            this.textBoxSlova = new System.Windows.Forms.TextBox();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPosun = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosun)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSlova
            // 
            this.textBoxSlova.Location = new System.Drawing.Point(58, 48);
            this.textBoxSlova.Name = "textBoxSlova";
            this.textBoxSlova.Size = new System.Drawing.Size(191, 23);
            this.textBoxSlova.TabIndex = 0;
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(58, 77);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(191, 23);
            this.textBoxSifra.TabIndex = 1;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(255, 77);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(100, 23);
            this.buttonDecode.TabIndex = 2;
            this.buttonDecode.Text = "Dekódovat";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(255, 48);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(100, 23);
            this.buttonEncode.TabIndex = 3;
            this.buttonEncode.Text = "Zakódovat";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Šifra:";
            // 
            // numericUpDownPosun
            // 
            this.numericUpDownPosun.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownPosun.Location = new System.Drawing.Point(58, 15);
            this.numericUpDownPosun.Name = "numericUpDownPosun";
            this.numericUpDownPosun.Size = new System.Drawing.Size(100, 27);
            this.numericUpDownPosun.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Posun:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 115);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownPosun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.textBoxSifra);
            this.Controls.Add(this.textBoxSlova);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Caesarova Šifra";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.NumericUpDown numericUpDownPosun;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.Button buttonEncode;

        private System.Windows.Forms.TextBox textBoxSlova;

        #endregion
    }
}