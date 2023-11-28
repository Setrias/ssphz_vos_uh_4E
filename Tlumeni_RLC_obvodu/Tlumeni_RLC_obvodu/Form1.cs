using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tlumeni_RLC_obvodu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Vypocty _vypocty;
        private double odpor, indukcnost, kapacita, fi, amplituda, cas;

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            try
            {
                odpor = Convert.ToDouble(textBoxOdpor.Text);
                indukcnost = Convert.ToDouble(textBoxIndukcnost.Text);
                kapacita = Convert.ToDouble(textBoxKapacita.Text);
                fi = Convert.ToDouble(textBoxFi.Text);
                amplituda = Convert.ToDouble(textBoxAmplitudaProudu.Text);
                cas = Convert.ToDouble(textBoxCas.Text);

                Vypocitat();
            }
            catch
            {
                MessageBox.Show("Zadané hodnoty musí být čísla.");
            }
        }

        private void Vypocitat()
        {
            _vypocty = new Vypocty(odpor, indukcnost, kapacita, fi, amplituda, cas);

            textBoxTlumeni.Text = Convert.ToString(_vypocty.Tlumeni());
            textBoxOmegaNula.Text = _vypocty.OmegaNula().ToString();
            textBoxOmega.Text = _vypocty.Omega().ToString();
            textBoxOkamHodProudu.Text = _vypocty.OkamzitaHodnotaProudu().ToString();
        }
    }
}