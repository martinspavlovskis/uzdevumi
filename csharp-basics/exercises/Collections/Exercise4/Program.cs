using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter an integer");
            string number = Console.ReadLine();
            int sum = 0;


            var array = number.ToCharArray();
            while (sum < 0)
            {
                foreach (var n in array)
                {
                    sum += Convert.ToInt32(n.ToString()) * Convert.ToInt32(n.ToString());
                }
            }
            Console.WriteLine(sum);
            
            


        }
    }
}
