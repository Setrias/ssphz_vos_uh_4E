using System;
using System.Windows.Forms;

namespace ukol_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double a, suma, deltaAlfa;
        private int c;

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            c = (int)numericUpDownC.Value;
            suma = 0;

            deltaAlfa = 2 * Math.PI / c;

            for (int i = 1; i < c; i++)
            {
                suma += Math.Cos(i * deltaAlfa);
            }

            a = 2.0 / c * suma;

            textBoxVysledek.Text = Convert.ToString(a);
        }
    }
}