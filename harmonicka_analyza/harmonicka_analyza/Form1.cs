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

        private double[] hodnoty = { 13, 25, 43, 56, 57, 28, 7, -14, -28, -29, -28, 3 };
        private double c = 12;
        private double sumaHodnotY, deltaAlfa;

        private void buttonVypocitat_Click(object sender, EventArgs e)
        {
            sumaHodnotY = SumaHodnotY();
            deltaAlfa = 2 * Math.PI / c;

            textBoxA0.Text = Convert.ToString(1.0 / c * sumaHodnotY);

            textBoxA1.Text = VypocetAn(1).ToString();
            textBoxA2.Text = VypocetAn(2).ToString();
            textBoxA3.Text = VypocetAn(3).ToString();
            textBoxA4.Text = VypocetAn(4).ToString();

            textBoxB1.Text = VypocetBn(1).ToString();
            textBoxB2.Text = VypocetBn(2).ToString();
            textBoxB3.Text = VypocetBn(3).ToString();
            textBoxB4.Text = VypocetBn(4).ToString();
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

        private double VypocetAn(int numHarmonicka)
        {
            double suma = 0;

            for (int i = 0; i < c; i++)
            {
                suma += hodnoty[i] * Math.Cos(numHarmonicka * ((i + 1) * deltaAlfa));
            }

            return 2.0 / c * suma;
        }

        private double VypocetBn(int numHarmonicka)
        {
            double suma = 0;

            for (int i = 0; i < c; i++)
            {
                suma += hodnoty[i] * Math.Sin(numHarmonicka * ((i + 1) * deltaAlfa));
            }

            return 2.0 / c * suma;
        }
    }
}