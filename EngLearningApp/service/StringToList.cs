using EngLearningApp.model;
using System.Collections.Generic;
using System.Linq;

namespace EngLearningApp
{
    class StringToList
    {
        #region public methods
        /// <summary>
        /// This Method split a string along whitespaces. And remove duplicated words, and remove words what already database is contains.
        /// </summary>
        /// <param name="input string"></param>
        /// <param name="words list from database (this words will removes form the result)"></param>
        /// <returns>Get nonDuplicated words list from string</returns>
        public List<string> getList(string text, List<Word> wordsFromDatabase)
        {
            text = preFormattingBeforeLisiting(text);

            List<string> wordList = strToListAlongWhiteSpaces(text); //create list

            return (new RemoveFromList(wordsFromDatabase)).unnessesarryItems(wordList);          
        }
        #endregion

        #region Private methods
        private string preFormattingBeforeLisiting(string text)
        {
            text = text.ToLower();
            text = text.Replace("\n", " ");

            text = RemoveFromText.unnecessarySpecCharacters(text);
            text = RemoveFromText.numbers(text);

            return text;
        }

        private List<string> strToListAlongWhiteSpaces(string text)
        {
            return text.Split(' ').ToList();
        }
        #endregion
    }
}
