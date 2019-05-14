using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownGame
{
    class Team
    {
        /**
         * Ben Wadsworth
         * 5/13/2019
         * Team object class
         **/

        // Define variables
        private string name;
        private List<int> scores;
        private List<string> words;

        // Getters and Setters
        public string Name { get => name; set => name = value; }
        public List<int> Scores { get => scores; set => scores = value; }
        public List<string> Words { get => words; set => words = value; }

        // Constructor
        public Team(string name)
        {
            this.Name = name;
            this.Scores = new List<int>();
            this.Words = new List<string>();
        }
         // Add score to List<int> 
        public void AddScore(int score)
        {
            this.Scores.Add(score);
        }
         // Remove last score and replace it with new score
        public void OverrideScore(int score)
        {
            this.Scores.RemoveAt(Scores.Count - 1);
            this.Scores.Add(score);
        }

        // Add word to List<string>
        public void AddWord(string word)
        {
            this.Words.Add(word);
        }

    }
}
