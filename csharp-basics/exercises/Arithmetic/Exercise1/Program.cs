using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Please enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CheckIfFifteen.IsFifteen(num1, num2));
            Console.ReadKey();
        }
    }
}