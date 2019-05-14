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
    public partial class frmMainGame : Form
    {
        /**
         * Ben Wadsworth
         * 5/13/2019
         * This is the main form for the game and handles the scoreboard
         **/

        // Define variables
        public static string teamOneName;
        public static string teamTwoName;
        public static int teamOneScore;
        public static int teamTwoScore;
        public static string teamOneWord;
        public static string teamTwoWord;
        private static Label[] teamOneRounds = new Label[4];
        private static Label[] teamTwoRounds = new Label[4];
        private int currentRound = 0;
        private Team teamOne;
        private Team teamTwo;

        public frmMainGame()
        {
            InitializeComponent();
            frmAllGames allGames = new frmAllGames();
            allGames.Show();

            // Generate the two new teams with generic names
            teamOne = new Team("Team One");
            teamTwo = new Team("Team Two");

            // Fill in the two arrays with labels for the scoreboard
            teamOneRounds[0] = lblT1R1;
            teamOneRounds[1] = lblT1R2;
            teamOneRounds[2] = lblT1R3;
            teamOneRounds[3] = lblT1R4;

            teamTwoRounds[0] = lblT2R1;
            teamTwoRounds[1] = lblT2R2;
            teamTwoRounds[2] = lblT2R3;
            teamTwoRounds[3] = lblT2R4;
        }

        /**
         * Triggered when the user clicks the Create Teams button
         * frmCreateTeams is loaded and shown
         * Also hides this form and when frmCreateTeams is closed tiggers the FrmCreateTeamsClosed.
         **/
        private void BtnCreateTeams_Click(object sender, EventArgs e)
        {
            frmCreateTeams createTeams = new frmCreateTeams();
            createTeams.Show();
            this.Hide();
            createTeams.FormClosed += FrmCreateTeamsClosed;
        }

        /**
         * This event is triggered when frmCreateTeams is closed
         * This form is shown
         * The Create Teams button is hidden, the Next Round button is made visible as well as the ScoreBoard Header label
         * Both team names are set to the Team objects and then to their corresponding labels on the scoreboard
         **/
        private void FrmCreateTeamsClosed(object sender, EventArgs e)
        {
            this.Show();
            btnPlayNextRound.Visible = true;

            teamOne.Name = teamOneName;
            teamTwo.Name = teamTwoName;

            btnCreateTeams.Visible = false;
            lblScoreboard.Visible = true;

            lblTeamOneName.Text = teamOne.Name;
            lblTeamTwoName.Text = teamTwo.Name;
        }

        /**
         * Triggered when the user clicks the next round button.
         * FrmLettersRound is loaded and shown
         * Hides this form until the round is over and FrmLettersRound is closed triggering the FrmLettersRoundClosed event
         **/
        private void btnPlayNextRound_Click(object sender, EventArgs e)
        {
            FrmLettersRound lettersRound = new FrmLettersRound();
            lettersRound.Show();
            this.Hide();
            lettersRound.FormClosed += FrmLettersRoundClosed;
        }

        /**
         * Triggered after frmLettersRound is closed
         * Sets the round scores to the corresponsing labels based on which round took place
         * Adds the scores and words for each team to the Team objects
         * Resets both totals at the bottom of the scoreboard based on the sum of their scores
         * Adds 1 to the current round variable.
         **/
        private void FrmLettersRoundClosed(object sender, EventArgs e)
        {
            this.Show();
            teamOneRounds[currentRound].Text = teamOneScore.ToString();
            teamTwoRounds[currentRound].Text = teamTwoScore.ToString();

            teamOne.AddScore(teamOneScore);
            teamOne.AddWord(teamOneWord);

            teamTwo.AddScore(teamTwoScore);
            teamTwo.AddWord(teamTwoWord);

            lblTeamOneTotal.Text = teamOne.Scores.Sum().ToString();
            lblTeamTwoTotal.Text = teamTwo.Scores.Sum().ToString();
            
            currentRound++;

            // After round 4 -- EndGame() is called
            if (currentRound == 4)
                EndGame();
        }
        
        /**
         * This is triggered after round 4 of the game
         * Call DatabaseSaveWinners AddGame() with the winner and loser to be entered into the database
         * If there is a tie teamOne will be entered in the winner column and teamTwo in the loser column
         * The frmEndOfGame is loaded and shown with the winner, their score, and false if there is no tie
         * If there is a tie team names are combined in this format "team1;team2" and sent to frmEndOfGame
         *   with 0 as a score and bool val of true
         * Lastly this form is hidden
         **/
        private void EndGame()
        {
            btnPlayNextRound.Visible = false;

            DatabaseSaveWinners dsw = new DatabaseSaveWinners();

            // TeamOne is the winner
            if (teamOne.Scores.Sum() > teamTwo.Scores.Sum())
            {
                dsw.AddGame(teamOne, teamTwo);
                frmEndOfGame end = new frmEndOfGame(teamOne.Name, teamOne.Scores.Sum(), false);
                end.Show();
                this.Hide();
            }
            // TeamTwo is the winner
            else if (teamOne.Scores.Sum() < teamTwo.Scores.Sum())
            {
                dsw.AddGame(teamTwo, teamOne);
                frmEndOfGame end = new frmEndOfGame(teamTwo.Name, teamTwo.Scores.Sum(), false);
                end.Show();
                this.Hide();
            }
            // Tie game
            else
            {
                dsw.AddGame(teamOne, teamTwo);
                string bothTeams = teamOne.Name + ";" + teamTwo.Name;
                frmEndOfGame end = new frmEndOfGame(bothTeams, 0, true);
                end.Show();
                this.Hide();
            }
        }
    }
}
