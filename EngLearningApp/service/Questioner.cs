using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EngLearningApp.service
{
    class Questioner
    {
        public string questionTheNextWord(Label lbWordsCount, Label lbEnglishWord, List<string> wordsFromFile)
        {
            lbWordsCount.Text = "Még " + wordsFromFile.Count() + " szó van hátra";
            string questionedWord = wordsFromFile.FirstOrDefault();
            lbEnglishWord.Text = questionedWord;
            wordsFromFile.Remove(questionedWord);
            return questionedWord;
        }
    }
}
