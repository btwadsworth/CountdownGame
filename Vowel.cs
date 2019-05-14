using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownGame
{
    class Vowel
    {
        /**
         * Ben Wadsworth
         * 5/13/2019
         * Vowel Class used to generate random vowels based on their usage in the english language
         **/

        // Define Variables
        private string vowelLetter;
        private string vowelString = "AAAAAEEEEEEIIIIIOOOOUU";

        // Getters and Setters
        public string VowelLetter { get => vowelLetter; set => vowelLetter = value; }
        public string VowelString { get => vowelString; set => vowelString = value; }

        /**
         * Generates a random number between 0 and the length of the vowel string.
         * Selects the char at the index of the random number and sets it as VowelLetter
         * That character is then removed from the VowelString
         **/
        public void PickVowel()
        {
            Random random = new Random();
            int num = random.Next(VowelString.Length);
            char letter = vowelString[num];
            VowelLetter = letter.ToString();
            VowelString = VowelString.Remove(num, 1);
        }
    }
}
