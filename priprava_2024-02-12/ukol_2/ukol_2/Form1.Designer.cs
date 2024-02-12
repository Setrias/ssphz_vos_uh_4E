namespace ukol_2
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
            this.textBoxVzdalenost = new System.Windows.Forms.TextBox();
            this.panelGraf = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIntenzita = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxEh = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVypocitat
            // 
            this.buttonVypocitat.Location = new System.Drawing.Point(12, 160);
            this.buttonVypocitat.Name = "buttonVypocitat";
            this.buttonVypocitat.Size = new System.Drawing.Size(108, 33);
            this.buttonVypocitat.TabIndex = 0;
            this.buttonVypocitat.Text = "Vypočítat";
            this.buttonVypocitat.UseVisualStyleBackColor = true;
            this.buttonVypocitat.Click += new System.EventHandler(this.buttonVypocitat_Click);
            // 
            // textBoxVzdalenost
            // 
            this.textBoxVzdalenost.Location = new System.Drawing.Point(12, 31);
            this.textBoxVzdalenost.Name = "textBoxVzdalenost";
            this.textBoxVzdalenost.Size = new System.Drawing.Size(108, 23);
            this.textBoxVzdalenost.TabIndex = 1;
            // 
            // panelGraf
            // 
            this.panelGraf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraf.Location = new System.Drawing.Point(126, 12);
            this.panelGraf.Name = "panelGraf";
            this.panelGraf.Size = new System.Drawing.Size(676, 539);
            this.panelGraf.TabIndex = 2;
            this.panelGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraf_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vzdálenost [m]:";
            // 
            // textBoxIntenzita
            // 
            this.textBoxIntenzita.Location = new System.Drawing.Point(12, 131);
            this.textBoxIntenzita.Name = "textBoxIntenzita";
            this.textBoxIntenzita.ReadOnly = true;
            this.textBoxIntenzita.Size = new System.Drawing.Size(108, 23);
            this.textBoxIntenzita.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Intenzita el. pole ve vzdálenosti:";
            // 
            // listBoxEh
            // 
            this.listBoxEh.FormattingEnabled = true;
            this.listBoxEh.ItemHeight = 16;
            this.listBoxEh.Location = new System.Drawing.Point(818, 12);
            this.listBoxEh.Name = "listBoxEh";
            this.listBoxEh.Size = new System.Drawing.Size(245, 564);
            this.listBoxEh.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(116, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(778, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "1 m";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 590);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxEh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIntenzita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelGraf);
            this.Controls.Add(this.textBoxVzdalenost);
            this.Controls.Add(this.buttonVypocitat);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Intenzita elektrického pole";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ListBox listBoxEh;

        private System.Windows.Forms.TextBox textBoxIntenzita;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button buttonVypocitat;
        private System.Windows.Forms.TextBox textBoxVzdalenost;
        private System.Windows.Forms.Panel panelGraf;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}