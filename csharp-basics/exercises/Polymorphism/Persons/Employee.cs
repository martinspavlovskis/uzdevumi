using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Employee : Person
    {
        private string _jobTitle;

        public Employee(string firstName, string lastName, string adress, int id, string jobTitle)
            :base(firstName,lastName,adress,id)
        {
            _jobTitle = jobTitle;
        }

        public string JobTitle
        {
            get { return _jobTitle; }
            private set { _jobTitle = value; }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Job title: {JobTitle}");
        }
    }
}
