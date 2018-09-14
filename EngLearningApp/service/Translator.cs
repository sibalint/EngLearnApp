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

            string xpath = "//*[@id='searchresults']/div[2]/div/div/div[2]/ol/li/div[2]/ol[1]/li/div/a";

            string hun="";
            try
            {
                HtmlDocument doc = new HtmlWeb().Load(fullPath);

                var itemList = doc.DocumentNode.SelectNodes(xpath).Select(p => p.InnerText).ToList();
                hun = itemList.FirstOrDefault().ToString();
            }
            catch (System.Exception)
            {
                //TODO: write exception somewhere
            }
            

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
#warning
                //tempWord.hungarian = EngToHun(engWord); 

                directory.Add(tempWord);
            }

            return directory;
        }
    }
}
