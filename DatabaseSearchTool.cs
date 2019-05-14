using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace CountdownGame
{
    class DatabaseSearchTool
    {
        /**
         * Ben Wadsworth
         * 5/13/2019
         * This class is used to search the database for the answers teams give 
         *   to see if they are in the dictionary.
         **/

        // Connection String
        private string connectionString = "Data Source = TPUTERWIN10\\SQLEXPRESS; " +
                "Initial Catalog = Countdown; Integrated Security = True";

        public bool Search(string word)
        {
            // The dictionary does not save plurals or verb endings so change the word before the search
            if (word.EndsWith("S"))
                word = word.Remove(word.Length - 1);
            else if (word.EndsWith("ING"))
                word = word.Remove(word.Length - 3);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Dictionary WHERE Words LIKE '" + word + "'", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(0)) // If the query is not empty return true
                    {
                        return true;
                    }
                }
            }

            return false; // The query result set was empty
        }

    }
}
