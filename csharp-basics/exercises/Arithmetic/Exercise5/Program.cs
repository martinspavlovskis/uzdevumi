using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);

            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());

            if (guessedNumber < randomNumber)
            {
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {randomNumber}.");
            }
            else if (guessedNumber > randomNumber)
            {
                Console.WriteLine($"Sorry, you are too high.  I was thinking of {randomNumber}.");
            }
            else
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
            Console.ReadKey();
        }
    }
}
