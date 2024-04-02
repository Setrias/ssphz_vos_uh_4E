using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soubory_jmeno_rok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stream stream;
        private string jmeno, rok;
        private StreamReader sReader;

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            jmeno = textBoxJmeno.Text;
            rok = textBoxRok.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".txt soubory (*.txt)";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                }
            }
        }

        private void buttonPrecist_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            string file;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                file = fileDialog.FileName;
                sReader = new StreamReader(file);
                string souborRadek;

                while ((souborRadek = sReader.ReadLine()) != null)
                {
                    jmeno = souborRadek.Split(' ')[0];
                    rok = souborRadek.Split(' ')[1];

                    textBoxJmeno.Text = jmeno;
                    textBoxRok.Text = rok;
                }

                sReader.Close();
            }
        }
    }
}