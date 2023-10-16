using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukladani_cisel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActiveControl = textBoxZadavani;
            AcceptButton = buttonZadej;
        }

        // Program čte celá čísla, ukládá je do pole. Zadávání skončí po stisku klávesy 'x' nebo 'X'.
        //      a) Vypsat čísla se sudými indexy.
        //      b) Největší číslo z čísel s lichými indexy.
        //      c) Počet čísel větších než 100.
        //      d) Nejmenší kladné číslo.

        //private int[] poleCisel = { };
        private List<int> poleCisel = new List<int>();
        private int pocetZadani;

        private void buttonZadej_Click(object sender, EventArgs e)
        {
            var zadanaHodnota = textBoxZadavani.Text;

            if (zadanaHodnota == "X" || zadanaHodnota == "x")
            {
                buttonZadej.Enabled = false;
                KonecZadavani();
            }
            else
            {
                try
                {
                    int zadaneCislo = Convert.ToInt32(zadanaHodnota);
                    poleCisel.Add(zadaneCislo);
                    textBoxZadavani.Text = "";
                    pocetZadani++;
                }
                catch
                {
                    MessageBox.Show("Povoleny jsou pouze čísla nebo písmeno X.");
                }
            }
        }

        private void KonecZadavani()
        {
            SudeCisla();
            NejvetsiLiche();
            VetsiSto();
            NejmensiKladne();
        }

        private void SudeCisla()
        {
            for (int i = 0; i < poleCisel.Count; i++)
            {
                int cislo = poleCisel[i];
                if (cislo % 2 == 0)
                {
                    listBoxSude.Items.Add(cislo);
                }
            }
        }

        private void NejvetsiLiche()
        {
            List<int> licheCisla = new List<int>();

            for (int i = 0; i < poleCisel.Count; i++)
            {
                int cislo = poleCisel[i];
                if (cislo % 2 != 0)
                {
                    licheCisla.Add(cislo);
                }
            }

            textBoxMaxLiche.Text = Convert.ToString(poleCisel.Max());
        }

        private void VetsiSto()
        {
            List<int> nadSto = new List<int>();

            foreach (var cislo in poleCisel)
            {
                if (cislo > 100)
                {
                    nadSto.Add(cislo);
                }
            }

            textBoxVetsiSto.Text = Convert.ToString(nadSto.Count);
        }

        private void NejmensiKladne()
        {
            List<int> kladne = new List<int>();

            foreach (var cislo in poleCisel)
            {
                if (cislo > 0)
                {
                    kladne.Add(cislo);
                }
            }

            textBoxMinKladne.Text = Convert.ToString(kladne.Min());
        }
    }
}