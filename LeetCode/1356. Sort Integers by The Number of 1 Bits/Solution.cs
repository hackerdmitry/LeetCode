using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1356._Sort_Integers_by_The_Number_of_1_Bits
{
    public class Solution
    {
        public int[] SortByBits(int[] arr)
        {
            var comparer = new SortHelper();
            return arr.OrderBy(x => x, comparer).ToArray();
        }

        private class SortHelper : IComparer<int>
        {
            public int Compare(int a, int b)
            {
                var aBits = CountBits(a);
                var bBits = CountBits(b);

                if (aBits < bBits)
                    return -1;
                if (aBits > bBits)
                    return 1;

                return a < b
                    ? -1
                    : a > b ? 1 : 0;
            }

            static int CountBits(int a)
            {
                var countBits = 0;
                while (a != 0)
                {
                    if (a % 2 != 0)
                        countBits++;
                    a /= 2;
                }

                return countBits;
            }
        }
    }
}