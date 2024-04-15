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
            buttonVyberRok.Enabled = false;
        }

        struct Udaje
        {
            public string jmeno;
            public int rok;
        }

        private Udaje[] _udaje;
        private string jmeno, rok;
        private StreamReader sReader;
        private StreamWriter sWriter;
        private string soubor;

        private void buttonVybratSoubor_Click(object sender, EventArgs e)
        {
            // vytvoření instance dialogu pro uložení souboru
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory(); // výchozí složka po otevření dialogu
            saveFileDialog.FileName = "soubor.txt"; // výchozí název souboru
            saveFileDialog.Filter = "Textové soubory (*.txt)|*.txt"; // filtr souborů pro omezení výběru pouze na .txt soubory

            // výběr / pojmenování souboru
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // po výběru / pojmenování souboru se převezme název souboru
                soubor = saveFileDialog.FileName;
            }
        }

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            jmeno = textBoxJmeno.Text.Trim();
            rok = textBoxRok.Text.Trim();

            if (jmeno.Contains(" "))
            {
                MessageBox.Show("Zadej POUZE jméno.");
                return;
            }

            sWriter = new StreamWriter(soubor, true); // vytvoří se StreamWriter s vybraným souborem
            sWriter.Write($"{jmeno} {rok}\n");
            sWriter.Flush();
            sWriter.Close();
        }

        private void buttonPrecist_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            fileDialog.Filter = "Textové soubory (*.txt)|*.txt"; // filtr souborů pro omezení výběru pouze na .txt soubory

            string file;
            int radek = 0;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                file = fileDialog.FileName; // název souboru

                // přečte všechny řádky souboru a spočítá je (JE TO NÁROČNÉ NA MEMORY)
                int pocetRadku = File.ReadAllLines(file).Length;
                _udaje = new Udaje[pocetRadku]; // vytvoření pole záznamů o velikosti počtu řádků

                sReader = new StreamReader(file);

                string souborRadek;
                while ((souborRadek = sReader.ReadLine()) != null)
                {
                    // rozdělení na jméno a rok
                    jmeno = souborRadek.Split(' ')[0];
                    rok = souborRadek.Split(' ')[1];

                    try
                    {
                        _udaje[radek].jmeno = jmeno;
                        _udaje[radek].rok = Convert.ToInt32(rok);
                    }
                    catch
                    {
                        MessageBox.Show("Chyba při čtení dat ze souboru. Data musí být ve správném formátu ([string]{jmeno} [int]{rok}).");
                    }

                    radek++;
                }

                sReader.Close();
                buttonVyberRok.Enabled = true;
            }
        }

        private void buttonVyberRok_Click(object sender, EventArgs e)
        {
            listBoxVyber.Items.Clear();
            int zadanyRok = (int)numericUpDownVyberRok.Value;

            foreach (var udaj in _udaje)
            {
                if (udaj.rok == zadanyRok)
                {
                    listBoxVyber.Items.Add(udaj.jmeno);
                }
            }
        }
    }
}