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

namespace maturita_priprava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Hodnoty
        {
            public int mereni;
            public double amplituda;
        }

        private Hodnoty[] hodnoty = new Hodnoty[23];

        private Graphics graf;
        private int sirka, vyska;

        private string jmeno, datum;
        private int pocetZadani;
        private double celkovySoucet, soucet;
        private double celkovyPrumer, prumer;

        private StreamReader sReader;
        private StreamWriter sWriter;

        private Pen pero = new Pen(Color.Blue, 2);

        private void panelGraf_Paint(object sender, PaintEventArgs e)
        {
            graf = panelGraf.CreateGraphics();

            sirka = panelGraf.Width;
            vyska = panelGraf.Height;
        }


        private void buttonPrecist_Click(object sender, EventArgs e)
        {
            if (!File.Exists("soubor_zadani.txt"))
            {
                MessageBox.Show("Požadovaný soubor neexistuje.");
                return;
            }

            // Načtení hodnot ze souboru

            sReader = new StreamReader("soubor_zadani.txt");
            string souborRadek;
            while ((souborRadek = sReader.ReadLine()) != null)
            {
                listBoxHodnoty.Items.Add(souborRadek);

                try
                {
                    int mereni = Convert.ToInt32(souborRadek.Split(' ')[1]);
                    double amplituda = Convert.ToDouble(souborRadek.Split(' ')[3]);

                    hodnoty[pocetZadani].mereni = mereni;
                    hodnoty[pocetZadani].amplituda = amplituda;
                    pocetZadani++;
                }
                catch
                {
                    MessageBox.Show("Data v souboru jsou ve špatném formátu a nemohly být načteny.");
                    return;
                }
            }

            // Výpočet průměrů

            // celkový součet (suma)
            foreach (var udaj in hodnoty)
            {
                celkovySoucet += udaj.amplituda;
            }

            // průmer 10 až 20 (suma)
            for (int i = 10; i < 20; i++)
            {
                soucet += hodnoty[i].amplituda;
            }

            celkovyPrumer = celkovySoucet / hodnoty.Length;
            prumer = soucet / 10;

            textBoxCelkovyPrumer.Text = celkovyPrumer.ToString();
            textBoxPrumer.Text = prumer.ToString();

            // Vykreslení grafu

            int x = 0;
            float y, prevY;
            double maxAmplituda = hodnoty[0].amplituda;

            foreach (var udaj in hodnoty)
            {
                if (maxAmplituda < udaj.amplituda)
                {
                    maxAmplituda = udaj.amplituda;
                }
            }

            float krokX = (float)(sirka / 23.0);
            float krokY = (float)(vyska / maxAmplituda);

            graf.DrawLine(pero, hodnoty[0].mereni * krokX, vyska - (float)hodnoty[0].amplituda * krokY, hodnoty[1].mereni * krokX,
                vyska - (float)hodnoty[1].amplituda * krokY);

            for (int i = 1; i < hodnoty.Length; i++)
            {
                graf.DrawLine(pero, hodnoty[i - 1].mereni * krokX, vyska - (float)hodnoty[i - 1].amplituda * krokY, hodnoty[i].mereni * krokX,
                    vyska - (float)hodnoty[i].amplituda * krokY);
            }
        }

        private void buttonZapsat_Click(object sender, EventArgs e)
        {
            jmeno = textBoxJmeno.Text;
            string datum = DateTime.Now.ToString("dd.MM.yy");

            try
            {
                sWriter = new StreamWriter("zaznam.txt", true);
                sWriter.WriteLine($"Jméno: {jmeno}, datum: {datum}, celkový průměr: {celkovyPrumer}, prumer 10 až 20: {prumer}");
                sWriter.Flush();
                sWriter.Close();
            }
            catch
            {
                MessageBox.Show("Nepodařilo se zapsat do souboru.");
            }
        }
    }
}