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
            var text = File.ReadAllText("lear.txt");
        
            Console.WriteLine($"Lines = {WordCounter.CountLines(text)}");
            Console.WriteLine($"Words = {WordCounter.CountWords(text)}");
            Console.WriteLine($"Characters = {WordCounter.CountChars(text)}");
            Console.Read();
        }
    }
}
