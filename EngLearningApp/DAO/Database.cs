using EngLearningApp.model;
using EngLearningApp.service;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace EngLearningApp.DAO
{
    class Database
    {
        Logger log = new Logger();
        SQLiteConnection dbConnection;
        SQLiteCommand command;

        public Database()
        {
            
        }

        public List<Word> initializeInMemoryList()
        {
            try { 
            init();
            var result = getWords();
            close();
            return result;
            }
            catch (System.Exception e)
            {
                MessageBox.Show("ERROR: Database connecting failed. Please restart the Application.");
                log.error(e);
                return null;
            }
        }

        public void saveData(List<Word> newWords)
        {
            try
            {
                init();
                foreach (var word in newWords)
                {
                    insertWord(word.english, word.hungarian, word.knowledgeLevel.ToString());
                }
                close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show("ERROR: Saving is failed!");
                log.error(e);

            }
            
        }


        private void init()
        {
            dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            dbConnection.Open();
        }

        private void close()
        {
            dbConnection.Close();
        }

        private void runSQL(string sql)
        {
            command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
        }

        private void insertWord(string eng, string hun, string knowledgeColor)
        {
            command = new SQLiteCommand(dbConnection);
            command.CommandText = "INSERT INTO Words (eng, hun, color) VALUES (@eng, @hun, @color)";
            command.Parameters.AddWithValue("@eng", eng);
            command.Parameters.AddWithValue("@hun", hun);
            command.Parameters.AddWithValue("@color", knowledgeColor);
            command.ExecuteNonQuery();
        }

        public List<Word> getWords()
        {
            List<Word> words = new List<Word>();
            
            
            string sql = "SELECT * FROM Words";
            var command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            

            while (reader.Read())
            {
                string eng = (string)reader["eng"];
                string hun = (string)reader["hun"];
                string color = (string)reader["color"];

                KnownColor colorEnum;

                if (color.Equals("Green"))
                    colorEnum = KnownColor.Green;
                else if(color.Equals("Yellow"))
                    colorEnum = KnownColor.Yellow;
                else
                    colorEnum = KnownColor.Red;

                words.Add(new Word(eng, hun, colorEnum));                
            }

            return words;
        }

    }
}
