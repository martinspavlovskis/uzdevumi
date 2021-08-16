using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdApp
{
    class Poster : Advert
    {
        private int _copies;
        private int _costPerCopy;
        private int _fee;
        private int _totalDimensions;

        public Poster(int fee, int totalDimensions, int copies, int costPerCopy) : base(fee)
        {
            _copies = copies;
            _totalDimensions = totalDimensions;
            _costPerCopy = costPerCopy;
            _fee = fee;
            base.SetFee(Cost());
        }

        public new int Cost()
        {
            if(_totalDimensions > 1000)
            {
                return (_fee + _copies * _costPerCopy) + 150;
            }
            return (_fee + _copies * _costPerCopy);
        }

        public override string ToString()
        {
            return "Poster Fee = " + Cost();
        }
    }
}
