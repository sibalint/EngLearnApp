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

        public List<string> removeDuplicateWordsFromList(List<string> words)
        {
            HashSet<string> set = new HashSet<string>(words);
            var list = set.ToList();
            var ascendingOrder = list.OrderBy(i => i).ToList();
            return ascendingOrder;

        }








        

    }
}
