using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point(2, 5);
            var point2 = new Point(3, 7);
            
            Point.SwapPoints(point1, point2);
            Console.WriteLine("point1: (" + point1.X + ", " + point1.Y + ")");
            Console.WriteLine("point2: (" + point2.X + ", " + point2.Y + ")");
            Console.ReadKey();
        }
    }
}
