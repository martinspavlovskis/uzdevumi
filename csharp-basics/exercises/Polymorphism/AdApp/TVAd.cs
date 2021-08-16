namespace AdApp
{
    public class TVAd: Advert
    {
        private int _rate;
        private int _seconds;
        private int _fee;
        public TVAd(int fee,int rate,int seconds,bool isPrimeTime) : base(fee)
        {
            _rate = rate;
            _seconds = seconds;
            _fee = fee;
            if (isPrimeTime)
            {
                _rate *= 2;
            }

            base.SetFee(Cost());
        }
        
        public new int Cost() 
        {
            return _fee + (_rate * _seconds);
        }

        public override string ToString() 
        {
            return "TV Ad. Fee = " + Cost();
        }
    }
}