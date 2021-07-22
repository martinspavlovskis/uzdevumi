using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static void SwapPoints(Point point1, Point point2)
        {
            int x = point1.X;
            int y = point1.Y;
            point1.X = point2.X;
            point1.Y = point2.Y;
            point2.X = x;
            point2.Y = y;
        }
    }
}
