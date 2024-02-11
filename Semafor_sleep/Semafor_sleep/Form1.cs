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

namespace Semafor_sleep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics kresleni;
        private int panelWidth;

        private Brush brRed = new SolidBrush(Color.Red);
        private Brush brOrange = new SolidBrush(Color.Orange);
        private Brush brGreen = new SolidBrush(Color.Green);

        private void panelSemafor_Paint(object sender, PaintEventArgs e)
        {
            panelWidth = panelSemafor.Width;

            kresleni = panelSemafor.CreateGraphics();
            kresleni.Clear(Color.LightGray);

            while (true)
            {
                panelSemafor.Refresh();
                kresleni.Clear(Color.LightGray);
                KresliRed();
                Thread.Sleep(5000);

                panelSemafor.Refresh();
                kresleni.Clear(Color.LightGray);
                KresliRed();
                KresliOrange();
                Thread.Sleep(2000);

                panelSemafor.Refresh();
                kresleni.Clear(Color.LightGray);
                KresliGreen();
                Thread.Sleep(5000);

                panelSemafor.Refresh();
                kresleni.Clear(Color.LightGray);
                KresliOrange();
                Thread.Sleep(2000);

                break;
            }
        }

        private void KresliRed()
        {
            kresleni.FillEllipse(brRed, panelWidth / 2 - panelWidth /4, 25, 100, 100);
        }

        private void KresliOrange()
        {
            kresleni.FillEllipse(brOrange, panelWidth / 2 - panelWidth /4, 150, 100, 100);
        }

        private void KresliGreen()
        {
            kresleni.FillEllipse(brGreen, panelWidth / 2 - panelWidth /4, 275, 100, 100);
        }
    }
}