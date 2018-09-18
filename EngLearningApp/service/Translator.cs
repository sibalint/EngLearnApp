using EngLearningApp.model;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;

namespace EngLearningApp
{
    class Translator
    {
        public static string EngToHun(string eng)
        {
            eng = "about";
            string htmlPath_Front= @"http://www.lingvozone.com/main.jsp?action=translation&do=dictionary&language_id_from=23&language_id_to=9&word=";
            string htmlPath_End = @"&t.x=21&t.y=9";
            string fullPath = htmlPath_Front + eng + htmlPath_End;
            
            //string xpath = "//*[@id='searchresults']/div[2]/div/div/div[2]/ol/li/div[2]/ol[1]/li/div/a";
              string xpath = "/html/body/table[1]/tbody/tr[2]/td[1]/table[1]/tbody/tr[2]/td[2]/a[1]";
            //xpath = "//*[@id='result_box']/span";
            string hun="";

            HtmlWeb web = new HtmlWeb();
            web.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36";

            HtmlDocument doc=  web.Load(fullPath);

            //HtmlDocument doc = new HtmlWeb().Load(fullPath);

            var a = doc.DocumentNode;
            
            var b = a.SelectNodes(xpath);
            var c = b.Select(p => p.InnerText);
            List<string> d = c.ToList();
            var eeeeee = d.FirstOrDefault();

            List<string> itemList = doc.DocumentNode.SelectNodes(xpath).Select(p => p.InnerText).ToList();
                hun = itemList.FirstOrDefault().ToString();
           
            

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
