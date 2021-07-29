using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllLines("lear.txt");

            int lineCount = text.Count();
            int wordCount = File.ReadAllText("lear.txt").Replace(",", " ").Replace("'", " ").Split(' ').Length;
            int charCount = string.Join("", text).ToCharArray().Length;

            Console.WriteLine($"Lines = {lineCount}");
            Console.WriteLine($"Words = {wordCount}");
            Console.WriteLine($"Characters = {charCount}");
            Console.Read();

        }
    }
}
