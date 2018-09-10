using EngLearningApp.model;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;

namespace EngLearningApp
{
    class Translator
    {
        public string EngToHun(string eng)
        {
            string htmlPath_Front= @"http://www.szotar.sztaki.hu/search?searchWord=";
            string htmlPath_End = @"&fromlang=eng&tolang=hun&outLanguage=hun";
            string fullPath = htmlPath_Front + eng + htmlPath_End;

            HtmlDocument doc = new HtmlWeb().Load(fullPath);

            var itemList = doc.DocumentNode.SelectNodes("//*[@id='searchresults']/div[2]/div/div/div[2]/ol/li/div[2]/ol[1]/li/div/a").Select(p => p.InnerText).ToList();
            string hun = itemList.FirstOrDefault().ToString();

            return hun;
        }

        public List<Word> getDirectory(List<string> engWords)
        {
            List<Word> directory = new List<Word>();
            Word tempWord=new Word();
            tempWord.knowledgeLevel = KnownColor.Red;

            foreach (var engWord in engWords)
            {
                tempWord.english = engWord;
                tempWord.hungarian = EngToHun(engWord);

                directory.Add(tempWord);
            }

            return directory;
        }
    }
}
