using System;
using System.Drawing;
using System.Windows.Forms;

namespace Semafor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timerSemafor.Enabled = true;
        }

        private Graphics kresleni;
        private int panelWidth;
        private int seconds;

        private Brush brRed = new SolidBrush(Color.Red);
        private Brush brOrange = new SolidBrush(Color.Orange);
        private Brush brGreen = new SolidBrush(Color.Green);

        private void panelSemafor_Paint(object sender, PaintEventArgs e)
        {
            panelWidth = panelSemafor.Width;

            kresleni = panelSemafor.CreateGraphics();
        }

        private void timerSemafor_Tick(object sender, EventArgs e)
        {
            seconds++;

            switch (seconds)
            {
                case 1:
                    panelSemafor.Refresh();
                    KresliRed();
                    break;
                case 5:
                    panelSemafor.Refresh();
                    KresliRed();
                    KresliOrange();
                    break;
                case 7:
                    panelSemafor.Refresh();
                    KresliGreen();
                    break;
                case 14:
                    panelSemafor.Refresh();
                    KresliOrange();
                    break;
                case 16:
                    panelSemafor.Refresh();
                    KresliRed();
                    seconds = 0;
                    break;
            }

            progressBarSemafor.Value = seconds;
        }

        private void KresliRed()
        {
            kresleni.FillEllipse(brRed, panelWidth / 2 - 100, 25, 100, 100);
        }

        private void KresliOrange()
        {
            kresleni.FillEllipse(brOrange, panelWidth / 2 - 100, 150, 100, 100);
        }

        private void KresliGreen()
        {
            kresleni.FillEllipse(brGreen, panelWidth / 2 - 100, 275, 100, 100);
        }
    }
}