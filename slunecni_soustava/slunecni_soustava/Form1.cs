using System;
using System.IO;
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
        private StreamWriter sWriter;
        private StreamReader sReader;
        private FileDialog chooseFile = new OpenFileDialog();

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

                // Inicializace třídy
                Planety planety = new Planety(obeznaDoba);

                // Výpis výpočtů
                string vzdalenostAu = Convert.ToString(planety.VypisVzdalenostAu());
                textBoxVzdalenostAu.Text = vzdalenostAu;
                textBoxVzdalenostKm.Text = Convert.ToString(planety.VypisVzdalenostKm());
                textBoxPrumernaRychlost.Text = Convert.ToString(planety.PrumernaRychlostTelesa());

                // Otevření dialogu pro výběr souboru pro zápis
                if (chooseFile.ShowDialog() == DialogResult.OK)
                {
                    sWriter = new StreamWriter(chooseFile.FileName);
                    sWriter.Write("Název planety: " + nazevPlanety + ", oběžná doba [roky]: " + obeznaDoba + ", vzdálenost od slunce [AU]: " + vzdalenostAu);
                    sWriter.Flush();
                    sWriter.Close();
                }
            }
            catch
            {
                MessageBox.Show("Oběžná doba musí být kladné reálné číslo.");
            }
        }

        private void buttonVypisSouboru_Click(object sender, EventArgs e)
        {
            // Otevření dialogu pro výběr souboru pro výpis
            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                string radek;

                sReader = new StreamReader(chooseFile.FileName);
                while ((radek = sReader.ReadLine()) != null)
                {
                    listBoxTelesa.Items.Add(radek);
                }
            }
        }

        private void buttonVymaz_Click(object sender, EventArgs e)
        {
            textBoxNazevPlanety.Clear();
            textBoxObeznaDoba.Clear();
            textBoxPrumernaRychlost.Clear();
            textBoxVzdalenostAu.Clear();
            textBoxVzdalenostKm.Clear();
        }
    }
}