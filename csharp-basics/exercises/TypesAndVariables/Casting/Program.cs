using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            Console.ReadKey();
        }

        static void first()
        {
            int a = 1,
                b = 2,
                c = 3,
                d = 4,
                e = 5;

            int sum = a + b + c + d + e;

            Console.WriteLine(sum);
        }

        static void second()
        {
            float a = 1f,
                  b = 2f,
                  c = 3f,
                  d = 4.2f,
                  e = 5.3f;

            float sum = a + b + c + d + e;

            Console.WriteLine(sum);
        }
    }
}

