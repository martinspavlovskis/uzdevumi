using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravityCalculator
{
    public class GravityCalculator
    {
        private static double _gravity = 9.81;
        public static double CalculateFinalPosition(double initialPosition, double fallingTime, double initialVelocity)
        {         
            return 0.5 * _gravity * Math.Pow(fallingTime, 2) + initialPosition * fallingTime + initialVelocity;          
        }
    }
}
