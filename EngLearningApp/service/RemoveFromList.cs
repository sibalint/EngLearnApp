using EngLearningApp.model;
using System.Collections.Generic;
using System.Linq;

namespace EngLearningApp
{
    public static class RemoveFromList
    {
        private static List<string> affixes = new List<string>(new string[] { "s", "es", "ed", "ing", "\'s", "\'ll", "\n't", "\'t", "\'ve", "\'re" }); //affixes=ragok

        public static List<string> affix(List<string> wordList) 
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

        public static List<string> oneLenghtItems(List<string> list)
        {
            list.RemoveAll(x => x.Length <= 1);

            return list;

        }

        //public static List<string> savedData(List<string> fileList, List<Word> databaseList)
        //{
        //    List<string> databaseListEng = new List<string>(databaseList.Select(x => x.english));
        //    var result = fileList.Except(databaseListEng).ToList();
        //    return result;
        //}
    }
}
