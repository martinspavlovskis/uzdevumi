using System;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of single digit numbers without spaces");
            string number = Console.ReadLine();

            int[] arr = number.Select(x => int.Parse(x.ToString())).ToArray();
            int total = arr.Sum();

            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
