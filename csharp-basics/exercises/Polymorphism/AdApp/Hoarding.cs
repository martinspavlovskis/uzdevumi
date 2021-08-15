namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        private int _numOfDays;
        private int _fee;

        public Hoarding(int fee,int rate,int numOfDays,bool isPrimeLocation) : base(fee)
        {
            _rate = rate;
            _numOfDays = numOfDays;
            _fee = fee;
            if (isPrimeLocation)
            {
                _rate += _rate / 2;
            }

            base.SetFee(Cost());
        }

        public new int Cost() 
        {
            return _fee + (_rate * _numOfDays);
        }

        public override string ToString() 
        {
            return "Hoarding Fee = " + Cost();
        }
    }
}