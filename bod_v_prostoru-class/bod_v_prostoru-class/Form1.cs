using System;
using System.Windows.Forms;

namespace bod_v_prostoru_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double realne, imaginarni;
        private bool error = false;

        private void buttonUloz_Click(object sender, EventArgs e)
        {
            try
            {
                realne = Convert.ToDouble(textBoxCisloRe.Text);
                imaginarni = Convert.ToDouble(textBoxCisloIm.Text);
            }
            catch
            {
                MessageBox.Show("Zadej číslo.");
                error = true;
            }

            if (!error)
            {
                KomplexniCislo kompCislo = new KomplexniCislo(realne, imaginarni);

                textBoxVypisRe.Text = Convert.ToString(kompCislo.UrciRe());
                textBoxVypisIm.Text = Convert.ToString(kompCislo.UrciIm());
                textBoxVypisAbs.Text = Convert.ToString(kompCislo.UrciAbsHod());
            }
        }

        private double x, y, z;

        private void buttonBod3D_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(textBoxSourX.Text);
                y = Convert.ToDouble(textBoxSourY.Text);
                z = Convert.ToDouble(textBoxSourZ.Text);

                VzdalenostOdPocatecnihoBodu(x, y, z);
            }
            catch
            {
                MessageBox.Show("Zadej celé číslo jako souřadnice.");
            }
        }

        private void VzdalenostOdPocatecnihoBodu(double x, double y, double z)
        {
            Bod3D bod3d = new Bod3D(x, y, z);

            textBoxVzdalenostOdPocatku.Text = bod3d.VzdalenostOdPocatku().ToString();

            textBoxVzdalenostOdPocatku3D.Text = bod3d.VzdalenostOdPocatku3D().ToString();
        }
    }
}