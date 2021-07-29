using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {

        private static void Main(string[] args)
        {
            var readText = File.ReadAllText("midtermscores.txt").Split(' ').ToArray(); 
            
            string[] scores = new string[11];
            for (int i = 0; i < readText.Length; i++)
            {
                if(Convert.ToInt32(readText[i]) <10)
                {
                    scores[0] += "*";
                } else if (Convert.ToInt32(readText[i]) > 99)
                {
                    scores[10] += "*";
                } else
                {
                    scores[Convert.ToInt32(readText[i][0].ToString())] += "*";
                }
            }
            Console.WriteLine(readText.Length);
            Console.WriteLine($"00-09: {scores[0]}");
            Console.WriteLine($"10-19: {scores[1]}");
            Console.WriteLine($"20-29: {scores[2]}");
            Console.WriteLine($"30-39: {scores[3]}");
            Console.WriteLine($"40-49: {scores[4]}");
            Console.WriteLine($"50-59: {scores[5]}");
            Console.WriteLine($"60-69: {scores[6]}");
            Console.WriteLine($"70-79: {scores[7]}");
            Console.WriteLine($"80-89: {scores[8]}");
            Console.WriteLine($"90-99: {scores[9]}");
            Console.WriteLine($"100: {scores[10]}");     

            {
                
            }
        }
    }
}
