using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownGame
{
    class Consonant
    {
        /**
         * Ben Wadsworth
         * 5/14/2019
         * Consonant Class used to generate random consonants based on their usage in the english language
         **/

        // Define variables
        private string consonantLetter;
        private string consonantString = "BBCCDDDDFFGGGHHJKLLLLMMNNNNNNPPQRRRRRRSSSSTTTTTTVWXYZ";

        // Getters and Setters
        public string ConsonantLetter { get => consonantLetter; set => consonantLetter = value; }
        public string ConsonantString { get => consonantString; set => consonantString = value; }

        /**
         * Generates a random number between 0 and the length of the consonant string.
         * Selects the char at the index of the random number and sets it as ConsonantLetter
         * That character is then removed from the ConsonantString
         **/
        public void PickConsonant()
        {
            Random random = new Random();
            int num = random.Next(ConsonantString.Length);
            char letter = consonantString[num];
            ConsonantLetter = letter.ToString();
            ConsonantString = ConsonantString.Remove(num, 1);
        }
    }
}
