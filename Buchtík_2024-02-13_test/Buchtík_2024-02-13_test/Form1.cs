using System;
using System.Drawing;
using System.Windows.Forms;

namespace Buchtík_2024_02_13_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics vystrazne;
        private int tik;

        private Graphics grafZavislost;

        // Ukol 1
        private void panelVystrazne_Paint(object sender, PaintEventArgs e)
        {
            // inicializace panelu
            vystrazne = panelVystrazne.CreateGraphics();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // zapnuti timeru
            timerVystrazne.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // vypnuti timeru
            timerVystrazne.Enabled = false;
            // "vypnuti" vystrazneho svetla
            vystrazne.Clear(Color.Gray);
        }

        private void timerVystrazne_Tick(object sender, EventArgs e)
        {
            tik++;
            // refresh panelu, kresleni vystrazneho svetla, interval je nastaven na 500ms
            switch (tik)
            {
                case 1:
                    panelVystrazne.Refresh();
                    vystrazne.FillEllipse(Brushes.DarkOrange, 20, 20, 160, 160);
                    break;
                case 3:
                    panelVystrazne.Refresh();
                    vystrazne.Clear(Color.Gray);
                    tik = 0;
                    break;
            }
        }

        // Ukol 2
        private double permitivita = 8.85 * 10e-12;
        private double plocha = 0.0012;
        private double eta, etaR = 1, kapacita;
        private double[] vzdalenosti = { 0.5, 1, 1.5, 2 }; // v milimetrech

        private Pen pero = new Pen(Color.Blue, 2);

        private void panelZavislost_Paint(object sender, PaintEventArgs e)
        {
            // inicializace panelu
            grafZavislost = panelZavislost.CreateGraphics();
            eta = permitivita * etaR;

            // vypocet hodnot pomoci zadanych vzdalenosti z pole
            for (int i = 0; i < 4; i++)
            {
                kapacita = eta * (plocha / (vzdalenosti[i] / 1000)); // vypocet, prevod vzdalenosti na metry
                listBoxVypocty.Items.Add("Vzdálenost: " + vzdalenosti[i] + "mm, kapacita: " + kapacita + "F");
            }

            // vypocet promennych potrebnych k vykresleni zavislosti
            int width = panelZavislost.Width, height = panelZavislost.Height;
            float krokY = (float)(2.0 / 50), krokKresleni = krokY;

            float prevY, nextY;

            for (int i = 0; i < width; i++)
            {
                // vypocet Y hodnot
                prevY = (float)(eta * (plocha / (krokKresleni)));
                krokKresleni += krokY;
                nextY = (float)(eta * (plocha / (krokKresleni)));

                // kresleni krivky, vynasobeni kvuli viditelnosti hodnot
                grafZavislost.DrawLine(
                    Pens.Blue,
                    i,
                    (-prevY * (float)(10e14)) + height,
                    i + 1,
                    (-nextY * (float)(10e14)) + height);
            }
        }
    }
}