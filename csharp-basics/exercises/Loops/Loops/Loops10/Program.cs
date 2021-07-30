using System;

namespace Loops10
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 5;

            for (int i = min; i <= max; i++)
            {
                for (int j = i; j <= max; j++)
                {
                    Console.Write(j);                 
                }
                for (int j = min; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
