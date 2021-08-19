using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Commission : Hourly
    {
        private double _totalSalesMade;
        private double _commisionRate;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate,double commisionRate)
            :base(eName,eAddress,ePhone,socSecNumber,rate)
        {
            _commisionRate = commisionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSalesMade += totalSales;
        }
        public override double Pay()
        {
            var payment = payRate * _hoursWorked + _totalSalesMade * _commisionRate;
            _totalSalesMade = 0;
            return payment;
        }
        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales: " + _totalSalesMade;
            return result;
        }
    }
}
