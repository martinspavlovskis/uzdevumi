using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckIfOddOrEven.CheckIfEvenOrOdd(num));
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
