using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinus_funkce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics panelFunkce;
        private float amplituda, perioda, fi, n = 600;
        private Pen pero = new Pen(Color.Blue, 2);

        private void panelSinus_Paint(object sender, PaintEventArgs e)
        {
            panelFunkce = panelSinus.CreateGraphics();
            
            panelFunkce.DrawLine(Pens.Black, 0, panelSinus.Size.Height / 2, panelSinus.Size.Width, panelSinus.Size.Height / 2);
        }

        private void buttonVykreslit_Click(object sender, EventArgs e)
        {
            try
            {
                amplituda = Convert.ToSingle(textBoxAmplituda.Text);
                perioda = Convert.ToSingle(textBoxPerioda.Text);
                fi = Convert.ToSingle(textBoxFi.Text);

                Vypocty();
            }
            catch
            {
                MessageBox.Show("Zadaná hodnota musí být celé číslo.");
            }
        }

        private float omega, deltaT, deltaTgraf, y, prevY;

        private void Vypocty()
        {
            panelSinus.Refresh();
            omega = Convert.ToSingle(2 * Math.PI / perioda);
            deltaT = perioda / n;
            deltaTgraf = 200 / n;

            prevY = Convert.ToSingle(amplituda * Math.Sin(omega * 0 + fi));

            for (int i = 0; i < n; i++)
            {
                y = Convert.ToSingle(amplituda * Math.Sin(omega * i + fi));

                float sourOldY = prevY + panelSinus.Size.Height / 2;
                float sourNewY = y + panelSinus.Size.Height / 2;
                
                panelFunkce.DrawLine(pero, i, sourOldY, i + 1, sourNewY);

                prevY = y;
            }
        }
    }
}