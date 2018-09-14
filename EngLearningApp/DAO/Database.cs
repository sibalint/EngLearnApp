using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using EngLearningApp.model;

namespace EngLearningApp.DAO
{
    class Database
    {
        SQLiteConnection dbConnection;
        SQLiteCommand command;

        public Database()
        {
            dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            dbConnection.Open();
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

        public void selectWords()
        {
            
            string sql = "select * from Words";
            var command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader r = command.ExecuteReader();
            

            while (r.Read())
            {
                string FileNames = (string)r["eng"];

                
            }
        }

    }
}
