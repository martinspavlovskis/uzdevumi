using System;

namespace Loops5
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1;
            string word2;
            
            Console.WriteLine("Please enter your first word:");
            word1 = Console.ReadLine();
            Console.WriteLine("Please enter your second word:");
            word2 = Console.ReadLine();

            int wordLength = word1.Length + word2.Length;

            Console.Write(word1);

            for (int i = 0; i < 30 - wordLength; i++)
            {
                Console.Write(".");
            }
            Console.Write(word2);
            Console.ReadKey();
        }
    }
}
