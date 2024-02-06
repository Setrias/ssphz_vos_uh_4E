namespace slunecni_soustava
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
            this.textBoxNazevPlanety = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxObeznaDoba = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonZadat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNazevPlanety
            // 
            this.textBoxNazevPlanety.Location = new System.Drawing.Point(125, 48);
            this.textBoxNazevPlanety.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNazevPlanety.Name = "textBoxNazevPlanety";
            this.textBoxNazevPlanety.Size = new System.Drawing.Size(100, 23);
            this.textBoxNazevPlanety.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oběžná doba [roky]:";
            // 
            // textBoxObeznaDoba
            // 
            this.textBoxObeznaDoba.Location = new System.Drawing.Point(125, 79);
            this.textBoxObeznaDoba.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxObeznaDoba.Name = "textBoxObeznaDoba";
            this.textBoxObeznaDoba.Size = new System.Drawing.Size(100, 23);
            this.textBoxObeznaDoba.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Název planety:";
            // 
            // buttonZadat
            // 
            this.buttonZadat.Location = new System.Drawing.Point(12, 109);
            this.buttonZadat.Name = "buttonZadat";
            this.buttonZadat.Size = new System.Drawing.Size(213, 32);
            this.buttonZadat.TabIndex = 4;
            this.buttonZadat.Text = "Zadat";
            this.buttonZadat.UseVisualStyleBackColor = true;
            this.buttonZadat.Click += new System.EventHandler(this.buttonZadat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sluneční soustava";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonZadat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxObeznaDoba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNazevPlanety);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonZadat;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBoxObeznaDoba;

        private System.Windows.Forms.TextBox textBoxNazevPlanety;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}