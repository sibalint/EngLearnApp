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

        #region Public method
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
                    if (!containsThisKey(word.english))
                    {
                        insertWord(word.english, word.hungarian, word.knowledgeLevel.ToString());
                    }
                    else
                    {
                        updateKnowledge(word.english, word.knowledgeLevel.ToString());
                    }

                }
                close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show("ERROR: Saving is failed!");
                log.error(e);

            }
            
        }

        
        #endregion

        #region Private methods
        private void init()
        {
            dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            dbConnection.Open();
        }

        private void close()
        {
            dbConnection.Close();
        }


        private bool containsThisKey(string eng)
        {
            string sql = "SELECT eng FROM Words WHERE eng == @eng";
            command = new SQLiteCommand(sql, dbConnection);
            command.Parameters.AddWithValue("@eng", eng);
            SQLiteDataReader reader = command.ExecuteReader();
            return reader.HasRows;
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

        private void updateKnowledge(string eng, string color)
        {
            command = new SQLiteCommand(dbConnection);
            command.CommandText = "UPDATE Words SET color=@color WHERE eng= @eng";
            command.Parameters.AddWithValue("@eng", eng);
            command.Parameters.AddWithValue("@color", color);
            command.ExecuteNonQuery();
        }
        

        private List<Word> getWords()
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
        #endregion
    }
}
