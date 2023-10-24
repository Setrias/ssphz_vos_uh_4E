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

        private void buttonBod3D_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}