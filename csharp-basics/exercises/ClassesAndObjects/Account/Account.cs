using System;

namespace Account
{
    public class Acc
    {
        private string _name;
        private double _money;

        public Acc(string name, double money)
        {
            _name = name;
            _money = money;
        }

        public double Withdrawal(double i)
        {
            if (i > _money)
            {
                throw new ArgumentException("You dont have enough money");
            }
            return _money -= i;
           
        }

        public double Deposit(double i)
        {
            return this._money += i;
        }

        public string Balance()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"Account name: {_name}, Balance: {_money}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
