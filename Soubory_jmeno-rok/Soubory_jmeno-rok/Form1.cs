using System;
using System.IO;
using System.Windows.Forms;

namespace Soubory_jmeno_rok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string jmeno, rok;
        private StreamReader sReader;
        private StreamWriter sWriter;

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            jmeno = textBoxJmeno.Text;
            rok = textBoxRok.Text;

            // vytvoření instance dialogu pro uložení souboru
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory(); // výchozí složka po otevření dialogu
            saveFileDialog.FileName = "soubor.txt"; // výchozí název souboru
            saveFileDialog.Filter = "Textové soubory (*.txt)|.txt"; // filtr souborů pro omezení výběru pouze na .txt soubory

            string file;
            // výběr / pojmenování souboru
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // po výběru / pojmenování souboru se převezme název souboru
                file = saveFileDialog.FileName;
                sWriter = new StreamWriter(file); // vytvoří se StreamWriter s vybraným souborem
                sWriter.Write($"{jmeno} {rok}");
                sWriter.Flush();
                sWriter.Close();
            }
        }

        private void buttonPrecist_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
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