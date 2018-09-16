using EngLearningApp.model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EngLearningApp.service
{
    class Questioner
    {
        #region Members
        private Label lbWordsCount;
        private TextBox tbEnglishWord;

        private string questionedWord;
        private List<Word> newWords;
        #endregion

        #region Constructor
        public Questioner(Label lbWordsCount, TextBox tbEnglishWord)
        {
            this.lbWordsCount = lbWordsCount;
            this.tbEnglishWord = tbEnglishWord;
            newWords = new List<Word>();
        }
        #endregion

        #region Getters/Setters
        public List<Word> getNewWords()
        {
            return newWords;
        }

        public bool getNewWordsIsEmpty()
        {
            return newWords.Count == 0;
        }

        public void setNewWordsAnEmptyList()
        {
            newWords = new List<Word>();
        }

        public void setQuestionedWord(string questionedWord)
        {
            this.questionedWord = questionedWord;
        }
        #endregion        

        public string questionTheNextWord( List<string> wordsFromFile)
        {
            lbWordsCount.Text = wordsFromFile.Count() + " words left";
            questionedWord = wordsFromFile.FirstOrDefault();
            tbEnglishWord.Text = questionedWord;
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
