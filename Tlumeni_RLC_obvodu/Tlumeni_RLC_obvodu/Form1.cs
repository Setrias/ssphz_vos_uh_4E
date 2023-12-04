using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private Graphics panelTlumeni;
        private int panelWidth, panelHeight;
        private Pen peroBlue = new Pen(Color.Blue, 2);
        private Pen peroRed = new Pen(Color.Red, 2);

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

                if (odpor > 0 && indukcnost > 0 && kapacita > 0 && amplituda > 0 && cas > 0)
                {
                    Vypocitat();
                }
                else
                {
                    MessageBox.Show("Odpor, indukčnost, kapacita, amplituda a čas musí být větší než 0.");
                }
            }
            catch
            {
                MessageBox.Show("Zadané hodnoty musí být čísla.");
            }
        }

        private void Vypocitat()
        {
            _vypocty = new Vypocty(odpor, indukcnost, kapacita, fi, amplituda);

            textBoxTlumeni.Text = Convert.ToString(_vypocty.Tlumeni());
            textBoxOmegaNula.Text = _vypocty.OmegaNula().ToString();
            textBoxOmega.Text = _vypocty.Omega().ToString();
            textBoxOkamHodProudu.Text = _vypocty.OkamzitaHodnotaProudu(cas).ToString();

            panelGraph.Refresh();

            // Kreslení pomocí jednotlivých čar

            float prevY = Convert.ToSingle(_vypocty.OkamzitaHodnotaProudu(0));
            float krok = (float)cas / panelWidth;

            for (int x = 0; x < panelWidth; x++)
            {
                float y = Convert.ToSingle(_vypocty.OkamzitaHodnotaProudu(x * krok));
                panelTlumeni.DrawLine(peroBlue, x - 1, panelHeight / 2 + prevY, x, panelHeight / 2 + y);
                prevY = y;
            }


            // Kreslení pomocí 'DrawCurve' a 'PointF' bodů

            // float krok = (float)cas / panelWidth;
            // float yShift = panelHeight / 2;
            // float yMult = (float)amplituda * (panelHeight / 2.0f);

            // List<PointF> vysledek = new List<PointF>();
            // for (float x = 0; x < panelWidth; x++)
            // {
            //     float y = Convert.ToSingle(_vypocty.OkamzitaHodnotaProudu(x * krok));
            //     vysledek.Add(new PointF(x, yShift + y * yMult));
            // }
            //
            // panelTlumeni.DrawCurve(peroRed, vysledek.ToArray());


            // Kreslení na 50 bodů času
            // 'Volte takový interval, abyste pro graf měli 50 hodnot.'
            // 'vysledek2' jen pro kontrolu

            // List<PointF> vysledek2 = new List<PointF>();
            // List<PointF> vysledek3 = new List<PointF>();
            // krok = (float)cas / 50;
            // for (float x = 0; x <= 50; x++)
            // {
            // float t = x * krok;
            // float y = Convert.ToSingle(_vypocty.OkamzitaHodnotaProudu(t));
            // vysledek2.Add(new PointF(t, y));
            // vysledek3.Add(new PointF(t * panelWidth, yShift + y * yMult));
            // }
            //
            // panelTlumeni.DrawCurve(peroRed, vysledek3.ToArray());
        }

        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {
            panelTlumeni = panelGraph.CreateGraphics();

            panelWidth = panelGraph.Size.Width;
            panelHeight = panelGraph.Size.Height;

            panelTlumeni.DrawLine(Pens.Black, 0, 0, 0, panelHeight); // vertikální
            panelTlumeni.DrawLine(Pens.Black, 0, panelHeight / 2, panelWidth, panelHeight / 2); // horizontální
        }

        private void onOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = onOffToolStripMenuItem.Checked;
        }
    }
}