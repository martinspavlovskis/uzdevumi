using Exercise6;
using System;

namespace Arrays6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = ArrayExtensions.GenerateRandomNumberArray();
            int[] arr2 = ArrayExtensions.MakeNewArrayFromExistingArray(arr);
        
            Console.WriteLine("{0}", string.Join(", ", arr));
            Console.WriteLine("{0}", string.Join(", ", arr2));

            Console.ReadKey();
        }
    }
}
