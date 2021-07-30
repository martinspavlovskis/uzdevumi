using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an amount of minutes");

            int minutes = Convert.ToInt32(Console.ReadLine());

            int years = minutes / 525600;
            int minutesLeft = minutes % 525600;
            int days = minutesLeft / 1440;

            Console.WriteLine($"{minutes} minutes is {years} year(s) and {days} days.");
            Console.ReadKey();
        }
    }
}
