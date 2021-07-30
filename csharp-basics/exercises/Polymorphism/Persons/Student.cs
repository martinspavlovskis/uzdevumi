using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Student : Person
    {
        private double _gpa;

        public Student(string firstName, string lastName, string adress, int id, double gpa)
            : base(firstName, lastName, adress, id)
        {
            _gpa = gpa;
        }

        public double Gpa
        {
            get { return _gpa; }
            private set { _gpa = value; }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Gpa: {Gpa}");
        }
    }
}
