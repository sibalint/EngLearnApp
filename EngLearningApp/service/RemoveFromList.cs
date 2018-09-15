using EngLearningApp.model;
using System.Collections.Generic;
using System.Linq;

namespace EngLearningApp
{
    public static class RemoveFromList
    {
        private static List<string> affixes = new List<string>(new string[] { "s", "es", "ed", "d", "ing", "'s", "'ll", "n't", "'t", "'ve", "'re", "ly" }); //affixes=ragok

        public static List<string> unnessesarryItems(List<string> list)
        {
            list = duplicateWords(list);
            list = affix(list);
            list = oneLenghtItems(list);

            return list;
        }

        private static List<string> duplicateWords(List<string> words)
        {
            HashSet<string> set = new HashSet<string>(words);
            var list = set.ToList();
            var ascendingOrder = list.OrderBy(i => i).ToList();
            return ascendingOrder;
        }

        private static List<string> affix(List<string> wordList) 
        {
            wordList.Remove("");

            var resultList = new List<string>(wordList);
            foreach (var word in wordList)
            {
                foreach (var affix in affixes)
                {
                    if (resultList.Contains(word + affix))
                        resultList.Remove(word + affix);  
                }

                #region special affix: comE -> comING
                if (word[word.Length - 1] == 'e')
                {
                    //come -> coming
                    var wordWhitoutLastEPlusIng = word.Substring(0, word.Length - 1) + "ing";

                    if (resultList.Contains(wordWhitoutLastEPlusIng))
                        resultList.Remove(wordWhitoutLastEPlusIng);
                }
                #endregion

            }

            return resultList;
            
        }

        private static List<string> oneLenghtItems(List<string> list)
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
