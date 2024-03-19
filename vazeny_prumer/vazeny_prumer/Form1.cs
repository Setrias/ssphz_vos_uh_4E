using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vazeny_prumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonUlozit.Enabled = false;
        }

        private struct Znamky
        {
            public string predmet;
            public int[] znamky;
            public double prumer;
        }

        private Dictionary<string, Znamky> klasifikace = new Dictionary<string, Znamky>();

        private Znamky[] predmety;

        private List<int>[] znamky;

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBoxSubject.Items.Count; i++)
            {
                predmety[i] = klasifikace[(string)comboBoxSubject.Items[i]];
            }
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUlozit.Enabled = comboBoxSubject.SelectedText.Trim() == "";
        }
    }
}