using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 110; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine("Coza");
                else if (i % 5 == 0)
                    Console.WriteLine("Woza");
                else if (i % 7 == 0)
                    Console.WriteLine("CozaLoza");
                else if (i % 3 != 0 || i % 5 != 0 || i % 7 != 0)
                    Console.WriteLine(i);
                if (i % 11 == 0)
                    Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
