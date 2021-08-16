using System;

namespace FlowControl4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(PrintDayInWord(0));
            Console.WriteLine(PrintDayInWord(2));
            Console.WriteLine(PrintDayInWord(6));

            Console.ReadKey();


            static string PrintDayInWord(int dayNumber)
            {
                string day;

                switch (dayNumber)
                {
                    case 0:
                        day = "Sunday";
                        break;
                    case 1:
                        day = "Monday";
                        break;
                    case 2:
                        day = "Tuesday";
                        break;
                    case 3:
                        day = "Wednesday";
                        break;
                    case 4:
                        day = "Thursday";
                        break;
                    case 5:
                        day = "Friday";
                        break;
                    case 6:
                        day = "Saturday";
                        break;
                    default:
                        day = "Error";
                        break;
                }
                return day;
            }
        }
    }
}
