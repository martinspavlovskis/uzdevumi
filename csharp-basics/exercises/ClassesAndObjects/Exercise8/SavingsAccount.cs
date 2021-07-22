using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class SavingsAccount
    {
        private double _annualInterestRate;
        private double _balance;
        private double _totalWithdraw;
        private double _totalDeposit;
        private double _totalInterestEarned;

        public SavingsAccount(double startingBalance, double annualRate)
        {
            this._balance = startingBalance;
            this._annualInterestRate = annualRate;
        }

        public void Withdraw(double amount)
        {
           this._balance = _balance - amount;
           this._totalWithdraw += amount;
        }

        public void Deposit(double amount)
        {
            this._balance = _balance + amount;
            this._totalDeposit += amount;
        }

        public double TotalWithdraw()
        {
            return this._totalWithdraw;
        }

        public double TotalDeposit()
        {
            return this._totalDeposit;
        }

        public double AddInterestMonthly()
        {
            double monthlyInterestEarned = (_annualInterestRate / 12) * this._balance;
            this._balance += monthlyInterestEarned;
            this._totalInterestEarned = this._totalInterestEarned + monthlyInterestEarned;
            return this._totalInterestEarned;
            
        }      

        public double EndBalance()
        {
            return this._balance;
        }
    }


}
