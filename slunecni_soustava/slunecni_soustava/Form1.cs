using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slunecni_soustava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string nazevPlanety;
        private double obeznaDoba;

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            nazevPlanety = textBoxNazevPlanety.Text;
            try
            {
                obeznaDoba = Convert.ToDouble(textBoxObeznaDoba.Text);

                if (obeznaDoba <= 0)
                {
                    MessageBox.Show("Oběžná doba musí být kladné číslo.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Oběžná doba musí být kladné reálné číslo");
                return;
            }
        }
    }
}