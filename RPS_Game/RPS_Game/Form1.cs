namespace RPS_Game
{
    public partial class Form1 : Form
    {
        string playerchoice, botChoice, draw;
        string[] option = { "R", "P", "S" };
        int botScore, playerScore;
        int rounds = 3;

        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseAChoice(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            playerchoice = (string)btn.Tag;

            int v = rand.Next(0, option.Length);

            botChoice = option[v];

            lbPlayer.Text = "Player Choice: " + UpdateTextImage(playerchoice, picPlayer);
            lbBot.Text = "Bot Choice:" + UpdateTextImage(botChoice, picBot);
            Game();

        }

        private string UpdateTextImage(string text, PictureBox pictureBox)
        {
            string word = null;
            switch (text)
            {
                case "R":
                    pictureBox.Image = Properties.Resources.ROCK;
                    break;
                case "P":
                    pictureBox.Image = Properties.Resources.PAPER;
                    break;
                case "S":
                    pictureBox.Image = Properties.Resources.SCISSORS;
                    break;
            }
            return word;
        }

        private void Game()
        {

            if (botChoice == playerchoice)
            {
                draw = "Match Drawn!";
            }
            else if (playerchoice == "R" && botChoice == "P" || playerchoice == "S" && botChoice == "R" || playerchoice == "P" && botChoice == "S")
            {

                botScore++;
                rounds--;
                draw = null;

            }
            else
            {
                playerScore++;
                rounds--;
                draw = null;
            }

            bResult.Text = "Bot Score: " + botScore + Environment.NewLine + draw;
            pResult.Text = "Player Score: " + playerScore + Environment.NewLine + draw;

            Round.Text = "Rounds: " + rounds;

            if (rounds == 0)
            {
                if (playerScore > botScore)
                {
                    MessageBox.Show("Player Won The Series!");
                }
                else if(botScore > playerScore)
                {
                    MessageBox.Show("Bot Won The Series!!");
                }
                else
                {
                    MessageBox.Show("Match Tie!");
                }
                ResetGame();
            }
            
        }

        private void ResetGame()
        {
            playerScore = 0;
            botScore = 0;
            rounds = 3;
            draw = null;

            lbPlayer.Text = "Player Choice: ";
            lbBot.Text = "Bot Choice: ";
            bResult.Text = "Bot Score: 0";
            pResult.Text = "Player Score: 0";
            Round.Text = "Rounds: 3";

            picPlayer.Image = null;
            picBot.Image = null;
        }

        private void Reset_All(object sender, EventArgs e)
        {
            ResetGame();

        }
    }
}
