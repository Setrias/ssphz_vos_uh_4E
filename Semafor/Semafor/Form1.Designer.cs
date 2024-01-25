namespace Semafor
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
            this.panelSemafor = new System.Windows.Forms.Panel();
            this.timerSemafor = new System.Windows.Forms.Timer(this.components);
            this.progressBarSemafor = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // panelSemafor
            // 
            this.panelSemafor.Location = new System.Drawing.Point(12, 15);
            this.panelSemafor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSemafor.Name = "panelSemafor";
            this.panelSemafor.Size = new System.Drawing.Size(217, 434);
            this.panelSemafor.TabIndex = 0;
            this.panelSemafor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSemafor_Paint);
            // 
            // timerSemafor
            // 
            this.timerSemafor.Interval = 1000;
            this.timerSemafor.Tick += new System.EventHandler(this.timerSemafor_Tick);
            // 
            // progressBarSemafor
            // 
            this.progressBarSemafor.Location = new System.Drawing.Point(235, 219);
            this.progressBarSemafor.Maximum = 15;
            this.progressBarSemafor.Name = "progressBarSemafor";
            this.progressBarSemafor.Size = new System.Drawing.Size(553, 23);
            this.progressBarSemafor.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.progressBarSemafor);
            this.Controls.Add(this.panelSemafor);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Semafor";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ProgressBar progressBarSemafor;

        private System.Windows.Forms.Timer timerSemafor;

        private System.Windows.Forms.Panel panelSemafor;

        #endregion
    }
}