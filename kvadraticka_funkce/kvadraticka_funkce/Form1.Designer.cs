namespace kvadraticka_funkce
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
            this.panelKvadraticka = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelKvadraticka
            // 
            this.panelKvadraticka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKvadraticka.Location = new System.Drawing.Point(652, 13);
            this.panelKvadraticka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelKvadraticka.Name = "panelKvadraticka";
            this.panelKvadraticka.Size = new System.Drawing.Size(600, 600);
            this.panelKvadraticka.TabIndex = 0;
            this.panelKvadraticka.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKvadraticka_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vykreslení kvadratické funkce";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 621);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelKvadraticka);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Vykreslení kvadratické funkce";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panelKvadraticka;

        #endregion
    }
}