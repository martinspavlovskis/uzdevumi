using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class ArrayExtensions
    {
        public static int[] GenerateRandomNumberArray()
        {
            int[] arr = new int[10];
            var rand = new Random();

            for (var i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(101);
            }
            return arr;
        }
        public static int[] MakeNewArrayFromExistingArray(int[]array)
        {
            var arr2 = new int[10];
            for (var i = 0; i < 10; i++)
            {
                arr2[i] = array[i];
            }
            arr2[arr2.Length - 1] = -7;
            return arr2;
        }

    }
}
