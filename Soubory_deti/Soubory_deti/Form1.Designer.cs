namespace Soubory_deti
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
            this.listBoxUdaje = new System.Windows.Forms.ListBox();
            this.panelGraf = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPocetTriletych = new System.Windows.Forms.TextBox();
            this.textBoxPrumVyskaDvouletych = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrumVahaDvouletych = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxUdaje
            // 
            this.listBoxUdaje.FormattingEnabled = true;
            this.listBoxUdaje.ItemHeight = 16;
            this.listBoxUdaje.Location = new System.Drawing.Point(12, 12);
            this.listBoxUdaje.Name = "listBoxUdaje";
            this.listBoxUdaje.Size = new System.Drawing.Size(249, 308);
            this.listBoxUdaje.TabIndex = 0;
            // 
            // panelGraf
            // 
            this.panelGraf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraf.Location = new System.Drawing.Point(285, 12);
            this.panelGraf.Name = "panelGraf";
            this.panelGraf.Size = new System.Drawing.Size(600, 400);
            this.panelGraf.TabIndex = 1;
            this.panelGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraf_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Počet tříletých dětí:";
            // 
            // textBoxPocetTriletych
            // 
            this.textBoxPocetTriletych.Location = new System.Drawing.Point(171, 331);
            this.textBoxPocetTriletych.Name = "textBoxPocetTriletych";
            this.textBoxPocetTriletych.ReadOnly = true;
            this.textBoxPocetTriletych.Size = new System.Drawing.Size(90, 23);
            this.textBoxPocetTriletych.TabIndex = 3;
            // 
            // textBoxPrumVyskaDvouletych
            // 
            this.textBoxPrumVyskaDvouletych.Location = new System.Drawing.Point(171, 360);
            this.textBoxPrumVyskaDvouletych.Name = "textBoxPrumVyskaDvouletych";
            this.textBoxPrumVyskaDvouletych.ReadOnly = true;
            this.textBoxPrumVyskaDvouletych.Size = new System.Drawing.Size(90, 23);
            this.textBoxPrumVyskaDvouletych.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Průměrná výška dvouletých:";
            // 
            // textBoxPrumVahaDvouletych
            // 
            this.textBoxPrumVahaDvouletych.Location = new System.Drawing.Point(171, 389);
            this.textBoxPrumVahaDvouletych.Name = "textBoxPrumVahaDvouletych";
            this.textBoxPrumVahaDvouletych.ReadOnly = true;
            this.textBoxPrumVahaDvouletych.Size = new System.Drawing.Size(90, 23);
            this.textBoxPrumVahaDvouletych.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Průměrná váha dvouletých:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 427);
            this.Controls.Add(this.textBoxPrumVahaDvouletych);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrumVyskaDvouletych);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPocetTriletych);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelGraf);
            this.Controls.Add(this.listBoxUdaje);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Soubory děti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxPrumVahaDvouletych;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPocetTriletych;
        private System.Windows.Forms.TextBox textBoxPrumVyskaDvouletych;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ListBox listBoxUdaje;
        private System.Windows.Forms.Panel panelGraf;

        #endregion
    }
}