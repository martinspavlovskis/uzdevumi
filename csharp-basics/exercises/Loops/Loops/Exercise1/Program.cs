using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int number = 10;

            Console.WriteLine("The first 10 natural numbers are: ");

            for (i = 1; i <= number; i++) 
            {
              Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
