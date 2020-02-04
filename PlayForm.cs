using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game; 

namespace PlayGameForm
{
    public partial class PlayForm : Form
    {
        private NumberGame game = new NumberGame(5, new NumberRange(0,9));

        public PlayForm()
        {
            InitializeComponent();
        }

        // When the form loads, these methods will be called
        private void Form1_Load(object sender, EventArgs e)
        {
            game.StartNewGame();
            generateNewGUI();
        }

        //Method to generate a new GUI for a new game
        private void generateNewGUI()
        {
            bttnRound.Enabled = true;
            bttnView.Enabled = true;
            lblNumbers.Text = "0 0 0 0 0 0 0 0";
            lblRoundScore.Text = "0";
        }

        //Method to initialized when the game is over
        private void GameOver()
        {
            if (game.MaxRoundsReached)
                bttnRound.Enabled = false;
        }
        
        //When the restart button is clicked, will generate a new game from the methods
        private void bttnRestart_MouseClick(object sender, MouseEventArgs e)
        {
            game.StartNewGame();
            generateNewGUI();
            bttnRound.Enabled = true;
        }

        //Goes to a new form to show results of the game
        private void bttnView_MouseClick(object sender, MouseEventArgs e)
        {
            
            ViewResult form = new ViewResult(game);
            form.ShowDialog();
        }


        //When the "Play Round" button is clicked, these methods are called
        private void bttnRound_Click(object sender, EventArgs e)
        {
            game.PlayRound();
            generateNewGUI();
            lblRoundScore.Text = game.GetCurrentRoundScores().ToString();
            lblNumbers.Text = game.PrintCurrentNums();
            
            if (game.IsGameOver)
            {
                GameOver();
            }
        }
    }
}
