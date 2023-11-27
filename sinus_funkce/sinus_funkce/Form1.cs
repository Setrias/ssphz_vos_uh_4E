using System;
using System.Drawing;
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
        private float amplituda, perioda, fi, amplituda2, perioda2, fi2, n = 600;
        private Pen peroBlue = new Pen(Color.Blue, 2);
        private Pen peroRed = new Pen(Color.Red, 2);

        private bool prvniSinus, druhySinus;

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

                if (druhySinus)
                {
                    panelSinus.Refresh();
                    Vypocty(amplituda, perioda, fi, peroBlue); // První sinusovka
                    Vypocty(amplituda2, perioda2, fi2, peroRed); // Druhá sinusovka
                }
                else
                {
                    panelSinus.Refresh();
                    Vypocty(amplituda, perioda, fi, peroBlue); // První sinusovka
                }

                prvniSinus = true;
            }
            catch
            {
                MessageBox.Show("Zadaná hodnota musí být celé číslo.");
            }
        }

        private float omega, y, prevY;

        private void Vypocty(float amplituda, float perioda, float fi, Pen pero)
        {
            omega = Convert.ToSingle(2 * Math.PI / 597);

            prevY = Convert.ToSingle(amplituda * Math.Sin(omega * 0 + fi));

            for (int i = 0; i < n; i++)
            {
                y = Convert.ToSingle(amplituda * Math.Sin(omega * i * perioda + fi));

                float sourOldY = prevY + panelSinus.Size.Height / 2;
                float sourNewY = y + panelSinus.Size.Height / 2;

                panelFunkce.DrawLine(pero, i, sourOldY, i + 1, sourNewY);

                prevY = y;
            }
        }

        private void buttonVykreslitDruhou_Click(object sender, EventArgs e)
        {
            try
            {
                amplituda2 = Convert.ToSingle(textBoxAmplitudaDruha.Text);
                perioda2 = Convert.ToSingle(textBoxPeriodaDruha.Text);
                fi2 = Convert.ToSingle(textBoxFiDruhe.Text);

                if (prvniSinus)
                {
                    panelSinus.Refresh();
                    Vypocty(amplituda, perioda, fi, peroBlue); // První sinusovka
                    Vypocty(amplituda2, perioda2, fi2, peroRed); // Druhá sinusovka
                }
                else
                {
                    panelSinus.Refresh();
                    Vypocty(amplituda2, perioda2, fi2, peroRed); // Druhá sinusovka
                }

                druhySinus = true;
            }
            catch
            {
                MessageBox.Show("Zadaná hodnota musí být celé číslo.");
            }
        }
    }
}