using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownGame
{
    class Scoring
    {
        /**
         * Ben Wadsworth
         * 5/13/2019
         * This class sets the textbox colors and the score labels based on the score
         **/

        public void SetAnswers(TextBox box, string word, Label score)
        {
            if (word.Equals("0")) // If word is 0 it wasnt valid
            {
                box.BackColor = Color.PaleVioletRed;
                score.Text = "0";
            }
            else // Valid word
            {
                box.BackColor = Color.LightGreen;
                score.Text = word.Length.ToString();
            }
        }
    }
}
