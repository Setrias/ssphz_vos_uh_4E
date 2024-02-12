namespace ukol_1
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
            this.components = new System.ComponentModel.Container();
            this.panelPrejezd = new System.Windows.Forms.Panel();
            this.buttonPrejezd = new System.Windows.Forms.Button();
            this.timerPrejezd = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelPrejezd
            // 
            this.panelPrejezd.BackColor = System.Drawing.Color.Gray;
            this.panelPrejezd.Location = new System.Drawing.Point(12, 12);
            this.panelPrejezd.Name = "panelPrejezd";
            this.panelPrejezd.Size = new System.Drawing.Size(400, 200);
            this.panelPrejezd.TabIndex = 0;
            this.panelPrejezd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrejezd_Paint);
            // 
            // buttonPrejezd
            // 
            this.buttonPrejezd.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrejezd.Location = new System.Drawing.Point(12, 218);
            this.buttonPrejezd.Name = "buttonPrejezd";
            this.buttonPrejezd.Size = new System.Drawing.Size(400, 55);
            this.buttonPrejezd.TabIndex = 1;
            this.buttonPrejezd.Text = "Aktivovat přejezd";
            this.buttonPrejezd.UseVisualStyleBackColor = true;
            this.buttonPrejezd.Click += new System.EventHandler(this.buttonPrejezd_Click);
            // 
            // timerPrejezd
            // 
            this.timerPrejezd.Interval = 500;
            this.timerPrejezd.Tick += new System.EventHandler(this.timerPrejezd_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 282);
            this.Controls.Add(this.buttonPrejezd);
            this.Controls.Add(this.panelPrejezd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Timer timerPrejezd;

        private System.Windows.Forms.Button buttonPrejezd;

        private System.Windows.Forms.Panel panelPrejezd;

        #endregion
    }
}