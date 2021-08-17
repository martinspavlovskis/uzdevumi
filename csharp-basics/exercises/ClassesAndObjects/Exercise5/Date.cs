using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Date
    {
        private int Month;
        private int Day;
        private int Year;
        public Date(int day, int month, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        public void SetMonthDate(int month)
        {
            Month = month;
        }

        public int GetMonthDate()
        {
            return Month;
        }

        public void SetDayDate(int day)
        {
            Day = day;
        }

        public int GetDayDate()
        {
            return Day;
        }

        public void SetYearDate(int year)
        {
            Year = year;
        }

        public int GetYearDate()
        {
            return Year;
        }

        public string DisplayDate()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
