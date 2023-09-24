using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hra_kamen_nuzky_papir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        private Graphics fieldPlayer;
        private Graphics fieldComputer;
        private Pen pero = new Pen(Color.Black, 2);

        private int playerScore, compScore;

        private void Setup()
        {
            timer_current.Enabled = true;
            labelCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");

            labelPlayerScore.Text = "0";
            labelCompScore.Text = "0";
        }

        private void timer_current_Tick(object sender, EventArgs e)
        {
            labelCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void panelPlayer_Paint(object sender, PaintEventArgs e)
        {
            fieldPlayer = panelPlayer.CreateGraphics();
            fieldPlayer.DrawLine(pero, 548, 0, 548, 657);
        }

        private void panelComputer_Paint(object sender, PaintEventArgs e)
        {
            fieldComputer = panelComputer.CreateGraphics();
            fieldComputer.DrawLine(pero, 1, 0, 1, 657);
        }

        private void optionRock_Click(object sender, EventArgs e)
        {
            OptionChosen(0);
        }

        private void optionScissors_Click(object sender, EventArgs e)
        {
            OptionChosen(1);
        }

        private void optionPaper_Click(object sender, EventArgs e)
        {
            OptionChosen(2);
        }

        private void OptionChosen(int option)
        {
            Random randOption = new Random();
            int compOption = randOption.Next(0, 3);

            DisplayAnswer(0, option);
            DisplayAnswer(1, compOption);

            // když je výběr stejný -> remíza
            if (Equals(option, compOption))
            {
                labelState.Text = "Remíza";
            }

            if (option == 0 && compOption == 1)
            {
                playerScore++;
                labelPlayerScore.Text = playerScore.ToString();
                labelState.Text = "<< Vyhrál";
            }

            if (option == 1 && compOption == 2)
            {
                playerScore++;
                labelPlayerScore.Text = playerScore.ToString();
                labelState.Text = "<< Vyhrál";
            }

            if (option == 2 && compOption == 0)
            {
                playerScore++;
                labelPlayerScore.Text = playerScore.ToString();
                labelState.Text = "<< Vyhrál";
            }

            if (compOption == 0 && option == 1)
            {
                compScore++;
                labelCompScore.Text = compScore.ToString();
                labelState.Text = "Vyhrál >>";
            }

            if (compOption == 1 && option == 2)
            {
                compScore++;
                labelCompScore.Text = compScore.ToString();
                labelState.Text = "Vyhrál >>";
            }

            if (compOption == 2 && option == 0)
            {
                compScore++;
                labelCompScore.Text = compScore.ToString();
                labelState.Text = "Vyhrál >>";
            }
        }

        private void DisplayAnswer(int box, int option)
        {
            if (box == 0)
            {
                answerPlayer.Image = Image.FromFile(GetImage(option));
            }

            if (box == 1)
            {
                answerComputer.Image = Image.FromFile(GetImage(option));
            }
        }

        private string GetImage(int option)
        {
            switch (option)
            {
                case 0:
                    return "../../images/rock.png";
                case 1:
                    return "../../images/scissors.png";
                case 2:
                    return "../../images/paper.png";
                default:
                    return "Error";
            }
        }
    }
}