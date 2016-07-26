using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace RockPaperScissors
{

    public partial class Form1 : Form
    {
        int winsCounter = 0;
        int lossCounter = 0;
        int drawCounter = 0;

        int humanWins = 0;
        int AiWins = 0;

        private void newGame()
        {
            winsNumber.Text = 0.ToString();
            winsCounter = 0;
            losesNumber.Text = 0.ToString();
            lossCounter = 0;
            drawsNumber.Text = 0.ToString();
            drawCounter = 0;
        } 

        public void MB_YouWon()
        {
            DialogResult result = MessageBox.Show("New Game?", "You've Won!", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                newGame();
            }else { this.Close(); }
        }

        public void MB_YouLost()
        {
            DialogResult result = MessageBox.Show("New Game?", "You've Lost!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                newGame();
            }else { this.Close(); }
        }

        public void MB_Draw()
        {
            DialogResult result = MessageBox.Show("New Game?", "It's a Draw!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                newGame();
            }
            else { this.Close(); }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void btn_Rock_Click(object sender, EventArgs e)
        {
            rtb_console.Text = "You threw a rock!\n";
            pb_userChoice.Image = RockPaperScissors.Properties.Resources.rps_rock;
            
            Random rnd = new Random();
            int number = rnd.Next(1, 4);
            if (winsCounter <= 9 & lossCounter <= 9 & drawCounter <= 9)
            {
                switch (number) // random number by the computer
                {
                    case 1: // AI chose rock
                        rtb_console.AppendText(Environment.NewLine + "Gary chose rock, it's a tie.");
                        pb_AIchoice.Image = RockPaperScissors.Properties.Resources.rps_rock;

                        if (drawCounter <= 9)
                        {
                            drawCounter++;
                            drawsNumber.Text = drawCounter.ToString();
                        }
                        break;
                    case 2: // AI chose paper
                        rtb_console.AppendText(Environment.NewLine + "Gary caught your rock with some paper, you lose!");
                        pb_AIchoice.Image = RockPaperScissors.Properties.Resources.rps_paper;
                        if (lossCounter <= 9)
                        {
                            lossCounter++;
                            losesNumber.Text = lossCounter.ToString();
                        }
                        break;
                    case 3: // AI chose scissors
                        rtb_console.AppendText(Environment.NewLine + "Gary can't cut your rock with his scissors, you won!");
                        pb_AIchoice.Image = RockPaperScissors.Properties.Resources.rps_scissors;
                        if (winsCounter <= 9)
                        {
                            winsCounter++;
                            winsNumber.Text = winsCounter.ToString();
                        }
                        break;
                }
            }
            else
            {
                if (winsCounter == 10)
                {
                    humanWins++;
                    lb_humanWins.Text = humanWins.ToString();
                    MB_YouWon();
                }
                else if (lossCounter == 10)
                {
                    AiWins++;
                    lb_AIWins.Text = AiWins.ToString();
                    MB_YouLost();
                }
                else
                {
                    MB_Draw();
                }
            }
        }

        public void btn_Paper_Click(object sender, EventArgs e)
        {
            rtb_console.Text = "You threw some paper!\n";
            pb_userChoice.Image = RockPaperScissors.Properties.Resources.rps_paper;

            Random rnd = new Random();
            int number = rnd.Next(1, 4);
            if (winsCounter <= 9 & lossCounter <= 9 & drawCounter <= 9)
            {
                switch (number) // random number by the computer
                {
                    case 1: // AI chose rock
                        rtb_console.AppendText(Environment.NewLine + "Gary's rock can't escape your paper, you won!");
                        pb_AIchoice.Image = RockPaperScissors.Properties.Resources.rps_rock;

                        if (winsCounter <= 9)
                        {
                            winsCounter++;
                            winsNumber.Text = winsCounter.ToString();
                        }
                        break;

                    case 2: // AI chose paper
                        rtb_console.AppendText(Environment.NewLine + "You and Gary just sorta rub papers....tie?");
                        pb_AIchoice.Image = RockPaperScissors.Properties.Resources.rps_paper;

                        if (drawCounter <= 9)
                        {
                            drawCounter++;
                            drawsNumber.Text = drawCounter.ToString();
                        }
                        break;

                    case 3: // AI chose scissors
                        rtb_console.AppendText(Environment.NewLine + "Gary slices through your weak paper, you lose!");
                        pb_AIchoice.Image = RockPaperScissors.Properties.Resources.rps_scissors;

                        if (lossCounter <= 9)
                        {
                            lossCounter++;
                            losesNumber.Text = lossCounter.ToString();
                        }
                        break;

                }
            }
            else
            {
                if (winsCounter == 10)
                {
                    humanWins++;
                    lb_humanWins.Text = humanWins.ToString();
                    MB_YouWon();
                }
                else if (lossCounter == 10)
                {
                    AiWins++;
                    lb_AIWins.Text = AiWins.ToString();
                    MB_YouLost();
                }
                else
                {
                    MB_Draw();
                }
            }
        }

        public void btn_Scissors_Click(object sender, EventArgs e)
        {
            rtb_console.Text = "You stabbed him with some scissors!\n";
            pb_userChoice.Image = RockPaperScissors.Properties.Resources.rps_scissors;

            Random rnd = new Random();
            int number = rnd.Next(1, 4);
            
            if (winsCounter <= 9 & lossCounter <= 9 & drawCounter <= 9)
            {
                switch (number) // random number by the computer
                {
                    case 1: // AI chose rock
                        rtb_console.AppendText(Environment.NewLine + "Gary's rock shatters your scissors, you lose!");
                        pb_AIchoice.Image = RockPaperScissors.Properties.Resources.rps_rock;

                        if (lossCounter <= 9)
                        {
                            lossCounter++;
                            losesNumber.Text = lossCounter.ToString();
                        }
                        break;

                    case 2: // AI chose paper
                        rtb_console.AppendText(Environment.NewLine + "Gary's paper is no match for your deadly blade, you won!");
                        pb_AIchoice.Image = RockPaperScissors.Properties.Resources.rps_paper;

                        if(winsCounter <= 9)
                        {
                            winsCounter++;
                            winsNumber.Text = winsCounter.ToString();
                        }
                        break;

                    case 3: // AI chose scissors
                        rtb_console.AppendText(Environment.NewLine + "You and Gary just sorta scissor each other...tie?");
                        pb_AIchoice.Image = RockPaperScissors.Properties.Resources.rps_scissors;

                        if (drawCounter <= 9)
                        {
                            drawCounter++;
                            drawsNumber.Text = drawCounter.ToString();
                        }
                        break;
                }
            }
            else
            {
                if (winsCounter == 10)
                {
                    humanWins++;
                    lb_humanWins.Text = humanWins.ToString();
                    MB_YouWon();
                }
                else if (lossCounter == 10)
                {
                    AiWins++;
                    lb_AIWins.Text = AiWins.ToString();
                    MB_YouLost();
                }
                else
                {
                    MB_Draw();
                }
            }
        }

        private void winsNumber_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            newGame();
        }
    }
}
