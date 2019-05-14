using System;
using System.Windows.Forms;

namespace CountdownGame
{
    public partial class frmCreateTeams : Form
    {
        /**
         * Ben Wadsworth
         * 5/13/2019
         * This is the form where both team names are entered for the game.
         * The maximum length of the team names is 20 characters (Set with MaxLength for both textboxes)
         * This form cannot be closed until both team names have been entered and validated they are not blank.
         * This form closes when the user clicks the save button.
         **/
        public frmCreateTeams()
        {
            InitializeComponent();
        }

        /** 
         * The following event is triggered when the user clicks the "Let's Play Countdown" button
         * Validates team names are not emty sets the team name strings from the frmMainGame using the entries
         * Then closes the form
         **/
        private void btnSaveTeamNames_Click(object sender, EventArgs e)
        {
            if (!txtBoxTeamOneName.Text.Equals("") && !txtBoxTeamTwoName.Text.Equals(""))
            {
                frmMainGame.teamOneName = txtBoxTeamOneName.Text;
                frmMainGame.teamTwoName = txtBoxTeamTwoName.Text;
                this.Close();
            }
            else
                MessageBox.Show("Must enter both team names.");
        }
    }
}
