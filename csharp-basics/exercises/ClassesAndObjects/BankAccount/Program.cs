using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var newAcc = new BankAccount("John Doe", 1000.00);

            Console.WriteLine(newAcc.ShowUserNameAndBalance());
        }
    }
}
