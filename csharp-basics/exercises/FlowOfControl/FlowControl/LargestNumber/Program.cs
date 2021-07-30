using System;

namespace LargestNumber
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number: ");
            int input3 = Convert.ToInt32(Console.ReadLine());

            if (input1 > input2)
            {
                
                if (input1 > input3)
                {
                    Console.WriteLine($"The largest number is {input1}");
                }
                else
                {
                    Console.WriteLine($"The largest number is {input3}");
                }
            }
            else
            {
                if (input2 > input3)
                {
                    Console.WriteLine($"The largest number is {input2}");
                }
                else
                {
                    Console.WriteLine($"The largest number is {input3}");
                }
            }

            Console.ReadKey();
        }
    }
}
