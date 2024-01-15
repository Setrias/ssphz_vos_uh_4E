using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace caesarova_sifra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string text, sifra;
        private int posun;
        private char shiftedChar;

        private char[] vynechaneZnaky = { ',', ' ', '.', '?', '!' };

        private Dictionary<char, char> diaktritika = new Dictionary<char, char>
        {
            { 'Á', 'A' },
            { 'á', 'a' },
            { 'č', 'c' },
            { 'ď', 'd' },
            { 'ě', 'e' },
            { 'é', 'e' },
            { 'í', 'i' },
            { 'ň', 'n' },
            { 'ó', 'o' },
            { 'ř', 'r' },
            { 'š', 's' },
            { 'ť', 't' },
            { 'ú', 'u' },
            { 'ů', 'u' },
            { 'ý', 'y' },
            { 'ž', 'z' }
        };

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            int letterNum;
            sifra = "";
            text = textBoxSlova.Text;
            posun = (int)numericUpDownPosun.Value;

            // string normalizedString = text.Normalize(NormalizationForm.FormD);
            // StringBuilder stringBuilder = new StringBuilder();
            //
            // foreach (char c in normalizedString)
            // {
            //     if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
            //     {
            //         stringBuilder.Append(c);
            //     }
            // }
            // MessageBox.Show(stringBuilder.ToString());

            foreach (char letter in text)
            {
                if (!vynechaneZnaky.Contains(letter))
                {
                    if (diaktritika.ContainsKey(letter))
                    {
                        letterNum = diaktritika[letter];
                    }
                    else
                    {
                        letterNum = letter;
                    }

                    shiftedChar = (char)(letterNum + posun);

                    // pro malé písmena
                    if (letter >= 97 && letter <= 122)
                    {
                        if (shiftedChar > 122)
                        {
                            // shiftedChar = (char)(letter - 26 + posun);
                            shiftedChar = Convert.ToChar(letter - 26 + posun);
                        }
                    }

                    // pro velké písmena
                    if (letter >= 65 && letter <= 90)
                    {
                        if (shiftedChar > 90)
                        {
                            // shiftedChar = (char)(letter - 26 + posun);
                            shiftedChar = Convert.ToChar(letter - 26 + posun);
                        }
                    }

                    sifra += shiftedChar;
                }
                else
                {
                    sifra += letter;
                }
            }

            textBoxSifra.Text = sifra;
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            sifra = textBoxSifra.Text;
            text = "";
            posun = (int)numericUpDownPosun.Value;

            foreach (char letter in sifra)
            {
                if (!vynechaneZnaky.Contains(letter))
                {
                    shiftedChar = (char)(letter - posun);

                    // pro malé písmena
                    if (letter >= 97 && letter <= 122)
                    {
                        if (shiftedChar < 97)
                        {
                            shiftedChar = (char)(letter + 26 - posun);
                        }
                    }

                    // pro velké písmena
                    if (letter >= 65 && letter <= 90)
                    {
                        if (shiftedChar < 65)
                        {
                            shiftedChar = (char)(letter + 26 - posun);
                        }
                    }

                    text += shiftedChar;
                }
                else
                {
                    text += letter;
                }
            }

            textBoxSlova.Text = text;
        }
    }
}