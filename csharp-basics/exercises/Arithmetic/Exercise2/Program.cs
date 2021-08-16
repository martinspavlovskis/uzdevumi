using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            static void CheckOddEven()
            {
                Console.WriteLine("Please enter a number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even number");
                }
                else
                {
                    Console.WriteLine("Odd number");
                }
                Console.WriteLine("Bye!");
            }
            CheckOddEven();
            Console.ReadKey();
        }
    }
}
