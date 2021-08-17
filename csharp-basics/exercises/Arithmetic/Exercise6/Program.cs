using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 110; i++)
            {              
                if ((i-1) % 11 == 0)
                    Console.WriteLine("");
                Console.Write(CozaLoza.MakeCoza(i));
            }
            Console.ReadKey();
        }
    }
}
