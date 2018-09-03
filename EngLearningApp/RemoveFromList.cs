using System.Collections.Generic;

namespace EngLearningApp
{
    public static class RemoveFromList
    {
        private static List<string> affixes = new List<string>(new string[] { "s", "es", "ed", "ing", "\'s", "\'ll", "\n't", "\'t", "\'ve", "\'re" }); //affixes=ragok

        public static List<string> affix(List<string> wordList) // plural = tobbes szam
        {
            var resultList = new List<string>(wordList);
            foreach (var word in wordList)
            {
                foreach (var affix in affixes)
                {
                    if (resultList.Contains(word + affix))
                        resultList.Remove(word + affix);
                }
                
            }

            return resultList;
            
        }
    }
}
