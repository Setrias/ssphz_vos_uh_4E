using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kvadraticka_funkce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics panelFunkce;
        KvadratickaFunkce funkce = new KvadratickaFunkce();

        private void panelKvadraticka_Paint(object sender, PaintEventArgs e)
        {
            panelFunkce = panelKvadraticka.CreateGraphics();
            funkce.OsaGrafu(600, 600, panelFunkce);
        }
    }
}