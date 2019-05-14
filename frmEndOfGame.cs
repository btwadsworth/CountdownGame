using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownGame
{
    public partial class frmEndOfGame : Form
    {
        /**
         * Ben Wadsworth
         * 5/13/2019
         * This form is simply to show the winner and their score
         * The user then has the option to play again or exit
         **/

        public frmEndOfGame(string name, int score, bool tie)
        {
            InitializeComponent();
            
            // If tie is false set the winner and their score
            if (!tie)
            {
                lblWinner.Text = name;
                lblScore.Text = score.ToString();
            }

            // If it is a tie both names will be sent to this form in this format "team1;team2"
            // The congrats label will be changed and no scores displayed
            else
            {
                lblCongrats.Text = "It's a tie!";
                string[] names = name.Split(';');
                lblWinner.Text = names[0];
                lblScore.Text = names[1];
            }
            
        }

        // Triggered when the Play Again button is clicked, the application restarts
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // Triggered when the Exit button is clicked, the Application closes
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewPastGames_Click(object sender, EventArgs e)
        {
            frmAllGames frmAllGames = new frmAllGames();
            frmAllGames.Show();
        }
    }
}
