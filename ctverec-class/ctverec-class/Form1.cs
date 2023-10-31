using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctverec_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double delkaStrany;

        private void buttonVypocitat_Click(object sender, EventArgs e)
        {
            try
            {
                delkaStrany = Convert.ToDouble(textBoxDelkaStrany.Text);

                if (delkaStrany > 0)
                {
                    VypisVlastnosti();
                }
                else
                {
                    MessageBox.Show("Délka strany musí být kladná.");
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo.");
            }
        }

        private void VypisVlastnosti()
        {
            Ctverec ctverec = new Ctverec(delkaStrany);

            textBoxObvod.Text = ctverec.Obvod().ToString();
            textBoxObsah.Text = ctverec.Obsah().ToString();
            textBoxUhlopricka.Text = ctverec.Uhlopricka().ToString();
            textBoxKrOpsana.Text = ctverec.KruzniceOpsana().ToString();
            textBoxKrVepsana.Text = ctverec.KruzniceVepsana().ToString();
        }
    }
}