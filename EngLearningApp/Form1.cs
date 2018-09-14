﻿using EngLearningApp.DAO;
using EngLearningApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EngLearningApp
{
    public partial class Form1 : Form
    {
        private string filePath { get; set; }
        private List<string> wordsFromFile = new List<string>();
        private List<Word> wordDirectory = new List<Word>();


        public Form1()
        {
            InitializeComponent();
            //filePath = @"C:\Users\sypy\Downloads\HarryPotterAndTheSorceresStone.pdf";
            filePath = @"F:\Dev\videoCourses\Udemy - Spring Framework 5 Beginner to Guru\02 Building a Spring Boot Web App\009 Open Project in IntelliJ-subtitle-en.vtt";
            tbSelectTextFilePath.Text = filePath;

            #region read word directory
            Database db = new Database();
            db.init();            
            wordDirectory = db.selectWords();
            db.close();
            #endregion


        }
                
        #region FileReading
        private void btSelectTextFilePath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.filePath = openFileDialog1.FileName;
                tbSelectTextFilePath.Text = filePath;
            }
        }

        private void btReadTextFile_Click(object sender, EventArgs e)
        {
            FileReader fileReader = new FileReader();
            TextFormatter textFormatter = new TextFormatter();

            string fullText = fileReader.readTxtToString(filePath);
            wordsFromFile = textFormatter.getWorldListFromString(fullText);

#warning fix it
            var databaseListEng = new List<string>(wordDirectory.Select(x => x.english));
            wordsFromFile = wordsFromFile.Except(databaseListEng).ToList();

            //Translator d = new Translator();
            //wordDirectory = d.getDirectory(wordSet);

            

        }

        private void btStartQuestioner_Click(object sender, EventArgs e)
        {





            panelFileReader.Visible = false;
            panelQuestioner.Visible = true;
        }
        #endregion




        #region questioner panel

        #endregion
        private void btGreen_Click(object sender, EventArgs e)
        {

        }

        private void btYellow_Click(object sender, EventArgs e)
        {

        }

        private void btRed_Click(object sender, EventArgs e)
        {

        }

        private void btSaveWordsToDatabase_Click(object sender, EventArgs e)
        {

        }
    }
}
