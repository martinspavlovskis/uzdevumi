using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return Math.Round(length * width);
        }

        public static double AreaOfTriangle(double ground, double h)
        {
            return Math.Round(0.5 * ground * h, 2);
        }
    }
}
