using System;
using System.Linq;

namespace TenBillion
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            long input = Convert.ToInt64(Console.ReadLine());

            if (input > 10000000000)
            {
                Console.WriteLine("the number is too large");
            }
            else
            {
                
                int count = input.ToString().ToCharArray().Count();
                Console.WriteLine(count);
            }

            Console.ReadKey();

        }
    }
}
