using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vypis_cisla_xkrat_na_radek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int cislo;

        private void buttonZadaneCislo_Click(object sender, EventArgs e)
        {
            listBoxZadaneCislo.Items.Clear();

            cislo = (int)numericUpDownZadaneCislo.Value;
            string cisloRadek = "";

            for (int i = 1; i < cislo + 1; i++)
            {
                string radek = "";

                for (int j = 0; j < i; j++)
                {
                    if (j + 2 > i)
                    {
                        radek += i;
                    }
                    else
                    {
                        radek = radek + i + ", ";
                    }

                    cisloRadek += i + ", ";
                }

                listBoxZadaneCislo.Items.Add(radek);
            }

            textBoxZadaneCisloRadek.Text = cisloRadek;
        }
    }
}