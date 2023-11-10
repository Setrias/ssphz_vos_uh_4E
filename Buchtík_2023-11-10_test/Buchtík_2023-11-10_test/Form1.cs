using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchtík_2023_11_10_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double stranaA, stranaB, stranaC, hustota;

        private void buttonVypocet_Click(object sender, EventArgs e)
        {
            try
            {
                stranaA = Convert.ToDouble(textBoxA.Text);
                stranaB = Convert.ToDouble(textBoxB.Text);
                stranaC = Convert.ToDouble(textBoxC.Text);
                hustota = Convert.ToDouble(textBoxHustota.Text);

                // kontrola proměnných
                if (stranaA > 0 && stranaB > 0 && stranaC > 0 && hustota > 0)
                {
                    // vytvoření proměnné zastupující třídu
                    Hranol hranol = new Hranol(stranaA, stranaB, stranaC, hustota);

                    textBoxHmotnost.Text = hranol.Hmotnost().ToString();
                }
            }
            catch
            {
                MessageBox.Show("Zadané hodnoty musí být větší než nula!");
            }
        }
    }
}