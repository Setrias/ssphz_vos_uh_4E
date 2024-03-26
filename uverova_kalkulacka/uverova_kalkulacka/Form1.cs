using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uverova_kalkulacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Uver _uver;
        private int pujcka, dobaSplaceni;

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            try
            {
                pujcka = Convert.ToInt32(textBoxVysePujcky.Text);
                dobaSplaceni = Convert.ToInt32(textBoxDobaSplaceni.Text);

                if (pujcka <= 0 || dobaSplaceni <= 0)
                {
                    MessageBox.Show("Hodnoty musí být kladné číslo.");
                    return;
                }

                if (pujcka > 500000)
                {
                    MessageBox.Show("Maximální výše půjčky je 500,000.00 Kč.");
                }

                if (pujcka < 1000000 && dobaSplaceni > 3)
                {
                    MessageBox.Show("Do 100,000.00 je doba splácení maximálně 3 roky.");
                }
            }
            catch
            {
                MessageBox.Show("Hodnoty musí být celé číslo.");
            }

            _uver = new Uver(pujcka, dobaSplaceni);

            double celkemZaplati = _uver.Splatky() * (dobaSplaceni * 12);
            double vyseSplatky = _uver.Splatky();
            int urokovaSazba = _uver.UrokovaSazba();
            double preplatek = celkemZaplati - pujcka;

            textBoxVyseSplatky.Text = Convert.ToString(vyseSplatky);
            textBoxUrok.Text = Convert.ToString(urokovaSazba);
            textBoxCelkemZaplati.Text = Convert.ToString(celkemZaplati);
            textBoxPreplatek.Text = Convert.ToString(preplatek);
        }
    }
}