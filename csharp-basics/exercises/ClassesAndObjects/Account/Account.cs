namespace Account
{
    class Account
    {
        private string _name;
        private double _money;

        public Account(string name, double money)
        {
            this._name = name;
            this._money = money;
        }

        public double Withdrawal(double i)
        {
           this._money = this._money - i;
           return i;
        }

        public void Deposit(double i)
        {
            this._money = this._money + i;
        }

        public double Balance()
        {
            return _money;
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
