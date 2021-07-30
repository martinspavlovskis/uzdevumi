using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Martins", "Pavlovskis", "Brivibas iela", 2, 3.5);
            var employee = new Employee("Karlis", "Pavlovskis", "Gertrudes iela", 4, "Software Developer");
            student.Display();
            employee.Display();
        }
    }
}
