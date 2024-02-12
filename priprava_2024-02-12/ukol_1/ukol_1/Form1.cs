using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics kresleni;
        private bool prejezdAktivni;
        private int tick, sirka, vyska;

        private void panelPrejezd_Paint(object sender, PaintEventArgs e)
        {
            kresleni = panelPrejezd.CreateGraphics();

            sirka = panelPrejezd.Width;
            vyska = panelPrejezd.Height;
        }

        private void buttonPrejezd_Click(object sender, EventArgs e)
        {
            if (prejezdAktivni)
            {
                // vypnutí přejezdu
                prejezdAktivni = false;
                timerPrejezd.Enabled = false;
                kresleni.Clear(Color.Gray);
                buttonPrejezd.Text = "Aktivovat přejezd";
            }
            else
            {
                // zapnutí přejezdu
                prejezdAktivni = true;
                timerPrejezd.Enabled = true;
                buttonPrejezd.Text = "Deaktivovat přejezd";
            }
        }

        private void timerPrejezd_Tick(object sender, EventArgs e)
        {
            tick++;

            if (tick % 2 == 0)
            {
                panelPrejezd.Refresh();
                // levé světlo
                kresleni.FillEllipse(Brushes.Red, sirka / 16, vyska / 8, vyska / 8 * 6, vyska / 8 * 6);
            }
            else
            {
                panelPrejezd.Refresh();
                // pravé světlo
                kresleni.FillEllipse(Brushes.Red, sirka / 16 * 9, vyska / 8, vyska / 8 * 6, vyska / 8 * 6);
            }
        }
    }
}