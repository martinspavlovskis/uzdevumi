using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Martins", "Pavlovskis", "Brivibas iela", 1, 3.6);
            var employee = new Employee("Karlis", "Pavlovskis", "Gertrudes iela", 2, "Software Developer");
            student.Display();
            employee.Display();
        }
    }
}