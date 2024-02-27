using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harmonicka_analyza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // vypocty
        private double[] hodnoty = { 13, 25, 43, 56, 57, 28, 7, -14, -28, -29, -28, 3 };
        private double c = 12;
        private double sumaHodnotY, deltaAlfa;
        private double koeficientA0;
        private double frekvence = 50;

        struct Koeficienty
        {
            public double a;
            public double b;
        }

        private Koeficienty[] _koeficienty = new Koeficienty[4];

        // graf
        private Graphics grafHarmonicka;
        private int panelHeight, panelWidth;

        private void panelHarmonicka_Paint(object sender, PaintEventArgs e)
        {
            grafHarmonicka = panelHarmonicka.CreateGraphics();

            panelHeight = panelHarmonicka.Height;
            panelWidth = panelHarmonicka.Width;

            grafHarmonicka.DrawLine(Pens.Black, 0, panelHeight / 2, panelWidth, panelHeight / 2);
        }

        private void buttonVypocitat_Click(object sender, EventArgs e)
        {
            panelHarmonicka.Refresh();

            sumaHodnotY = SumaHodnotY();
            deltaAlfa = 2 * Math.PI / c;

            koeficientA0 = 1.0 / c * sumaHodnotY;
            textBoxA0.Text = Convert.ToString(koeficientA0);

            VypocetAn();
            VypocetBn();

            textBoxA1.Text = _koeficienty[0].a.ToString();
            textBoxA2.Text = _koeficienty[1].a.ToString();
            textBoxA3.Text = _koeficienty[2].a.ToString();
            textBoxA4.Text = _koeficienty[3].a.ToString();

            textBoxB1.Text = _koeficienty[0].b.ToString();
            textBoxB2.Text = _koeficienty[1].b.ToString();
            textBoxB3.Text = _koeficienty[2].b.ToString();
            textBoxB4.Text = _koeficienty[3].b.ToString();

            KresleniGrafHarmonicka();
        }

        private double SumaHodnotY()
        {
            sumaHodnotY = 0;

            foreach (double y in hodnoty)
            {
                sumaHodnotY += y;
            }

            return sumaHodnotY;
        }

        private void VypocetAn()
        {
            for (int i = 0; i < 4; i++)
            {
                double suma = 0;

                for (int j = 0; j < c; j++)
                {
                    suma += hodnoty[j] * Math.Cos((i + 1) * ((j) * deltaAlfa));
                }

                _koeficienty[i].a = 2.0 / c * suma;
            }
        }

        private void VypocetBn()
        {
            for (int i = 0; i < 4; i++)
            {
                double suma = 0;

                for (int j = 0; j < c; j++)
                {
                    suma += hodnoty[j] * Math.Sin((i + 1) * ((j) * deltaAlfa));
                }

                _koeficienty[i].b = 2.0 / c * suma;
            }
        }

        private void KresleniGrafHarmonicka()
        {
            float yPrev = 0, yNext = 0;
            int pocetAmplitud = 72;
            int krok = panelWidth / pocetAmplitud;

            double An = 0, Fin = 0;

            for (int i = 0; i < 4; i++)
            {
                An = Math.Sqrt(Math.Pow(_koeficienty[i].a, 2) + Math.Pow(_koeficienty[i].b, 2));
                Fin = Math.Atan(_koeficienty[i].b / _koeficienty[i].a);

                for (int j = 0; j < panelWidth; j += krok)
                {
                    yPrev += Convert.ToSingle(An * Math.Cos(i * (2 * Math.PI * frekvence) * j - Fin));
                    yNext += Convert.ToSingle(An * Math.Cos(i * (2 * Math.PI * frekvence) * (j + krok) - Fin));

                    listBoxHodnoty.Items.Add("Konst. " + i + " / prev / " + yPrev);
                    listBoxHodnoty.Items.Add("Konst. " + i + " / next / " + yNext);

                    grafHarmonicka.DrawLine(Pens.Black, j, yPrev, j + krok, yNext);
                }
            }
        }
    }
}