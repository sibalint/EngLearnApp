using EngLearningApp.DAO;
using EngLearningApp.model;
using EngLearningApp.service;
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
        private List<Word> wordsFromDatabase = new List<Word>();
        private Questioner questioner;
        

        public Form1()
        {
            InitializeComponent();

            #region Test file path
            //filePath = @"C:\Users\sypy\Downloads\HarryPotterAndTheSorceresStone.pdf";
            filePath = @"F:\Dev\videoCourses\Udemy - Spring Framework 5 Beginner to Guru\02 Building a Spring Boot Web App\009 Open Project in IntelliJ-subtitle-en.vtt";
            tbSelectTextFilePath.Text = filePath;
            #endregion

            questioner = new Questioner(lbWordsCount, lbEnglishWord);

            wordsFromDatabase = new Database().initializeInMemoryList();
            


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
            wordsFromFile = textFormatter.getWorldListFromString(fullText, wordsFromDatabase);

            //Translator d = new Translator();
            //wordDirectory = d.getDirectory(wordSet);

            

        }

        private void btStartQuestioner_Click(object sender, EventArgs e)
        {
            questioner.questionTheNextWord(wordsFromFile);

            panelFileReader.Visible = false;
            panelQuestioner.Visible = true;
        }
        #endregion

        #region questioner panel


        private void btGreen_Click(object sender, EventArgs e)
        {
            questioner.addWordToNewWordsList(KnownColor.Green);
            questioner.questionTheNextWord(wordsFromFile);
        }


        private void btYellow_Click(object sender, EventArgs e)
        {
            questioner.addWordToNewWordsList(KnownColor.Yellow);
            questioner.questionTheNextWord(wordsFromFile);
        }

        private void btRed_Click(object sender, EventArgs e)
        {
            questioner.addWordToNewWordsList(KnownColor.Red);
            questioner.questionTheNextWord(wordsFromFile);
        }

        private void btSaveWordsToDatabase_Click(object sender, EventArgs e)
        {
            new Database().saveData(questioner.getNewWords());
            questioner.setNewWordsAnEmptyList();
        }

        #endregion

        private void btl_open_Click(object sender, EventArgs e)
        {
            panelFileReader.Visible = true;
            panelQuestioner.Visible = false;
        }
    }
}
