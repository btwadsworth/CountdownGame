using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CountdownGame
{
    public partial class FrmLettersRound : Form
    {
        /**
         * Ben Wadsworth
         * 5/13/2019
         * This form is is the letters round for the game which is generated new each round
         * This handles the user generating consonants and vowels to for the 9 scrambled letters
         * Then starts the 30 second video as a timer until the teams can enter their words
         * Both teams enter words then click check words which searches the dictionary table for their words
         **/

        // Declare Variables
        private String[] letters = new String[9];
        private int lettersPicked = 0;
        private Label[] labels = new Label[9];
        private int numberOfConsonants = 0;
        private int numberOfVowels = 0;
        private int teamOneScore = 0;
        private int teamTwoScore = 0;

        // Instances of classes
        private Consonant cons = new Consonant();
        private Vowel vow = new Vowel();
        private Validation valid = new Validation();
        private Scoring scoring = new Scoring();

        public FrmLettersRound()
        {
            InitializeComponent();
            video.Ctlcontrols.stop();

            // Add Labels to the labels Array
            labels[0] = lblLetter1;
            labels[1] = lblLetter2;
            labels[2] = lblLetter3;
            labels[3] = lblLetter4;
            labels[4] = lblLetter5;
            labels[5] = lblLetter6;
            labels[6] = lblLetter7;
            labels[7] = lblLetter8;
            labels[8] = lblLetter9;

            // Set the team names from frmMainGame
            lblTeam1.Text = frmMainGame.teamOneName;
            lblTeam2.Text = frmMainGame.teamTwoName;
        }

        // Triggered when the team clicks the consonant button
        private void btnConsonant_Click(object sender, EventArgs e)
        {
            // Validates the user has not selected 6 consonants
            // A consonant is randomly selected and applied to the next label on the board
            if (numberOfConsonants < 6)
            {
                cons.PickConsonant();
                letters[lettersPicked] = cons.ConsonantLetter;
                UpdateBoard();
                numberOfConsonants++;
            }
            // If the user has already selected 6 consonants
            //  display a message box and disable the button
            else
            {
                MessageBox.Show("You must pick at least 3 vowels.", "Not Enough Vowels",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnConsonant.Enabled = false;
            }
        }

        // Triggered when the teamclicks the vowel button
        private void btnVowel_Click(object sender, EventArgs e)
        {
            // Validates the user has not selected 5 vowels
            // A vowel is randomly selected and applied to the next label on the board
            if (numberOfVowels < 5)
            {
                vow.PickVowel();
                letters[lettersPicked] = vow.VowelLetter;
                UpdateBoard();
                numberOfVowels++;
            }
            // If the user has already selected 5 vowels
            //  display a message box and disable the button
            else
            {
                MessageBox.Show("You must pick at least 4 consonants.", "Not Enough Consonants",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                btnVowel.Enabled = false;
            }
        }

        // Update the labels on the board with the letter generated
        private void UpdateBoard()
        {
            labels[lettersPicked].Text = letters[lettersPicked];
            lettersPicked++;

            // Once the 9th letter is picked BeginGame is called
            if (lettersPicked > 8)
                BeginGame();
        }

        // Change the visibility of the message and buttons 
        // Make the video visible and play it
        private void BeginGame()
        {
            lblMessage.Visible = false;

            video.Visible = true;
            video.Ctlcontrols.play();

            btnConsonant.Visible = false;
            btnVowel.Visible = false;
        }

        // This is triggered when the user is entering data into either of the textboxes
        private void ValidateAndChangeCase(object sender, EventArgs e)
        {
            // Get the textbox and the text entered
            TextBox box = (TextBox)sender;
            string answer = box.Text;

            // Get a string of all the letters
            string allLetters = string.Join("", letters);

            // If something has been entered
            if (!answer.Equals(""))
            {
                // Get the last character entered and make it into a capitalized string
                char lastLetter = Char.Parse(answer.Substring(answer.Length - 1));
                string lastLetterString = lastLetter.ToString().ToUpper();

                // If the character is not alphabetic OR they've entered more than 10 characters
                //   OR they entered a letter that is not one of the jumbled letters
                if (Char.IsLetter(lastLetter) is false || answer.Length == 10 || !allLetters.Contains(lastLetterString))
                    
                    // Reset the text in the textbox without the last character they entered
                    box.Text = answer.Substring(0, answer.Length - 1);

                else
                    // Capitalize the text
                    box.Text = answer.ToUpper();
                
                // Move the cursor to after the last letter
                box.SelectionStart = answer.Length;
            }
        }

        // Triggered when the video ends.  hide the video
        // Chang the visibility of some controls for the teams and their answers
        private void TimesUp(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (video.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                video.Visible = false;

                lblMessage.Visible = true;
                lblMessage.Text = "What did you get?";

                lblTeam1.Visible = true;
                lblTeam2.Visible = true;

                txtBoxAnswerTeam1.Visible = true;
                txtBoxAnswerTeam2.Visible = true;

                btnCheckWords.Visible = true;
            }
        }

        /**
         * Triggered when the user clicks the checkwords button
         * This calls the search method for the dictionary table in the database and returns boolean
         *   whether the word is in the dictionary or not
         * Then calls the validation class to set the textbox colors and corresponding score
         * Message boxes are shown if the team enteres more than the allotted letters
         **/
        private void btnCheckWords_Click(object sender, EventArgs e)
        {
            // Load Database class
            DatabaseSearchTool dst = new DatabaseSearchTool();

            // Get answers from textboxes
            string team1Word = txtBoxAnswerTeam1.Text;
            string team2Word = txtBoxAnswerTeam2.Text;

            // Call database search to check if words are in database
            bool team1ValidWord = dst.Search(team1Word);
            bool team2ValidWord = dst.Search(team2Word);

            // If the word is in the dictionary
            if (team1ValidWord)
            {
                // If they didn't use any more than the allotted letters
                if (valid.OnlyUseAvailLetters(letters, team1Word))
                {
                    scoring.SetAnswers(txtBoxAnswerTeam1, team1Word, lblScoreTeam1);
                    teamOneScore = team1Word.Length;
                }
                else {
                    MessageBox.Show(lblTeam1.Text + " used at least one letter more than what was available.",
                        "Incorrect Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    scoring.SetAnswers(txtBoxAnswerTeam1, "0", lblScoreTeam1);
                }
            }
            else
                scoring.SetAnswers(txtBoxAnswerTeam1, "0", lblScoreTeam1);

            // If the word is in the dictionary
            if (team2ValidWord)
            {
                // If they didn't use any more than the allotted letters
                if (valid.OnlyUseAvailLetters(letters, team2Word))
                {
                    scoring.SetAnswers(txtBoxAnswerTeam2, team2Word, lblScoreTeam2);
                    teamTwoScore = team2Word.Length;
                }
                else
                {
                    MessageBox.Show(lblTeam2.Text + " used at least one letter more than what was available.",
                        "Incorrect Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    scoring.SetAnswers(txtBoxAnswerTeam2, "0", lblScoreTeam2);
                }
                    
            }
            else
                scoring.SetAnswers(txtBoxAnswerTeam2, "0", lblScoreTeam2);

            // Call Method to change controls
            WordsCheckedChangeControls();
        }

        // The dictionary search failed and the user manually overrides their answer to be correct
        private void BtnTeamOneManualOverride_Click(object sender, EventArgs e)
        {
            teamOneScore = txtBoxAnswerTeam1.Text.Length;
            txtBoxAnswerTeam1.BackColor = Color.LightGreen;
            lblScoreTeam1.Text = teamOneScore.ToString();
            btnTeamOneManualOverride.Enabled = false;
        }

        // The dictionary search failed and the user manually overrides their answer to be correct
        private void BtnTeamTwoManualOverride_Click(object sender, EventArgs e)
        {
            teamTwoScore = txtBoxAnswerTeam2.Text.Length;
            txtBoxAnswerTeam2.BackColor = Color.LightGreen;
            lblScoreTeam2.Text = teamTwoScore.ToString();
            btnTeamTwoManualOverride.Enabled = false;
        }

        // End of round.  Data is stored in frmMainGame variables and this form is closed
        private void btnEndRound_Click(object sender, EventArgs e)
        {
            frmMainGame.teamOneScore = teamOneScore;
            frmMainGame.teamTwoScore = teamTwoScore;
            frmMainGame.teamOneWord = txtBoxAnswerTeam1.Text;
            frmMainGame.teamTwoWord = txtBoxAnswerTeam2.Text;
            this.Close();
        }

        // Change constrols visibility, alignment and if they are enabled
        private void WordsCheckedChangeControls()
        {
            btnCheckWords.Enabled = false;

            txtBoxAnswerTeam1.TextAlign = HorizontalAlignment.Center;
            txtBoxAnswerTeam2.TextAlign = HorizontalAlignment.Center;
            txtBoxAnswerTeam1.Enabled = false;
            txtBoxAnswerTeam2.Enabled = false;
            lblScoreTeam1.Visible = true;
            lblScoreTeam2.Visible = true;

            btnTeamOneManualOverride.Visible = true;
            btnTeamTwoManualOverride.Visible = true;

            btnEndRound.Visible = true;
        }
    }
}
