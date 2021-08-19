using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public SortedDictionary<string, string> _data = new SortedDictionary<string,string>();
               
        public string Finder(string name)
        {
            try
            {
                return _data[name];
            }
            catch (KeyNotFoundException)
            {
                return $"Name {name} is not found.";
            }       
        }
        public void PutNumber(string name, string number) 
        {
            if (name == "" || number == "")
            {
                throw new ArgumentException("name and/or number cant be null");
            }
            _data[name] = number;
        }
    }
}