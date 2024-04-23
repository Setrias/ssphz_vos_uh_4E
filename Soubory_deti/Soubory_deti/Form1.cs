using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Soubory_deti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Udaje
        {
            public string jmeno;
            public int vek;
            public double vyska;
            public double vaha;
        }

        private Udaje[] _udaje;
        private StreamReader sReader;
        private string nazevSouboru = "deti.txt";
        private int pocetUdaju;

        // Graf
        private Graphics graf;
        private int sirka, vyska;

        private void panelGraf_Paint(object sender, PaintEventArgs e)
        {
            graf = panelGraf.CreateGraphics();
            sirka = panelGraf.Width;
            vyska = panelGraf.Height;

            Graf(graf);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data();
            PocetTriletych();
            Dvoulete();
        }

        private void Data()
        {
            if (File.Exists(nazevSouboru))
            {
                sReader = new StreamReader(nazevSouboru);
                string[] radek;

                // počet řádků souboru
                int pocetRadku = File.ReadLines(nazevSouboru).Count();
                _udaje = new Udaje[pocetRadku];

                string souborRadek;
                while ((souborRadek = sReader.ReadLine()) != null)
                {
                    // rozdělení na jednotlivé části
                    radek = souborRadek.Trim().Split(' ');

                    // uložení a vypsání dat
                    try
                    {
                        _udaje[pocetUdaju].jmeno = radek[0];
                        _udaje[pocetUdaju].vek = Convert.ToInt32(radek[2]);
                        _udaje[pocetUdaju].vyska = Convert.ToDouble(radek[4]);
                        _udaje[pocetUdaju].vaha = Convert.ToDouble(radek[6]);

                        listBoxUdaje.Items.Add($"Jméno: {radek[0]}, věk: {radek[2]}, výška: {radek[4]}, váha: {radek[6]}");

                        pocetUdaju++;
                    }
                    catch
                    {
                        MessageBox.Show("Data v souboru mají špatný formát.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Soubor neexistuje");
            }
        }

        private void PocetTriletych()
        {
            int pocetTriletych = 0;

            foreach (var udaj in _udaje)
            {
                if (udaj.vek == 3)
                {
                    pocetTriletych++;
                }
            }

            textBoxPocetTriletych.Text = pocetTriletych.ToString();
        }

        private void Dvoulete()
        {
            double soucetVyska = 0, soucetVaha = 0;
            int pocetDvouletych = 0;

            foreach (var udaj in _udaje)
            {
                if (udaj.vek == 2)
                {
                    pocetDvouletych++;
                    soucetVyska += udaj.vyska;
                    soucetVaha += udaj.vaha;
                }
            }

            textBoxPrumVyskaDvouletych.Text = (soucetVyska / pocetDvouletych).ToString();
            textBoxPrumVahaDvouletych.Text = (soucetVaha / pocetDvouletych).ToString();
        }

        private void Graf(Graphics graf)
        {
            // podle zadání bod[výška v cm, hmotnost v kg] ([x, y])

            float maxVaha = (float)_udaje[0].vaha;
            float maxVyska = (float)_udaje[0].vyska;
            foreach (var udaj in _udaje)
            {
                if (udaj.vaha > maxVaha) maxVaha = (float)udaj.vaha;
                if (udaj.vyska > maxVyska) maxVyska = (float)udaj.vyska;
            }

            float krokX = (sirka - 10) / maxVaha;
            float krokY = (vyska - 10) / maxVyska;


            foreach (var dite in _udaje)
            {
                int x = (int)(krokX * dite.vaha);
                int y = (int)(400 - krokY * dite.vyska);
                //MessageBox.Show($"Souřadnice X: {x}, souřadnice Y: {y}");
                graf.FillRectangle(Brushes.Blue, x - 1, y - 1, 3, 3);
            }
        }
    }
}