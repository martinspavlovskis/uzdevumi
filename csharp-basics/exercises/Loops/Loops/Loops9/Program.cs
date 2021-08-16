using System;

namespace Loops9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your desired sum from 2 to 12;");
            int desiredSum = Convert.ToInt32(Console.ReadLine());

            var rand = new Random();
            int sum = 0;

            while(sum != desiredSum)
            {
                int dice1 = rand.Next(1, 7);
                int dice2 = rand.Next(1, 7);
                sum = dice1 + dice2;
                Console.WriteLine($"{dice1} and {dice2} = {sum}");
            }
            Console.ReadKey();
        }
    }
}
