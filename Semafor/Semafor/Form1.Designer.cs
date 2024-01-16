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
            this.panelSemafor = new System.Windows.Forms.Panel();
            this.buttonGoStop = new System.Windows.Forms.Button();
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
            // buttonGoStop
            // 
            this.buttonGoStop.Location = new System.Drawing.Point(235, 95);
            this.buttonGoStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGoStop.Name = "buttonGoStop";
            this.buttonGoStop.Size = new System.Drawing.Size(114, 78);
            this.buttonGoStop.TabIndex = 1;
            this.buttonGoStop.Text = "Go / Stop";
            this.buttonGoStop.UseVisualStyleBackColor = true;
            this.buttonGoStop.Click += new System.EventHandler(this.buttonGoStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.buttonGoStop);
            this.Controls.Add(this.panelSemafor);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Semafor";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonGoStop;

        private System.Windows.Forms.Panel panelSemafor;

        #endregion
    }
}