using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Console.ReadKey();
        }

        static void First()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;

            int sum = a + b + c + d + e;

            Console.WriteLine(sum);
        }

        static void Second()
        {
            float a = 1f;
            float b = 2f;
            float c = 3f;
            float d = 4.2f;
            float e = 5.3f;

            float sum = a + b + c + d + e;

            Console.WriteLine(sum);
        }
    }
}

