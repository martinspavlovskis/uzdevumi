using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _adress;
        private int _id;
        public Person()
        {
        }
        public Person(string firstName, string lastName, string adress, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _adress = adress;
            _id = id;
        }
        public string FirstName
        {
            get { return _firstName; }
            private set { _firstName = value; }
        }

        public string LastName
        {
           get { return _lastName; }
           private set { _lastName = value; }
        }

        public string Adress
        {
           get { return _adress; }
           private set { _adress = value; }
        }

        public int Id
        {
           get { return _id; }
           private set { _id = value; }
        }
        public virtual void Display()
        {
            Console.WriteLine($"First name: {FirstName}\nLast name: {LastName}\nAdress: {Adress}\nId: {Id}");
        }
    }
}
