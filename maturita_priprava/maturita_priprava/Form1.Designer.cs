namespace maturita_priprava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGraf = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCelkovyPrumer = new System.Windows.Forms.TextBox();
            this.textBoxPrumer = new System.Windows.Forms.TextBox();
            this.buttonZapsat = new System.Windows.Forms.Button();
            this.listBoxHodnoty = new System.Windows.Forms.ListBox();
            this.buttonPrecist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Location = new System.Drawing.Point(63, 67);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(102, 23);
            this.textBoxJmeno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jméno:";
            // 
            // panelGraf
            // 
            this.panelGraf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraf.Location = new System.Drawing.Point(12, 104);
            this.panelGraf.Name = "panelGraf";
            this.panelGraf.Size = new System.Drawing.Size(600, 400);
            this.panelGraf.TabIndex = 2;
            this.panelGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraf_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(883, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Celkový průměr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Průměr měření 10 až 20:";
            // 
            // textBoxCelkovyPrumer
            // 
            this.textBoxCelkovyPrumer.Location = new System.Drawing.Point(150, 516);
            this.textBoxCelkovyPrumer.Name = "textBoxCelkovyPrumer";
            this.textBoxCelkovyPrumer.Size = new System.Drawing.Size(100, 23);
            this.textBoxCelkovyPrumer.TabIndex = 6;
            // 
            // textBoxPrumer
            // 
            this.textBoxPrumer.Location = new System.Drawing.Point(150, 545);
            this.textBoxPrumer.Name = "textBoxPrumer";
            this.textBoxPrumer.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrumer.TabIndex = 7;
            // 
            // buttonZapsat
            // 
            this.buttonZapsat.Location = new System.Drawing.Point(171, 59);
            this.buttonZapsat.Name = "buttonZapsat";
            this.buttonZapsat.Size = new System.Drawing.Size(110, 39);
            this.buttonZapsat.TabIndex = 8;
            this.buttonZapsat.Text = "Zapsat";
            this.buttonZapsat.UseVisualStyleBackColor = true;
            this.buttonZapsat.Click += new System.EventHandler(this.buttonZapsat_Click);
            // 
            // listBoxHodnoty
            // 
            this.listBoxHodnoty.FormattingEnabled = true;
            this.listBoxHodnoty.ItemHeight = 16;
            this.listBoxHodnoty.Location = new System.Drawing.Point(618, 104);
            this.listBoxHodnoty.Name = "listBoxHodnoty";
            this.listBoxHodnoty.Size = new System.Drawing.Size(259, 404);
            this.listBoxHodnoty.TabIndex = 9;
            // 
            // buttonPrecist
            // 
            this.buttonPrecist.Location = new System.Drawing.Point(12, 12);
            this.buttonPrecist.Name = "buttonPrecist";
            this.buttonPrecist.Size = new System.Drawing.Size(493, 39);
            this.buttonPrecist.TabIndex = 10;
            this.buttonPrecist.Text = "Přečíst soubor";
            this.buttonPrecist.UseVisualStyleBackColor = true;
            this.buttonPrecist.Click += new System.EventHandler(this.buttonPrecist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 583);
            this.Controls.Add(this.buttonPrecist);
            this.Controls.Add(this.listBoxHodnoty);
            this.Controls.Add(this.buttonZapsat);
            this.Controls.Add(this.textBoxPrumer);
            this.Controls.Add(this.textBoxCelkovyPrumer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelGraf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJmeno);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Příprava na maturitu 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonPrecist;

        private System.Windows.Forms.ListBox listBoxHodnoty;

        private System.Windows.Forms.Button buttonZapsat;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCelkovyPrumer;
        private System.Windows.Forms.TextBox textBoxPrumer;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel panelGraf;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBoxJmeno;

        #endregion
    }
}