using System;

namespace Loops3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            var rand = new Random();     

            for(int i = 0; i <= 19; i++)
            {
                arr[i] = rand.Next(1, 100);
            }

            Console.Write("Array: ");
            foreach(int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Which numbers index do you want to know?");
            int wantedNumber = Convert.ToInt32(Console.ReadLine());

            int ind = Array.IndexOf(arr, wantedNumber);
            
            if( ind == -1)
            {
                Console.WriteLine("This number is not in the array");
            } else
            {
                Console.WriteLine($"The index of {wantedNumber} is {ind}");
            }
        }
    }
}
