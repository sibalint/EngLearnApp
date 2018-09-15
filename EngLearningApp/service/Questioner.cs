using EngLearningApp.model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EngLearningApp.service
{
    class Questioner
    {
        private Label lbWordsCount;
        private Label lbEnglishWord;

        private string questionedWord;
        private List<Word> newWords;

        public List<Word> getNewWords()
        {
            return newWords;
        }

        public void setNewWordsAnEmptyList()
        {
            newWords = new List<Word>();
        }

        public Questioner(Label lbWordsCount, Label lbEnglishWord)
        {
            this.lbWordsCount = lbWordsCount;
            this.lbEnglishWord = lbEnglishWord;
            newWords = new List<Word>();
        }

        public string questionTheNextWord( List<string> wordsFromFile)
        {
            lbWordsCount.Text = "Még " + wordsFromFile.Count() + " szó van hátra";
            questionedWord = wordsFromFile.FirstOrDefault();
            lbEnglishWord.Text = questionedWord;
            wordsFromFile.Remove(questionedWord);

            return questionedWord;
        }

        public void addWordToNewWordsList(KnownColor color)
        {
            newWords.Add(new Word(questionedWord, "", color));
#warning "here i need translate the word if i want use this function"
        }
    }
}
