using System;
using System.Linq;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string str = Console.ReadLine();

            int count = str.Count(x => char.IsUpper(x));

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
