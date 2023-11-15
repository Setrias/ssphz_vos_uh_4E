using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kvadraticka_funkce_skola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            width = panelKvadraticka.Size.Width;
            height = panelKvadraticka.Size.Height;
        }

        private int width, height;
        private Graphics panel;
        private float clenA, clenB, clenC;

        private void panelKvadraticka_Paint(object sender, PaintEventArgs e)
        {
            panel = panelKvadraticka.CreateGraphics();

            panel.DrawLine(Pens.Black, width / 2, 0, width / 2, height);
            panel.DrawLine(Pens.Black, 0, height / 2, width, height / 2);
        }

        private bool prvni = false;
        private float prevX, prevY;

        private Pen pero = new Pen(Color.Crimson, 2);

        private void buttonVykreslit_Click(object sender, EventArgs e)
        {
            try
            {
                clenA = Convert.ToSingle(textBoxA.Text);
                clenB = Convert.ToSingle(textBoxB.Text);
                clenC = Convert.ToSingle(textBoxC.Text);

                if (clenA == 0)
                {
                    MessageBox.Show("Člen 'a' nesmí být 0.");
                    return;
                }

                panelKvadraticka.Refresh();
                float prevX = 0, prevY = 0;
                bool prvni = false;

                for (float x = -20; x <= 20; x += Convert.ToSingle(0.1))
                {
                    float y = clenA * x * x + clenB * x + clenC;

                    float pixelX = width / 2 + x * 10;
                    float pixelY = height / 2 - y * 10;

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
            catch
            {
                MessageBox.Show("Zadaná hodnota musí být číslo.");
            }
        }
    }
}