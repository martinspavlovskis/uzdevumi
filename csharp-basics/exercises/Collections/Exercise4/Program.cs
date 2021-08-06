using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isHappyNumber(num) ? "Happy number" : "Unhappy number");

             static bool isHappyNumber(int num)
            {
                var uniqueNum = new HashSet<int>();

                while (uniqueNum.Add(num))
                {
                    double value = 0;
                    while (num > 0)
                    {
                        value += Math.Pow(num % 10, 2);
                        num /= 10;
                    }
                    num = (int)value;
                }
               return num == 1;
            }
        }
    }
}
