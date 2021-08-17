using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine(CalculateSalaries.CalculateSalary(8.2, 47));
            Console.WriteLine(CalculateSalaries.CalculateSalary(10, 50));
            Console.WriteLine(CalculateSalaries.CalculateSalary(12, 40));
            Console.ReadKey();
        }
    }
}
