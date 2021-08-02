using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data = new SortedDictionary<string,string>();
       
        public PhoneDirectory() 
        {
            _data = new SortedDictionary<string, string>();     
        }
        public string Find(string name)
        {          
          if (_data.ContainsValue(name))
            {
                Console.WriteLine($"{name} has the number: {_data[name]}");
            } 
            else
            {
                Console.WriteLine("nothing found");
            }
            return "";                 
        }       
        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }
          
            if (!_data.ContainsKey(name)) 
            {
                _data.Add(name,number);
            }
            else 
            {
                Console.Write("Already saved in contacts");              
            }
        }
    }
}