using System;

namespace Loops7
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            bool isPlaying = true;
            int score = 0;
            

            Console.WriteLine("Welcome to Piglet!");

            while (isPlaying)
            {
                int roll = rand.Next(1, 7);

                    if (roll == 1)
                    {
                        Console.WriteLine("You rolled a 1! You got 0 points.");
                        isPlaying = false;
                        break;
                    }
                    score += roll;
                    Console.WriteLine($"You rolled a {roll}!");
                    Console.Write("Roll again? (y or n)");
                    string answer = Console.ReadLine();

                if (answer == "n")
                {
                    isPlaying = false;
                    Console.WriteLine($"You got {score} points.");
                    break;
                }                        
            }
            Console.ReadKey();
        }
    }
}
