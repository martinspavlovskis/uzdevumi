using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDate = new Date(22, 10, 1995);
            myDate.DisplayDate();

            Console.WriteLine("Please enter a new year");
            int newYear = Convert.ToInt32(Console.ReadLine());
            myDate.SetYearDate(newYear);
            myDate.DisplayDate();

        }
    }
}
