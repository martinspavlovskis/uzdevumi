using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
        public class WordCounter
        { 
        public static int CountLines(string text)
        {
            return text.Split('\n').Length;
        }
        public static int CountWords(string text)
        {
            return text.Replace(",", " ").Replace("'", " ").Split(' ').Length;
        }
        public static int CountChars(string text)
        {
            return String.Join("", text).ToCharArray().Length;
        }
    }
}
