namespace vazeny_prumer
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
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.numericUpDownZnamka = new System.Windows.Forms.NumericUpDown();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxVypis = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownVaha = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZnamka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVaha)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Items.AddRange(new object[] { "CJL", "ANJ", "POS", "ZAP", "ELN" });
            this.comboBoxSubject.Location = new System.Drawing.Point(73, 26);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSubject.TabIndex = 0;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // numericUpDownZnamka
            // 
            this.numericUpDownZnamka.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownZnamka.Location = new System.Drawing.Point(73, 56);
            this.numericUpDownZnamka.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numericUpDownZnamka.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownZnamka.Name = "numericUpDownZnamka";
            this.numericUpDownZnamka.Size = new System.Drawing.Size(49, 30);
            this.numericUpDownZnamka.TabIndex = 1;
            this.numericUpDownZnamka.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(129, 56);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(65, 66);
            this.buttonUlozit.TabIndex = 2;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Předmět:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Známka:";
            // 
            // listBoxVypis
            // 
            this.listBoxVypis.FormattingEnabled = true;
            this.listBoxVypis.ItemHeight = 16;
            this.listBoxVypis.Location = new System.Drawing.Point(200, 26);
            this.listBoxVypis.Name = "listBoxVypis";
            this.listBoxVypis.Size = new System.Drawing.Size(169, 100);
            this.listBoxVypis.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Známka:";
            // 
            // numericUpDownVaha
            // 
            this.numericUpDownVaha.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownVaha.Location = new System.Drawing.Point(73, 92);
            this.numericUpDownVaha.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numericUpDownVaha.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownVaha.Name = "numericUpDownVaha";
            this.numericUpDownVaha.Size = new System.Drawing.Size(49, 30);
            this.numericUpDownVaha.TabIndex = 6;
            this.numericUpDownVaha.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 138);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownVaha);
            this.Controls.Add(this.listBoxVypis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.numericUpDownZnamka);
            this.Controls.Add(this.comboBoxSubject);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Vážený Průměr";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZnamka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVaha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownVaha;

        private System.Windows.Forms.ListBox listBoxVypis;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.NumericUpDown numericUpDownZnamka;

        private System.Windows.Forms.ComboBox comboBoxSubject;

        #endregion
    }
}