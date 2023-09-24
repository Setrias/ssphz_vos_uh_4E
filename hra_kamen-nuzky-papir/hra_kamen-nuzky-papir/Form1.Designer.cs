namespace hra_kamen_nuzky_papir
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
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.answerPlayer = new System.Windows.Forms.PictureBox();
            this.optionPaper = new System.Windows.Forms.PictureBox();
            this.optionScissors = new System.Windows.Forms.PictureBox();
            this.optionRock = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelComputer = new System.Windows.Forms.Panel();
            this.answerComputer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_current = new System.Windows.Forms.Timer(this.components);
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.labelCompScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.answerPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionRock)).BeginInit();
            this.panelComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.answerComputer)).BeginInit();
            this.SuspendLayout();
            //
            // panelPlayer
            //
            this.panelPlayer.Controls.Add(this.answerPlayer);
            this.panelPlayer.Controls.Add(this.optionPaper);
            this.panelPlayer.Controls.Add(this.optionScissors);
            this.panelPlayer.Controls.Add(this.optionRock);
            this.panelPlayer.Controls.Add(this.label3);
            this.panelPlayer.Location = new System.Drawing.Point(12, 12);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(550, 657);
            this.panelPlayer.TabIndex = 4;
            this.panelPlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPlayer_Paint);
            //
            // answerPlayer
            //
            this.answerPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.answerPlayer.Location = new System.Drawing.Point(12, 53);
            this.answerPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.answerPlayer.Name = "answerPlayer";
            this.answerPlayer.Size = new System.Drawing.Size(525, 406);
            this.answerPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.answerPlayer.TabIndex = 5;
            this.answerPlayer.TabStop = false;
            //
            // optionPaper
            //
            this.optionPaper.Image = global::hra_kamen_nuzky_papir.Properties.Resources.paper;
            this.optionPaper.Location = new System.Drawing.Point(367, 474);
            this.optionPaper.Name = "optionPaper";
            this.optionPaper.Size = new System.Drawing.Size(180, 180);
            this.optionPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.optionPaper.TabIndex = 4;
            this.optionPaper.TabStop = false;
            this.optionPaper.Click += new System.EventHandler(this.optionPaper_Click);
            //
            // optionScissors
            //
            this.optionScissors.Image = global::hra_kamen_nuzky_papir.Properties.Resources.scissors;
            this.optionScissors.Location = new System.Drawing.Point(185, 474);
            this.optionScissors.Margin = new System.Windows.Forms.Padding(0);
            this.optionScissors.Name = "optionScissors";
            this.optionScissors.Size = new System.Drawing.Size(180, 180);
            this.optionScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.optionScissors.TabIndex = 3;
            this.optionScissors.TabStop = false;
            this.optionScissors.Click += new System.EventHandler(this.optionScissors_Click);
            //
            // optionRock
            //
            this.optionRock.Image = global::hra_kamen_nuzky_papir.Properties.Resources.rock;
            this.optionRock.Location = new System.Drawing.Point(3, 474);
            this.optionRock.Name = "optionRock";
            this.optionRock.Size = new System.Drawing.Size(180, 180);
            this.optionRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.optionRock.TabIndex = 2;
            this.optionRock.TabStop = false;
            this.optionRock.Click += new System.EventHandler(this.optionRock_Click);
            //
            // label3
            //
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hráč";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // panelComputer
            //
            this.panelComputer.Controls.Add(this.answerComputer);
            this.panelComputer.Controls.Add(this.label1);
            this.panelComputer.Location = new System.Drawing.Point(702, 12);
            this.panelComputer.Name = "panelComputer";
            this.panelComputer.Size = new System.Drawing.Size(550, 657);
            this.panelComputer.TabIndex = 5;
            this.panelComputer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelComputer_Paint);
            //
            // answerComputer
            //
            this.answerComputer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.answerComputer.Location = new System.Drawing.Point(12, 53);
            this.answerComputer.Margin = new System.Windows.Forms.Padding(0);
            this.answerComputer.Name = "answerComputer";
            this.answerComputer.Size = new System.Drawing.Size(525, 406);
            this.answerComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.answerComputer.TabIndex = 6;
            this.answerComputer.TabStop = false;
            //
            // label1
            //
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Počítač";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // timer_current
            //
            this.timer_current.Interval = 1000;
            this.timer_current.Tick += new System.EventHandler(this.timer_current_Tick);
            //
            // labelCurrentTime
            //
            this.labelCurrentTime.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentTime.Location = new System.Drawing.Point(568, 17);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(128, 31);
            this.labelCurrentTime.TabIndex = 6;
            this.labelCurrentTime.Text = "labelTime";
            this.labelCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // labelPlayerScore
            //
            this.labelPlayerScore.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerScore.Location = new System.Drawing.Point(568, 120);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(61, 31);
            this.labelPlayerScore.TabIndex = 7;
            this.labelPlayerScore.Text = "pS";
            this.labelPlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // labelCompScore
            //
            this.labelCompScore.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCompScore.Location = new System.Drawing.Point(635, 120);
            this.labelCompScore.Name = "labelCompScore";
            this.labelCompScore.Size = new System.Drawing.Size(61, 31);
            this.labelCompScore.TabIndex = 8;
            this.labelCompScore.Text = "cS";
            this.labelCompScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // label2
            //
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(568, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "vs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // labelState
            //
            this.labelState.BackColor = System.Drawing.SystemColors.Control;
            this.labelState.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelState.Location = new System.Drawing.Point(568, 238);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(128, 31);
            this.labelState.TabIndex = 10;
            this.labelState.Text = "labelState";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCompScore);
            this.Controls.Add(this.labelPlayerScore);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.panelComputer);
            this.Controls.Add(this.panelPlayer);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Kámen, nůžky, papír";
            this.panelPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.answerPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionRock)).EndInit();
            this.panelComputer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.answerComputer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox answerComputer;

        private System.Windows.Forms.PictureBox answerPlayer;
        private System.Windows.Forms.PictureBox pictureBoxComputer;

        private System.Windows.Forms.PictureBox optionComputer;

        private System.Windows.Forms.Label labelState;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.Label labelCompScore;

        private System.Windows.Forms.Label labelCurrentTime;

        private System.Windows.Forms.Timer timer_current;

        private System.Windows.Forms.PictureBox optionScissors;
        private System.Windows.Forms.PictureBox optionPaper;

        private System.Windows.Forms.PictureBox optionRock;

        private System.Windows.Forms.Panel panelComputer;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Label label3;

        #endregion
    }
}