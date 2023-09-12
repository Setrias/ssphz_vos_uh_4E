using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spolecne_opakovani_zacatek_roku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBoxVypocetOdporu.Visible = false;
            groupBoxVypocetFrekvence.Visible = false;
        }
        
        private string mail, id;
        private Random nahodneCislo = new Random();

        private void buttonMail_Click(object sender, EventArgs e)
        {
            // vytváření identifikátoru z mailu
            mail = textBoxMail.Text;
            id = "";

            int[] pozice = new int[3] { 2, 4, 6 }; // třetí, pátý a sedmý znak jsou 2, 4, 6
            for (int i = 0; i < 3; i++)
            {
                // aby adresa nebyla krátká, program by spadl
                if (mail[pozice[i]] == ' ')
                {
                    MessageBox.Show("E-mail adresa je moc krátká.");
                    return;
                }

                // když bude na místě místě @ nebo . tak se vybere další znak
                if (mail[pozice[i]] == '@' || mail[pozice[i]] == '.')
                {
                    id += mail[pozice[i] + 1];
                }
                else
                {
                    id += mail[pozice[i]];
                }
            }

            // přidání náhodného čísla za ID
            id += nahodneCislo.Next(0, 10);

            MessageBox.Show(id);

            groupBoxVypocetOdporu.Visible = true;
            buttonMail.Enabled = false;
        }

        ////////////////////////////////////////////////////////////////////
        /// výpočet odporu
        struct AtributyMereni
        {
            public double napeti;
            public double proud;
            public double odpor;
        }

        private AtributyMereni[] zaznamMereni = new AtributyMereni[5];
        private int pocetMereni;
        private double soucetOdporu, vyslednyOdpor;
        private string textPocetMereni;
        
        private void buttonHodnotyMereni_Click(object sender, EventArgs e)
        {
            try
            {
                // testování vstupů
                zaznamMereni[pocetMereni].napeti = Convert.ToDouble(textBoxNapeti.Text);
                zaznamMereni[pocetMereni].proud = Convert.ToDouble(textBoxProud.Text);

                // aby hodnoty nebyly záporné nebo nulové
                if (zaznamMereni[pocetMereni].napeti <= 0 || zaznamMereni[pocetMereni].proud <= 0)
                {
                    MessageBox.Show("Hodnoty nesmí být záporné ani nulové");
                    return;
                }

                // výpočet
                zaznamMereni[pocetMereni].odpor = zaznamMereni[pocetMereni].napeti / zaznamMereni[pocetMereni].proud;
                pocetMereni++;

                if (pocetMereni < 5)
                {
                    switch (pocetMereni)
                    {
                        case 1:
                            textPocetMereni = Convert.ToString(pocetMereni + 1);
                            break;
                        case 2:
                            textPocetMereni = Convert.ToString(pocetMereni + 1);
                            break;
                        case 3:
                            textPocetMereni = Convert.ToString(pocetMereni + 1);
                            break;
                        case 4:
                            textPocetMereni = Convert.ToString(pocetMereni + 1);
                            break;
                        case 5:
                            textPocetMereni = Convert.ToString(pocetMereni + 1);
                            break;
                    }

                    labelCisloMereni.Text = textPocetMereni;
                }
            }
            catch
            {
                MessageBox.Show("Napětí a proud musí být číslo.");
                return;
            }

            // po zadání 5-ti hodnot se vypočítá a vypíše průměr
            if (pocetMereni == 5)
            {
                buttonHodnotyMereni.Enabled = false;
                for (int i = 0; i < 5; i++)
                {
                    soucetOdporu += zaznamMereni[i].odpor;
                }

                // zaokrouhlení výsledku
                vyslednyOdpor = Math.Round(soucetOdporu / 5, 2);
                textBoxVyslednyOdpor.Text = Convert.ToString(vyslednyOdpor);
                groupBoxVypocetFrekvence.Visible = true;
            }
        }

        ////////////////////////////////////////////////////////////////////
        /// výpočet frekvence kmitů oscilátoru

        private double indukcnost, kapacita, omega, omegaNula, delta;
        private StreamWriter sWriter;
        private string datum;

        private void buttonZadatHodnotyFrekvence_Click(object sender, EventArgs e)
        {
            try
            {
                // testování vstupů
                indukcnost = Convert.ToDouble(textBoxIndukcnost.Text);
                kapacita = Convert.ToDouble(textBoxKapacita.Text);

                if (indukcnost <= 0 || kapacita <= 0)
                {
                    MessageBox.Show("Hodnoty nesmí být nula nebo záporné.");
                    return;
                }

                // výpočty
                omegaNula = 1 / Math.Sqrt(indukcnost * kapacita);
                delta = vyslednyOdpor / (2 * indukcnost);
                omega = Math.Sqrt(Math.Pow(omegaNula, 2) - Math.Pow(delta, 2));
                textBoxUhlovaFrekvence.Text = Convert.ToString(omega);

                buttonZadatHodnotyFrekvence.Enabled = false;

                // zápis do souboru
                sWriter = new StreamWriter("vysledek.txt", true);
                if (File.Exists("vysledek.txt"))
                {
                    // datum ve formátu den-měsíc-rok
                    datum = DateTime.Today.ToString("dd-MM-yyyy");
                    // zápis do souboru v pořadím datum, id, omega
                    sWriter.WriteLine($"Datum: {datum}, ID: {id}, Omega: {omega}");
                    // donucení zapsání
                    sWriter.Flush();
                    // uzavření StreamWriteru
                    sWriter.Close();
                }
            }
            catch
            {
                MessageBox.Show("Hodnoty musí být číslo.");
            }
        }
    }
}