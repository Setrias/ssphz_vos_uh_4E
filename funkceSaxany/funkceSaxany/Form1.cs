using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funkceSaxany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int cislo;
        private double sumaHodnot;

        private void buttonVypocitat_Click(object sender, EventArgs e)
        {
            sumaHodnot = 0;
            cislo = (int)numericUpDownX.Value;

            for (int i = 1; i < 20; i++)
            {
                sumaHodnot += (Math.Pow(-1, i) * Math.Pow(cislo, 2 * i + 1)) / i;
            }

            textBoxVysledek.Text = Convert.ToString(sumaHodnot);
        }
    }
}