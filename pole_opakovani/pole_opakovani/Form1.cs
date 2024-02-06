using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole_opakovani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] a = new int[20];
        private Random random = new Random();
        private string cisla = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-50, 50);
            }
        }

        private void buttonVypis_Click(object sender, EventArgs e)
        {
            cisla = "";

            for (int i = 0; i < a.Length; i++)
            {
                cisla += a[i] + " ";
            }

            textBoxCisla.Text = cisla;
        }

        private void buttonPozpatku_Click(object sender, EventArgs e)
        {
            cisla = "";

            // Výpis čísel pozpátku pomocí zpětného for
            for (int i = a.Length - 1; i >= 0; i--)
            {
                cisla += a[i] + " ";
            }

            // for (int i = 0; i < 20; i++)
            // {
            //     listBoxCisla.Items.Add(poleCisel[20 - 1 - i]);
            // }

            textBoxPozpatku.Text = cisla;
        }

        private void buttonLichyIndex_Click(object sender, EventArgs e)
        {
            cisla = "";

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 != 0)
                {
                    cisla += a[i] + " ";
                }
            }

            textBoxLichyIndex.Text = cisla;
        }

        private void buttonMaxLichyIndex_Click(object sender, EventArgs e)
        {
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (max < a[i])
                    {
                        max = a[i];
                    }
                }
            }

            textBoxMaxLichyIndex.Text = Convert.ToString(max);
        }

        private void buttonPocetSudych_Click(object sender, EventArgs e)
        {
            int pocetSudych = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    pocetSudych++;
                }
            }

            textBoxPocetSudych.Text = Convert.ToString(pocetSudych);
        }

        private void buttonMinSude_Click(object sender, EventArgs e)
        {
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }

            textBoxMinSude.Text = Convert.ToString(min);
        }

        private void buttonPrumerKladne_Click(object sender, EventArgs e)
        {
            int soucetKladne = 0, pocetCisel = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    soucetKladne += a[i];
                    pocetCisel++;
                }
            }

            textBoxPrumerKladne.Text = Convert.ToString(soucetKladne / pocetCisel);
        }

        private void buttonPrumerLichyIndex_Click(object sender, EventArgs e)
        {
            int soucetLichyIndex = 0, pocetCisel = 0;

            for (int i = 1; i < a.Length; i++)
            {
                if (i % 2 != 0)
                {
                    soucetLichyIndex += a[i];
                    pocetCisel++;
                }
            }

            textBoxPrumerLichyIndex.Text = Convert.ToString(soucetLichyIndex / pocetCisel);
        }
    }
}