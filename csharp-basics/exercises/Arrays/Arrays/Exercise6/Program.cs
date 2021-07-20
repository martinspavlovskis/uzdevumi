using System;

namespace Arrays6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            int[] arr2 = new int[arr.Length];

            var rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(101);

            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr[i];

            }

            arr[arr.Length - 1] = -7;

            Console.WriteLine("{0}", string.Join(", ", arr));
            Console.WriteLine("{0}", string.Join(", ", arr2));

            Console.ReadKey();

        }
    }
}
