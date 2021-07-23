using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            int power;

            Console.WriteLine("Input power : ");
            power = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= power; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
