﻿using System.Collections.Generic;
using System.Linq;

namespace EngLearningApp
{
    class TextFormatter
    {
        public List<string> getWorldListFromString(string text)
        {
            text = preFormattingBeforeLisiting(text);

            List<string> wordList = strToListAlongWhiteSpaces(text); //create list

            return (new RemoveFromList()).unnessesarryItems(wordList);          
        }


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

        








        

    }
}
