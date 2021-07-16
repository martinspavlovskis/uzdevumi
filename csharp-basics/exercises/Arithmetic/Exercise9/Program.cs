using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your weight in kilograms");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your height in centimeters");
            double height = Convert.ToDouble(Console.ReadLine());
            double BMI = Convert.ToDouble(weight / (height * height) * 10000);
            Console.WriteLine($"Your Body mass index is {BMI}");
            if (BMI < 18.5)
            {
                Console.WriteLine("You are underweight");
            }
            else if (BMI > 25)
            {
                Console.WriteLine("You are overweight");
            }
            else
            {
                Console.WriteLine("You are optimal weight");
            }
            Console.ReadKey();
        }
    }
}
