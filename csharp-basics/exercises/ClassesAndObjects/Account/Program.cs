using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var MattAccount = new Acc("Matts account", 1000);
            var MyAccount = new Acc("My account", 0);
            MattAccount.Withdrawal(100);
            MyAccount.Deposit(100);
            Console.WriteLine(MattAccount);
            Console.WriteLine(MyAccount);

            var aAccount = new Acc("A account", 100.00);
            var bAccount = new Acc("B account",0);
            var cAccount = new Acc("C Account", 0);
            Console.WriteLine("Initial state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);
            aAccount.Name = "GGGG";
            Transfer(aAccount,bAccount, 50.0);
            Transfer(bAccount,cAccount, 25.0);
            
            Console.WriteLine("Final state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);

            Console.ReadKey();
        }

        public static void Transfer(Acc from, Acc to, double howMuch)
        {
            to.Deposit(howMuch);
            from.Withdrawal(howMuch);
        }
    }
}
