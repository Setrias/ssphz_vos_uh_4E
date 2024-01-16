using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Semafor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            timerGoStop = new System.Timers.Timer();
            timerGoStop.Interval = 2000;
            timerGoStop.Elapsed += toGoStop;
        }

        private Graphics kresleni;
        private int panelWidth, panelHeight;
        private bool go = false;

        private System.Timers.Timer timerGoStop;

        private Brush brRed = new SolidBrush(Color.Red);
        private Brush brOrange = new SolidBrush(Color.Orange);
        private Brush brGreen = new SolidBrush(Color.Green);

        private void panelSemafor_Paint(object sender, PaintEventArgs e)
        {
            panelWidth = panelSemafor.Width;
            panelHeight = panelSemafor.Height;

            kresleni = panelSemafor.CreateGraphics();

            KresliRed();
            // KresliOrange();
            // KresliGreen();
        }
        
        private void buttonGoStop_Click(object sender, EventArgs e)
        {
            buttonGoStop.Enabled = false;
            timerGoStop.Start();
        }

        private void toGoStop(Object source, System.Timers.ElapsedEventArgs e)
        {
            
            if (go)
            {
                
                MessageBox.Show("Go true");
                go = false;
                timerGoStop.Stop();
            }
            else
            {
                
                MessageBox.Show("Go false");
                go = true;
                timerGoStop.Stop();
            }
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