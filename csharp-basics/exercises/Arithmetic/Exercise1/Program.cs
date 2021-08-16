using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            static bool Program()
            {
                Console.WriteLine("Please enter the first number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 == 15 || num2 == 15 || num1 + num2 == 15 || Math.Abs(num1 - num2) == 15)
                {
                    return true;
                }
                return false;
            }

            Program();
            Console.ReadKey();

        }
    }
}