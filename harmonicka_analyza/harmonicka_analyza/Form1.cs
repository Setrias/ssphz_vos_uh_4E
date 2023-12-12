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

        private double[] hodnoty = new double[10];
        private double sumaHodnot, y;
        private int k;

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            hodnoty[k] = (double)numericUpDownHodnoty.Value;
            k++;

            if (k == 10)
            {
                buttonZadat.Enabled = false;
                for (int i = 0; i < k; i++)
                {
                    sumaHodnot += hodnoty[i] * i;
                }

                MessageBox.Show("Suma hodnot je: " + sumaHodnot);
                y = 1 / 3.0 * sumaHodnot;
                textBoxVysledek.Text = Convert.ToString(y);
            }
        }
    }
}