using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Date
    {
        private int Month;
        private int Day;
        private int Year;
        public Date(int day, int month, int year)
        {
            this.Month = month;
            this.Day = day;
            this.Year = year;
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

        public void DisplayDate()
        {
            Console.WriteLine($"{Day}/{Month}/{Year}");
        }
    }
}
