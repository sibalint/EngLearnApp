using EngLearningApp.model;
using System.Collections.Generic;
using System.Linq;

namespace EngLearningApp
{
    public class RemoveFromList
    {
        #region Members
        private List<Word> wordsFromDatabase;
        private List<string> wordsFromDatabase_JustEnglishWords;
        private List<string> affixes = new List<string>(new string[] { "s", "es", "ed", "d", "ing", "`s", "`ll", "n`t", "`t", "`ve", "`re", "ly" }); //affixes=ragok
        #endregion

        #region Constructor
        public RemoveFromList(List<Word> wordsFromDatabase)
        {
            this.wordsFromDatabase = wordsFromDatabase;
            this.wordsFromDatabase_JustEnglishWords = wordsFromDatabase.Select(x => x.english).ToList();
        }
        #endregion

        #region Public Methods
        public List<string> unnessesarryItems(List<string> list)
        {            
            list.AddRange(wordsFromDatabase_JustEnglishWords);
            list = duplicateWords(list);
            list = affix(list);
            list = oneLenghtItems(list);
            list = savedData(list, wordsFromDatabase);

            return list;
        }
        #endregion

        #region Private methods
        private List<string> duplicateWords(List<string> words)
        {
            HashSet<string> set = new HashSet<string>(words);
            var list = set.ToList();
            var ascendingOrder = list.OrderBy(i => i).ToList();
            return ascendingOrder;
        }

        private List<string> affix(List<string> list)
        {
            list.Remove("");
            var resultList = new List<string>(list);
            foreach (var word in list)
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

        private List<string> oneLenghtItems(List<string> list)
        {
            list.RemoveAll(x => x.Length <= 1);

            return list;

        }

        private List<string> savedData(List<string> wordsFromFile, List<Word> wordsFromDatabase)
        {
            List<string> databaseListEng = new List<string>(wordsFromDatabase_JustEnglishWords);
            var result = wordsFromFile.Except(databaseListEng).ToList();
            return result;
        }
        #endregion
    }
}
