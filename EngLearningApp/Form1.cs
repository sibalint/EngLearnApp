using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EngLearningApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string filePath = @"C:\Users\sypy\Downloads\HarryPotterAndTheSorceresStone.pdf";
            ////string filePath = @"F:\Dev\videoCourses\Udemy - Spring Framework 5 Beginner to Guru\02 Building a Spring Boot Web App\009 Open Project in IntelliJ-subtitle-en.vtt";
            //FileReader fileReader = new FileReader();
            //TextFormatter textFormatter = new TextFormatter();

            //string fullText = fileReader.readPdfToString(filePath); 
            //List<string> wordSet = textFormatter.getWorldListFromString(fullText);

            Translator d = new Translator();
            d.EngToHun("apple");
        }
    }
}
