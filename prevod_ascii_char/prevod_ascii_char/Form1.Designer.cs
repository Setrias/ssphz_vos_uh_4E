
namespace prevod_ascii_char
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAscii = new System.Windows.Forms.TextBox();
            this.buttonAscii = new System.Windows.Forms.Button();
            this.listBoxVysledky = new System.Windows.Forms.ListBox();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.buttonChar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAscii
            // 
            this.textBoxAscii.Location = new System.Drawing.Point(12, 51);
            this.textBoxAscii.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAscii.Name = "textBoxAscii";
            this.textBoxAscii.Size = new System.Drawing.Size(100, 23);
            this.textBoxAscii.TabIndex = 0;
            // 
            // buttonAscii
            // 
            this.buttonAscii.Location = new System.Drawing.Point(12, 81);
            this.buttonAscii.Name = "buttonAscii";
            this.buttonAscii.Size = new System.Drawing.Size(100, 30);
            this.buttonAscii.TabIndex = 1;
            this.buttonAscii.Text = "Na ASCII";
            this.buttonAscii.UseVisualStyleBackColor = true;
            this.buttonAscii.Click += new System.EventHandler(this.buttonAscii_Click);
            // 
            // listBoxVysledky
            // 
            this.listBoxVysledky.FormattingEnabled = true;
            this.listBoxVysledky.ItemHeight = 16;
            this.listBoxVysledky.Location = new System.Drawing.Point(118, 51);
            this.listBoxVysledky.Name = "listBoxVysledky";
            this.listBoxVysledky.Size = new System.Drawing.Size(120, 212);
            this.listBoxVysledky.TabIndex = 3;
            // 
            // textBoxChar
            // 
            this.textBoxChar.Location = new System.Drawing.Point(244, 51);
            this.textBoxChar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxChar.Name = "textBoxChar";
            this.textBoxChar.Size = new System.Drawing.Size(100, 23);
            this.textBoxChar.TabIndex = 4;
            // 
            // buttonChar
            // 
            this.buttonChar.Location = new System.Drawing.Point(244, 81);
            this.buttonChar.Name = "buttonChar";
            this.buttonChar.Size = new System.Drawing.Size(100, 30);
            this.buttonChar.TabIndex = 5;
            this.buttonChar.Text = "Na znak";
            this.buttonChar.UseVisualStyleBackColor = true;
            this.buttonChar.Click += new System.EventHandler(this.buttonChar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Převod z a na ASCII";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChar);
            this.Controls.Add(this.textBoxChar);
            this.Controls.Add(this.listBoxVysledky);
            this.Controls.Add(this.buttonAscii);
            this.Controls.Add(this.textBoxAscii);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAscii;
        private System.Windows.Forms.Button buttonAscii;
        private System.Windows.Forms.ListBox listBoxVysledky;
        private System.Windows.Forms.TextBox textBoxChar;
        private System.Windows.Forms.Button buttonChar;
        private System.Windows.Forms.Label label1;
    }
}

