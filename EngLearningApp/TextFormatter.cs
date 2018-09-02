using System.Collections.Generic;
using System.Linq;

namespace EngLearningApp
{
    class TextFormatter
    {
        public string preFormattingBeforeLisiting(string text)
        {
            text = text.ToLower();
            text = text.Replace("\n", " ");

            text = RemoveFromText.unnecessarySpecCharacters(text);
            text = RemoveFromText.numbers(text);

            return text;
        }


        public List<string> strToListAlongWhiteSpaces(string text)
        {            

            return text.Split(' ').ToList();
        }









        

    }
}
