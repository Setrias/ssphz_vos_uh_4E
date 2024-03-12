using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indukcnost_civky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct HodnotyMereni
        {
            public double napeti;
            public double proud;
            public double indukcnost;
        }

        private HodnotyMereni[] mereni = new HodnotyMereni[10];
        private double frekvence = 50, odporCivky;
        private int pocetHodnot;

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            try
            {
                double odpor = Convert.ToDouble(textBoxOdporCivky.Text);
                double napeti = Convert.ToDouble(textBoxNapeti.Text);
                double proud = Convert.ToDouble(textBoxProud.Text);

                if (odpor > 0 && napeti > 0 && proud > 0)
                {
                    odporCivky = odpor;

                    if (napeti <= 20 && proud <= 400)
                    {
                        mereni[pocetHodnot].napeti = napeti;
                        mereni[pocetHodnot].proud = proud / 1000; // přepočet na základní jednotky

                        // vypocet indukcnosti
                        double omega = 2 * Math.PI * frekvence;
                        double indukcnost = 
                            Math.Sqrt(
                                Math.Pow(
                                    napeti, 2
                                    ) / 
                                Math.Pow(
                                    proud / 1000, 2
                                    ) + 
                                Math.Pow(
                                    odporCivky, 2
                                    )
                                ) 
                            / omega;

                        mereni[pocetHodnot].indukcnost = indukcnost;

                        listBoxHodnoty.Items.Add($"U = {napeti}, I = {proud}, L = {indukcnost}");

                        textBoxOdporCivky.Enabled = false;
                        pocetHodnot++;

                        if (pocetHodnot == 10)
                        {
                            buttonZadat.Enabled = false;
                            Vysledky();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Napětí musí být měnší než 20V a proud musí být menší než 400mA.");
                    }
                }
                else
                {
                    MessageBox.Show("Zadané hodnoty musí být kladné číslo");
                }
            }
            catch
            {
                MessageBox.Show("Zadaná hodnota musí být číslo.");
            }
        }

        private void Vysledky()
        {
            double soucetIndukcnost = 0;
            double maxL = mereni[0].indukcnost;
            int pocetMereniNadPetV = 0;

            foreach (var zaznam in mereni)
            {
                // soucet indukcnosti
                soucetIndukcnost += zaznam.indukcnost;

                // nejvetsi induknost
                if (maxL < zaznam.indukcnost)
                {
                    maxL = zaznam.indukcnost;
                }

                // pocet mereni nad 5V
                if (zaznam.napeti > 5)
                {
                    pocetMereniNadPetV++;
                }
            }

            textBoxIndukcnost.Text = Math.Round(soucetIndukcnost / 10, 1).ToString();
            textBoxMaxIndukcnost.Text = maxL.ToString();
            textBoxPocetNadPetV.Text = pocetMereniNadPetV.ToString();
        }
    }
}