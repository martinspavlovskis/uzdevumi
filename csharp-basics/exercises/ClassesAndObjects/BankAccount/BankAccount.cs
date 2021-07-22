using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        private string _name;
        private double _balance;

        public BankAccount(string name, double balance)
        {
            this._name = name;
            this._balance = balance;                     
        }
        public string ShowUserNameAndBalance()
        {


            if(_balance > 0)
            {
                return $"{_name}, ${_balance}";
            } else
            {
                return $"{_name}, -${_balance}";
            }
        }
    }
}
