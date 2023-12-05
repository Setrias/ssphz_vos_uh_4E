using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchtík_2023_12_05_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics panelFunkce;
        private int width, height;

        private int amplituda;
        private float perioda;
        private Pen peroBlue = new Pen(Color.Blue, 2);

        private void buttonVykreslit_Click(object sender, EventArgs e)
        {
            try
            {
                amplituda = Convert.ToInt32(textBoxAmplituda.Text);
                perioda = Convert.ToSingle(textBoxPerioda.Text);

                // kontrola proměnných
                if (perioda >= 0.5 && perioda <= 1.5 && amplituda > 0)
                {
                    Vykreslit();
                }
                else
                {
                    MessageBox.Show("Perioda musí být z rozmezí 0.5 až 1.5 a amplituda musí být větší než 0.");
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo.");
            }
        }

        private void Vykreslit()
        {
            // refresh panelu
            panelGraf.Refresh();

            // první bod
            float prevY = Convert.ToSingle(amplituda * Math.Cos(2 * Math.PI * 0));

            float krok = perioda / width;

            for (int i = 1; i < width; i++)
            {
                // následující bod
                float y = Convert.ToSingle(amplituda * Math.Cos(2 * Math.PI * i * krok));

                // kreslní čáry
                panelFunkce.DrawLine(peroBlue, i, prevY + height / 2, i + krok, y + height / 2);

                prevY = y;
            }
        }

        private void panelGraf_Paint(object sender, PaintEventArgs e)
        {
            panelFunkce = panelGraf.CreateGraphics();
            
            // šířka a výška panelu
            width = panelGraf.Width;
            height = panelGraf.Height;

            // horizonální osa
            panelFunkce.DrawLine(Pens.Black, 0, height / 2, width, height / 2);

            // vertikální osa
            panelFunkce.DrawLine(Pens.Black, 0, 0, 0, height);
        }
    }
}