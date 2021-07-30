using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your distance");
            int distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the hours");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the minutes");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the seconds");
            int seconds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Input distance in meters: {distance}");
            Console.WriteLine($"Input hour: {hours}");
            Console.WriteLine($"Input minutes: {minutes}");
            Console.WriteLine($"Input seconds: {seconds}");
            Console.WriteLine("Expected Output :");
            Console.WriteLine($"Your speed in meters/second is {(double)distance / (double)seconds}");
            Console.WriteLine($"Your speed in km/h is {((double)distance * 100) / (double)hours}");
            Console.WriteLine($"Your speed in miles/h is {((double)distance / 1609) / (double)hours}");
        }
    }
}
