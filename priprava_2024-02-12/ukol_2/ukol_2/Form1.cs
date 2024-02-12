using System;
using System.Drawing;
using System.Windows.Forms;

namespace ukol_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CoulombovaKonstanta = 8.99e9;
        private double polomerKoule = 0.05, nabojKoule = 110e-9;
        private double vzdalenost, intenzita;

        private Graphics graf;
        private int width, height;
        private Pen pero = new Pen(Color.Blue, 2);

        private void panelGraf_Paint(object sender, PaintEventArgs e)
        {
            graf = panelGraf.CreateGraphics();
            width = panelGraf.Width;
            height = panelGraf.Height;
        }

        private void buttonVypocitat_Click(object sender, EventArgs e)
        {
            try
            {
                vzdalenost = Convert.ToDouble(textBoxVzdalenost.Text);

                if (vzdalenost < 0 && vzdalenost > 2)
                {
                    MessageBox.Show("");
                    return;
                }

                intenzita = CoulombovaKonstanta * nabojKoule / Math.Pow(vzdalenost, 2);
                NakreslitGraf();

                textBoxIntenzita.Text = Convert.ToString(intenzita);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Zadej platné číslo. " + exception);
            }
        }

        private void NakreslitGraf()
        {
            panelGraf.Refresh();
            listBoxEh.Items.Clear();
            float prevY;
            float nextY;

            float krokVypocet = (float)0.01;

            // aby se graf vlezl vertikálně
            // float krokVypocetY = (float)(height / (CoulombovaKonstanta * nabojKoule / Math.Pow(0.01, 2)));

            for (float i = 0; i < width; i++)
            {
                prevY = (float)(CoulombovaKonstanta * nabojKoule / Math.Pow(krokVypocet, 2));
                listBoxEh.Items.Add(i + ". PREV: " + prevY);

                krokVypocet += (float)0.01;

                nextY = (float)(CoulombovaKonstanta * nabojKoule / Math.Pow(krokVypocet, 2));
                listBoxEh.Items.Add(i + ". NEXT: " + prevY);

                graf.DrawLine(pero, i - 1, -prevY + height, i, -nextY + height);

                // aby se graf vlezl vertikálně
                // graf.DrawLine(pero, i - 1, krokVypocetY * (-prevY) + height, i, krokVypocetY * (-nextY) + height);
            }
        }
    }
}