namespace Buchtík_2024_02_13_test
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
            this.panelVystrazne = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timerVystrazne = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelZavislost = new System.Windows.Forms.Panel();
            this.listBoxVypocty = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // panelVystrazne
            // 
            this.panelVystrazne.BackColor = System.Drawing.Color.Gray;
            this.panelVystrazne.Location = new System.Drawing.Point(12, 36);
            this.panelVystrazne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelVystrazne.Name = "panelVystrazne";
            this.panelVystrazne.Size = new System.Drawing.Size(200, 200);
            this.panelVystrazne.TabIndex = 0;
            this.panelVystrazne.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVystrazne_Paint);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 244);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(98, 28);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(116, 244);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(96, 28);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timerVystrazne
            // 
            this.timerVystrazne.Interval = 500;
            this.timerVystrazne.Tick += new System.EventHandler(this.timerVystrazne_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Úkol 1.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(218, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(641, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Úkol 2.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelZavislost
            // 
            this.panelZavislost.BackColor = System.Drawing.SystemColors.Control;
            this.panelZavislost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelZavislost.Location = new System.Drawing.Point(218, 36);
            this.panelZavislost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelZavislost.Name = "panelZavislost";
            this.panelZavislost.Size = new System.Drawing.Size(440, 328);
            this.panelZavislost.TabIndex = 1;
            this.panelZavislost.Paint += new System.Windows.Forms.PaintEventHandler(this.panelZavislost_Paint);
            // 
            // listBoxVypocty
            // 
            this.listBoxVypocty.FormattingEnabled = true;
            this.listBoxVypocty.ItemHeight = 16;
            this.listBoxVypocty.Location = new System.Drawing.Point(664, 36);
            this.listBoxVypocty.Name = "listBoxVypocty";
            this.listBoxVypocty.Size = new System.Drawing.Size(195, 68);
            this.listBoxVypocty.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 375);
            this.Controls.Add(this.listBoxVypocty);
            this.Controls.Add(this.panelZavislost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelVystrazne);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Buchtík písemka 2024-02-13";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBoxVypocty;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelZavislost;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Timer timerVystrazne;

        private System.Windows.Forms.Button buttonStop;

        private System.Windows.Forms.Button buttonStart;

        private System.Windows.Forms.Panel panelVystrazne;

        #endregion
    }
}