using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prevod_ascii_char
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int ascii;
        private char znak;

        private void buttonAscii_Click(object sender, EventArgs e)
        {
            try
            {
                ascii = Convert.ToInt32(textBoxAscii.Text);

                listBoxVysledky.Items.Add(ascii + " >>> " + (char)ascii);
            }
            catch
            {
                MessageBox.Show("Zadej celé číslo.");
            }
        }

        private void buttonChar_Click(object sender, EventArgs e)
        {
            znak = Convert.ToChar(textBoxChar.Text[0]);

            listBoxVysledky.Items.Add(znak + " >>> " + (int)znak);
        }
    }
}