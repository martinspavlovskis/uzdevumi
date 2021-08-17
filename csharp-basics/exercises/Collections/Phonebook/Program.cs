using PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        { 
            var phoneDirectory = new PhoneDirectory();
            phoneDirectory.PutNumber("john", "123");
            
        }
    }
}
