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
        }
        
        // Program čte celá čísla, ukládá je do pole. Zadávání skončí po stisku klávesy 'x' nebo 'X'.
        //      a) Vypsat čísla se sudými indexy.
        //      b) Největší číslo z čísel s lichými indexy.
        //      c) Počet čísel větších než 100.
        //      d) Nejmenší kladné číslo.

        private int[] poleCisel = {};
        private int pocetZadani;
        
        private void buttonZadej_Click(object sender, EventArgs e)
        {
            var zadanaHodnota = textBoxZadavani.Text;
            
            if (zadanaHodnota != "X" || zadanaHodnota != "x")
            {
                try
                {
                    int zadaneCislo = Convert.ToInt32(zadanaHodnota);
                    poleCisel[pocetZadani] = zadaneCislo;
                    pocetZadani++;
                }
                catch
                {
                    MessageBox.Show("Povoleny jsou pouze čísla nebo 'x', 'X'.");
                }
            }
            else
            {
                buttonZadej.Enabled = false;
                KonecZadavani();
            }
        }

        private void KonecZadavani()
        {
            
        }
    }
}