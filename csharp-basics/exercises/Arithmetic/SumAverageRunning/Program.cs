using System;
using System.Linq;

namespace SumAverageRunning
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter lower range");
            int lowerRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter upper range");
            int upperRange = Convert.ToInt32(Console.ReadLine());

            int sum = Enumerable.Range(lowerRange, upperRange).Sum();
            double average = Enumerable.Range(lowerRange, upperRange).Average();

            Console.WriteLine($"The total sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.ReadKey();
        }
    }
}
