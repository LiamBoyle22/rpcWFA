using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpcWFA
{
    public partial class Form1 : Form
    {
        private const int ROCK = 1;
        private const int PAPER = 2;
        private const int SCISSORS = 3;
        private readonly Random rand = new Random();
        private int compchoice;

        public Form1()
        {
            InitializeComponent();
        }

        private int GetCompChoice()
        {
            return rand.Next(1, 4);
        }

        private void Results_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RockBTN_Click(object sender, EventArgs e)
        {
            PlayRound(ROCK);
        }

        private void PaperBTN_Click(object sender, EventArgs e)
        {
            PlayRound(PAPER);
        }

        private void ScissorsBTN_Click(object sender, EventArgs e)
        {
            PlayRound(SCISSORS);
        }

        private void PlayRound(int choice)
        {
            compchoice = GetCompChoice();
            DisplayChoices(choice);
            string winner = DetermineWinner(choice, compchoice);
            DisplayResult(winner);
        }

        private void DisplayChoices(int choice)
        {
            Results.Items.Add("You chose: " + ChoiceToString(choice));
            Results.Items.Add("Computer chose: " + ChoiceToString(compchoice));
        }

        private string ChoiceToString(int choice)
        {
            switch(choice)
            {
                case ROCK: return "Rock";
                case PAPER: return "Paper";
                case SCISSORS: return "Scissors";
                default: return "Unknown";
            }
        }

        private string DetermineWinner(int user, int computer)
        {
            if (user ==computer)
            {
                return "Tie";
            }

            if ((user == ROCK && computer == SCISSORS) || (user == SCISSORS && computer == PAPER) || (user == PAPER && computer == ROCK))
            {
                return "User";
            }

            return "Computer";
        }

        private void DisplayResult(string winner)
        {
            if (winner == "Tie")
            {
                Results.Items.Add("It's a tie, play again");
            }

            else
            {
                if(winner == "User")
                {
                    Results.Items.Add("You win!");
                }

                else
                {
                    Results.Items.Add("The computer wins!");
                }
            }
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
