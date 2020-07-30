using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_RPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string answer = "";
        static int count = 0;
        static int count1 = 0;

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            while (answer != "NO")
            {
                //Player choice
                labelAnswer.Text = "Select any one:\n1->ROCK\n2->PAPER\n3->SCISSOR";
                //choices string array[] for computer choices
                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
                //declare random variable 
                Random rand = new Random();
                //declare variable and set it to a random selector with a range of values 
                int number = rand.Next(0, 3);
                
                //string user = textBoxPlayerChoice.Text.ToUpper();
                bool userRock = radioButtonRock.Checked;
                bool userPaper = radioButtonPaper.Checked;
                bool userScissors = radioButtonScissors.Checked;
                labelAnswer.Text = "Computer:" + choices[number];

                //if statements on choice combinations
                if (userRock == radioButtonRock.Checked && choices[number] == "SCISSOR")
                {
                    labelAnswer.Text = "Player Wins!";
                    count += 1;
                }
                else if (userRock == radioButtonRock.Checked && choices[number] == "PAPER")
                {
                    labelAnswer.Text = "Computer Wins!";
                    count1 += 1;
                }
                else if (userPaper == radioButtonPaper.Checked && choices[number] == "ROCK")
                {
                    labelAnswer.Text = "Player Wins!";
                    count += 1;
                }
                else if (userPaper == radioButtonPaper.Checked && choices[number] == "SCISSOR")
                {
                    labelAnswer.Text = "Computer Wins!";
                    count1 += 1;
                }
                else if (userScissors == radioButtonScissors.Checked && choices[number] == "ROCK")
                {
                    labelAnswer.Text = "Computer Wins!";
                    count1 += 1;
                }
                else if (userScissors == radioButtonScissors.Checked && choices[number] == "PAPER")
                {
                    labelAnswer.Text = "Player Wins!";
                    count += 1;
                }
                else
                {
                    labelAnswer.Text = "Same choices";
                }
                labelAnswer.Text = "Play again?";


                labelAnswer.Text = answer.ToUpper();

                labelAnswer.Text = "----------------------------------";
            }
            labelAnswer.Text = "User wins " + count + " times";
           
            labelAnswer.Text = "Computer wins " + count1 + " times";

        }
    }
}
