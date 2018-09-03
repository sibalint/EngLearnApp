using System.Collections.Generic;

namespace EngLearningApp
{
    public static class RemoveFromList
    {
        public static List<string> plural(List<string> wordList) // plural = tobbes szam
        {
            var resultList = new List<string>(wordList);
            foreach (var word in wordList)
            {
                if(resultList.Contains(word+'s'))
                {
                    resultList.Remove(word + 's');
                }

                if (resultList.Contains(word + "es"))
                {
                    resultList.Remove(word + "es");
                }
            }

            return resultList;
            
        }
    }
}
