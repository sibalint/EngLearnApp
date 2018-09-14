using EngLearningApp.model;
using System.Collections.Generic;
using System.Data.SQLite;

namespace EngLearningApp.DAO
{
    class Database
    {
        SQLiteConnection dbConnection;
        SQLiteCommand command;

        public Database()
        {
            
        }

        public void init()
        {
            dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            dbConnection.Open();
        }

        public void close()
        {
            dbConnection.Close();
        }


        public void runSQL(string sql)
        {
            command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
        }

        public void insertWord(string eng, string hun, string knowledgeColor)
        {
            string sql = "INSERT INTO Words (eng, hun, color) VALUES ('"+eng+"', '"+hun+"','"+knowledgeColor+"' )";
            command = new SQLiteCommand(sql,dbConnection);
            command.ExecuteNonQuery();
        }

        public List<Word> selectWords()
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

                if (color.Equals("green"))
                    colorEnum = KnownColor.Green;
                else if(color.Equals("yellow"))
                    colorEnum = KnownColor.Yellow;
                else
                    colorEnum = KnownColor.Red;

                words.Add(new Word(eng, hun, colorEnum));                
            }

            return words;
        }

    }
}
