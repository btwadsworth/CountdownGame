using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownGame
{
    class Validation
    {
        /**
         * Ben Wadsworth
         * 5/13/2019
         * This is used to validate that the answer is only using allotted letters from board
         **/

        public bool OnlyUseAvailLetters(string[] avail, string answer)
        {
            List<string> availableLetters = avail.ToList<string>();

            foreach (char index in answer)
            {
                string letter = Char.ToString(index);

                if (availableLetters.Contains(letter))
                    availableLetters.Remove(letter);

                else
                    return false;
            }
            return true;
        }



    }
}
