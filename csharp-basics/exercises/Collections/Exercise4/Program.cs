using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            static int isHappyNumber(int n)
            {
                HashSet<int> st = new HashSet<>();
                while (1)
                {
                    n = numSquareSum(n);
                    if (n == 1)
                        return true;
                    if (st.Contains(n))
                        return false;

                    st.Add(n);
                }
            }

        }
    }
}
