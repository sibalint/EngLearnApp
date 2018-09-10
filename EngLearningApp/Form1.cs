using EngLearningApp.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EngLearningApp
{
    public partial class Form1 : Form
    {
        private string filePath { get; set; }
        private List<Word> wordDirectory = new List<Word>();

        public Form1()
        {
            InitializeComponent();
            //filePath = @"C:\Users\sypy\Downloads\HarryPotterAndTheSorceresStone.pdf";
            filePath = @"F:\Dev\videoCourses\Udemy - Spring Framework 5 Beginner to Guru\02 Building a Spring Boot Web App\009 Open Project in IntelliJ-subtitle-en.vtt";
            tbSelectTextFilePath.Text = filePath;
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

        private void tbReadTextFile_Click(object sender, EventArgs e)
        {
            FileReader fileReader = new FileReader();
            TextFormatter textFormatter = new TextFormatter();

            string fullText = fileReader.readTxtToString(filePath);
            List<string> wordSet = textFormatter.getWorldListFromString(fullText);

            Translator d = new Translator();
            wordDirectory = d.getDirectory(wordSet);

            panelFileReader.Visible = false;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
