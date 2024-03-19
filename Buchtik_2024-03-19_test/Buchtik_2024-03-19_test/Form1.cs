using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchtik_2024_03_19_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private struct Uchazec
        {
            public string id;
            public int pocetBoduTestu;
            public int znamkaMat;
            public int znamkaFyz;
            public int celkovyPocetBodu;
        }

        private Uchazec[] Uchazeci = new Uchazec[10];

        private string kod;
        private int pocetBodu, znamkaMat, znamkaFyz, bodyCelkem, pocetUchazecu, nejBodu = 0;

        private void buttonUloz_Click(object sender, EventArgs e)
        {
            try
            {
                kod = textBoxKod.Text;
                pocetBodu = Convert.ToInt32(textBoxTest.Text);
                znamkaMat = Convert.ToInt32(textBoxMat.Text);
                znamkaFyz = Convert.ToInt32(textBoxFyz.Text);

                if (pocetBodu < 0 && pocetBodu > 100)
                {
                    MessageBox.Show("Počet bodů musí být v rozmezí od 0 do 100 bodů");
                    return;
                }

                // vypocet bodu celkem
                bodyCelkem = 0;
                bodyCelkem += pocetBodu;
                bodyCelkem += BodyZaZnamky(znamkaMat);
                bodyCelkem += BodyZaZnamky(znamkaFyz);

                if (bodyCelkem > nejBodu)
                {
                    nejBodu = bodyCelkem;
                    textBoxZakNejBody.Text = $"ID: {kod}, celkem bodů: {bodyCelkem}";
                }

                // ukladani uchazecu
                Uchazeci[pocetUchazecu].id = kod;
                Uchazeci[pocetUchazecu].pocetBoduTestu = pocetBodu;
                Uchazeci[pocetUchazecu].znamkaMat = znamkaMat;
                Uchazeci[pocetUchazecu].znamkaFyz = znamkaFyz;
                Uchazeci[pocetUchazecu].celkovyPocetBodu = bodyCelkem;

                listBoxVypis.Items.Add($"ID: {kod}, celkem bodů: {bodyCelkem}");

                pocetUchazecu++;

                if (pocetUchazecu >= 10)
                {
                    buttonUloz.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Počet bodů, známka z MAT a FYZ mají být čísla.");
            }
        }

        private int BodyZaZnamky(int znamka)
        {
            int body;

            switch (znamka)
            {
                case 1:
                    body = 15;
                    break;
                case 2:
                    body = 10;
                    break;
                case 3:
                    body = 5;
                    break;
                default:
                    body = 0;
                    break;
            }

            return body;
        }
    }
}