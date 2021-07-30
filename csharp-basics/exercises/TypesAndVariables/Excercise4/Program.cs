using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your year of birth");
            string yearOfBirth = Console.ReadLine();

            Console.WriteLine($"My name is {name} and I was born in {yearOfBirth}.");
            Console.ReadKey();
        }
    }
}

