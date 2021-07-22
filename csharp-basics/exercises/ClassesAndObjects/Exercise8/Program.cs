using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How much money is in the account? ");
            double balanceAtStart = Convert.ToDouble((Console.ReadLine()));
            Console.WriteLine("Please enter annual interest rate of Your account: ");
            double annualRate = Convert.ToDouble((Console.ReadLine()));
            Console.WriteLine("How long has the account been opened? ");
            int months = Convert.ToInt32((Console.ReadLine()));

            var myAcc = new SavingsAccount(balanceAtStart, annualRate);           

            for (int i = 1; i <= months; i++)
            {
                Console.WriteLine($"Enter sum withdrawn in month {i}: ");
                myAcc.Withdraw(Convert.ToDouble((Console.ReadLine())));
                
                
                Console.WriteLine($"Enter sum deposited in month {i}: ");
                myAcc.Deposit(Convert.ToDouble((Console.ReadLine())));
              
            }

            Console.WriteLine($"Total deposited: {myAcc.TotalDeposit()} eur");
            Console.WriteLine($"Total withdrawn: {myAcc.TotalWithdraw()} eur");
            Console.WriteLine($"Interest earned: {myAcc.TotalInterest()} eur");
            Console.WriteLine($"Ending balance: {myAcc.EndBalance()} eur");
        }
    }
}
