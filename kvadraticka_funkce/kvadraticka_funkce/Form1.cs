using System;
using System.Drawing;
using System.Windows.Forms;

namespace kvadraticka_funkce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxMeritko.SelectedIndex = 0;
        }

        private Graphics panelFunkce;
        private int width = 600;
        private int height = 600;

        private void panelKvadraticka_Paint(object sender, PaintEventArgs e)
        {
            panelFunkce = panelKvadraticka.CreateGraphics();
            OsaGrafu(width, height, panelFunkce);
        }

        // univerzální nakreslení osy x a y
        public void OsaGrafu(float width, float height, Graphics panel)
        {
            Pen blackAxisPen = new Pen(Color.Black, 2);
            Pen brownAxisPen = new Pen(Color.Brown, 2);
            Pen grayAxisPen = new Pen(Color.LightGray, 2);

            for (int i = 0; i < 10; i++)
            {
                // síť pozadí
                panel.DrawLine(grayAxisPen, 0, 0 + i * (height / 10), width, 0 + i * (height / 10));
                // čárky na vertikální ose
                panel.DrawLine(blackAxisPen, width / 2 - 10, 0 + i * (height / 10), width / 2 + 10, 0 + i * (height / 10));
                panel.DrawLine(brownAxisPen, width / 2 - 5, (height / 20) + i * (height / 10), width / 2 + 5, (height / 20) + i * (height / 10));

                // síť pozadí
                panel.DrawLine(grayAxisPen, 0 + i * (width / 10), 0, 0 + i * (width / 10), height);
                // čárky na horizontální ose
                panel.DrawLine(blackAxisPen, 0 + i * (width / 10), height / 2 - 10, 0 + i * (width / 10), height / 2 + 10);
                panel.DrawLine(brownAxisPen, (width / 20) + i * (width / 10), height / 2 - 5, (width / 20) + i * (width / 10), height / 2 + 5);
            }

            // vertikální
            panel.DrawLine(blackAxisPen, width / 2, 0, width / 2, height);
            // horizontální
            panel.DrawLine(blackAxisPen, 0, height / 2, width, height / 2);

            // vertikální poslední čára
            panel.DrawLine(Pens.Black, width / 2 - 10, height - 3, width / 2 + 10, height - 3);
            // horizontální poslední čára
            panel.DrawLine(Pens.Black, width - 3, height / 2 - 10, width - 3, height / 2 + 10);
        }

        private float clenA, clenB, clenC;
        private int meritko;

        private void buttonVykreslit_Click(object sender, EventArgs e)
        {
            try
            {
                clenA = Convert.ToSingle(textBoxA.Text);
                clenB = Convert.ToSingle(textBoxB.Text);
                clenC = Convert.ToSingle(textBoxC.Text);
                meritko = comboBoxMeritko.SelectedIndex;

                switch (meritko)
                {
                    case 0:
                        meritko = 10;
                        break;
                    case 1:
                        meritko = 20;
                        break;
                    case 2:
                        meritko = 30;
                        break;
                    case 3:
                        meritko = 40;
                        break;
                }

                if (clenA == 0)
                {
                    MessageBox.Show("Člen 'a' nesmí být 0!");
                    return;
                }

                panelKvadraticka.Refresh();
                DrawQuadraticFunction(clenA, clenB, clenC, meritko, panelFunkce);
            }
            catch
            {
                MessageBox.Show("Zadaná hodnota musí být číslo!");
            }
        }

        public void DrawQuadraticFunction(float numA, float numB, float numC, int meritko, Graphics panel)
        {
            // Definice parametrů kvadratické funkce
            float a = numA; // koeficient a
            float b = numB; // koeficient b
            float c = numC; // koeficient c

            // Definice rozsahu x-ové osy
            float startX = -20;
            float endX = 20;

            // Definice šířky a výšky kreslící plochy

            float prevX = 0, prevY = 0;
            bool prvni = false;

            Pen pero = new Pen(Color.Red, 2);

            // Kreslení kvadratické funkce
            for (float x = startX; x < endX; x += Convert.ToSingle(0.1))
            {
                float y = a * x * x + b * x + c;

                // Převod souřadnic do pixelů
                float pixelX = width / 2 + x * meritko;
                float pixelY = height / 2 - y * meritko;

                if (prvni)
                {
                    panel.DrawLine(pero, prevX, prevY, pixelX, pixelY);
                }
                else
                {
                    prvni = true;
                }

                prevX = pixelX;
                prevY = pixelY;
            }
        }
    }
}