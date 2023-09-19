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

namespace Buchtík_2023_09_19_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // vytvoření proměnných
        struct zaznamy
        {
            public double tepVzduchu;
            public double tepVody;
            public double tlak;
        }

        // pole záznamu o velikosti 7 (týden)
        private zaznamy[] zaznam = new zaznamy[7];
        private int pocetZaznamu;
        private double soucetTepVzduch, prumerTepVzduch, maxTepVody;

        private void buttonZapis_Click(object sender, EventArgs e)
        {
            try
            {
                // zkouška převodu, jen čísla jsou povoleny
                zaznam[pocetZaznamu].tepVzduchu = Convert.ToDouble(textBoxTepVzduch.Text);
                zaznam[pocetZaznamu].tepVody = Convert.ToDouble(textBoxTepVoda.Text);
                zaznam[pocetZaznamu].tlak = Convert.ToDouble(textBoxTlak.Text);

                // tlak nesmí být záporný
                if (zaznam[pocetZaznamu].tlak < 0)
                {
                    return;
                }

                // po otestování tlaku a kladném výsledku se zvýší počet záznamu
                pocetZaznamu++;

                if (pocetZaznamu >= 7)
                {
                    buttonZapis.Enabled = false;

                    maxTepVody = zaznam[0].tepVody;
                    // hledá se nejvyšší teplota vody a počítá se součet a potom průměr teploty vzduchu
                    for (int i = 0; i < 7; i++)
                    {
                        soucetTepVzduch += zaznam[i].tepVzduchu;
                        if (i > 0)
                        {
                            if (maxTepVody < zaznam[i].tepVody)
                            {
                                maxTepVody = zaznam[i].tepVody;
                            }
                        }
                    }

                    prumerTepVzduch = soucetTepVzduch / 7;
                    // zavolá se funkce zápisu do souboru
                    zapisDoSouboru();
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo.");
            }
        }

        private StreamWriter sWriter;

        private void zapisDoSouboru()
        {
            // vytvoří se sWriter s názvem souboru a nastavením že jej má vytvořit a nebo přidat za existující text v souboru
            sWriter = new StreamWriter("Zaznam_udaju_koupaliste.txt", true);
            // jen když soubor existuje / podařil se vytvořit tak se program pokusí o zápis
            if (File.Exists("Zaznam_udaju_koupaliste.txt"))
            {
                sWriter.WriteLine("Datum: " + DateTime.Today.ToString("yyyy-MM-dd") + ", průměrná teplota vzduchu: " +
                                  prumerTepVzduch + "°C" + ", maximální teplota vody: " + maxTepVody + "°C");
                // vynutí se zápis
                sWriter.Flush();
                // sWriter se ukončí a tím uvolní soubor dalším aplikacím
                sWriter.Close();
            }
            else
            {
                MessageBox.Show("Údaje se nepovedlo zapsat protože soubor neexistuje.");
            }
        }
    }
}