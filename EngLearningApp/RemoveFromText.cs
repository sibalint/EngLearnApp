using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngLearningApp
{
    public static class RemoveFromText
    {
        public static string unnecessarySpecCharacters(string text)
        {
            text = text.Replace(".", "");
            text = text.Replace("!", "");
            text = text.Replace("?", "");
            text = text.Replace(",", "");
            text = text.Replace("\"", "");
            text = text.Replace("\'", "");
            text = text.Replace("(", "");
            text = text.Replace(")", "");
            text = text.Replace("\\", "");
            text = text.Replace(";", "");
            text = text.Replace(":", "");

            //trim - chars
            text = text.Replace(" -", " ");
            text = text.Replace("- ", " ");

            return text;
        }

        public static string numbers(string text)
        {
            text = text.Replace("1", "");
            text = text.Replace("2", "");
            text = text.Replace("3", "");
            text = text.Replace("4", "");
            text = text.Replace("5", "");
            text = text.Replace("6", "");
            text = text.Replace("7", "");
            text = text.Replace("8", "");
            text = text.Replace("9", "");
            text = text.Replace("0", "");

            return text;
        }


    }
}
