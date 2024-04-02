using System;
using System.Windows.Forms;

namespace Buchtík_2024_04_02_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double R, L, C;
        private ObvodRLC obvod;
        
        private void buttonVypocitat_Click(object sender, EventArgs e)
        {
            try
            {
                R = Convert.ToDouble(textBoxR.Text);
                L = Convert.ToDouble(textBoxL.Text);
                C = Convert.ToDouble(textBoxC.Text);

                if (R <= 0 || L <= 0 || C <= 0)
                {
                    MessageBox.Show("Zadané hodnoty musí být kladné.");
                    return;
                }

                obvod = new ObvodRLC(R, L, C);

                textBoxDelta.Text = Convert.ToString(obvod.Delta());
                textBoxOmegaNula.Text = Convert.ToString(obvod.OmegaNula());
                textBoxOmega.Text = Convert.ToString(obvod.Omega());
            }
            catch
            {
                MessageBox.Show("Zadaná hodnota musí být číslo.");
            }
        }
    }
}