using System;
using System.Collections.Generic;
using System.Linq;


namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordList = { "ruby", "python", "java", "javascript" };
            Random rand = new Random();           
            string randomWord = wordList[rand.Next(0, 4)];
            char[] guess = new char[randomWord.Length];
            List<char> misses = new List<char>();
            int guessesLeft = 10;
            int counter = 0;


            for (int p = 0; p < randomWord.Length; p++)
                guess[p] = '*';

            Console.WriteLine("Welcome to Hangman. Type in your guess.");
            Console.WriteLine($"You have {guessesLeft} wrong guesses.");
            Console.WriteLine(guess);

            while (guessesLeft > 0)
            {

                char playerGuess = Convert.ToChar(Console.ReadLine());
                for (int j = 0; j < randomWord.Length; j++)
                {


                    if (playerGuess == randomWord[j])
                    {
                        guess[j] = playerGuess;
                        counter++;
                    }

                }

                if (!guess.Contains(playerGuess))
                {
                    misses.Add(playerGuess);
                    guessesLeft--;
                }

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine();
                Console.WriteLine(guess);
                Console.WriteLine();
                Console.Write("Misses: ");
                Console.WriteLine(String.Join(" ", misses));
                Console.WriteLine();
                Console.WriteLine($"You have {guessesLeft} wrong guesses left");
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");

                if (counter == randomWord.Length)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine($"You ran out of guesses. The correct word was: {randomWord}");
            Console.ReadKey();

        }
    }
}

