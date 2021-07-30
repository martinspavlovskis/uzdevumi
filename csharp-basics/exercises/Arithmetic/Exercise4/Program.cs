using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            int number = 10;

            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

