using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opakovani_4E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double cislo;

        private void buttonPrecist_Click(object sender, EventArgs e)
        {
            try
            {
                cislo = Convert.ToDouble(textBoxCislo.Text);

                if (cislo > 0)
                {
                    textBoxVysledek.Text = Convert.ToString(100 / cislo);
                }
                else
                {
                    MessageBox.Show("Číslo není kladné.");
                }
            }
            catch
            {
                MessageBox.Show("Nebylo zadáno číslo.");
            }
        }

        private String slovo;

        private void buttonHeslo_Click(object sender, EventArgs e)
        {
            slovo = textBoxSlovo.Text;
            if (slovo.Length < 4)
            {
                MessageBox.Show("Zadej delší slovo.");
                return;
            }

            textBoxHeslo.Text = slovo.Substring(2, 2) + slovo[0] + DateTime.Now.Year;
        }

        private void buttonVypsat_Click(object sender, EventArgs e)
        {
            textBoxDen.Text = Convert.ToString(DateTime.Now.Day);
            textBoxMesic.Text = Convert.ToString(DateTime.Now.Month);
            textBoxRok.Text = Convert.ToString(DateTime.Now.Year);

            int cisloDne = Convert.ToInt32(DateTime.Now.DayOfWeek);
            string nazevDne = "";

            switch (cisloDne)
            {
                case 0:
                    nazevDne = "Neděle";
                    break;
                case 1:
                    nazevDne = "Pondělí";
                    break;
                case 2:
                    nazevDne = "Úterý";
                    break;
                case 3:
                    nazevDne = "Středa";
                    break;
                case 4:
                    nazevDne = "Čtvrtek";
                    break;
                case 5:
                    nazevDne = "Pátek";
                    break;
                case 6:
                    nazevDne = "Sobota";
                    break;
            }

            textBoxNazevDne.Text = nazevDne;
        }
    }
}