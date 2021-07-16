using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {


            CalculateSalaries(7.5, 35);
            CalculateSalaries(8.2, 47);
            CalculateSalaries(10.0, 73);

            static void CalculateSalaries(double baseSalary, int hoursWorked)
            {

                double minimumWage = 8.0;
                int maxHours = 60;
                double finalSalary = 0;

                if (baseSalary < minimumWage || hoursWorked > maxHours)
                {
                    Console.WriteLine("An error has accured");
                }
                else
                {
                    if (hoursWorked > 40)
                    {
                        finalSalary = baseSalary * 40 + 1.5 * baseSalary * (hoursWorked - 40);
                    }
                    else
                    {
                        finalSalary = baseSalary * hoursWorked;
                    }
                    Console.WriteLine($"Total salary is: {finalSalary}");
                }
            }
            Console.ReadKey();
        }
    }
}
