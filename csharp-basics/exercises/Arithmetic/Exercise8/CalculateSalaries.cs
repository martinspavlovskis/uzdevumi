using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public class CalculateSalaries
    {
        public static double CalculateSalary(double baseSalary, int hoursWorked)
        {

            double minimumWage = 8.0;
            int maxHours = 60;        

            if (baseSalary < minimumWage || hoursWorked > maxHours)
            {
                throw new ArgumentException("Error");
            }
            else
            {
                if (hoursWorked > 40)
                {
                   return baseSalary * 40 + 1.5 * baseSalary * (hoursWorked - 40);
                }
                else
                {
                   return  baseSalary * hoursWorked;
                }
                
            }
            
        }
    }
}
