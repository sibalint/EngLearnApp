using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            FileReader fileReader = new FileReader();
            TextFormatter textFormatter = new TextFormatter();

            string fullText = fileReader.readPdfToString(@"C:\Users\sypy\Downloads\HarryPotterAndTheSorceresStone.pdf"); //TODO: fix constant path

            string preFormattedText = textFormatter.preFormattingBeforeLisiting(fullText);

            List<string> wordList = textFormatter.strToListAlongWhiteSpaces(preFormattedText);

            var wordSet = textFormatter.removeDuplicateWordsFromList(wordList);
        }
    }
}
