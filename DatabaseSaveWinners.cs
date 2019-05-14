using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownGame
{
    class DatabaseSaveWinners
    {
        /**
         * Ben Wadsworth
         * 5/13/2019
         * This class is used to add the game results to the AllGames table in the database
         **/

        public void AddGame(Team winner, Team loser)
        {
            
            string winName = winner.Name;
            int winScore = winner.Scores.Sum();

            string losName = loser.Name;
            int losScore = loser.Scores.Sum();

            // Generate new row in the table
            CountdownDataSetTableAdapters.AllGamesTableAdapter allGamesTableAdapter =
                new CountdownDataSetTableAdapters.AllGamesTableAdapter();

            // Insert values into the new row
            allGamesTableAdapter.Insert(winName, winScore, losName, losScore);
        }
    }
}
