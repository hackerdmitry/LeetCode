using System;

namespace LeetCode._3._Hard._3821._Find_Nth_Smallest_Integer_With_K_One_Bits;

public class Solution
{
    public long NthSmallest(long n, int k)
    {
        var result = 0L;
        for (var i = 50; i >= 0 && k > 0; i--)
        {
            var count = Combinations(i, k);
            if (n > count)
            {
                n -= count;
                result |= 1L << i;
                k--;
            }
        }

        return result;
    }

    private static long Combinations(int positions, int ones)
    {
        if (ones > positions || ones < 0)
            return 0;

        if (positions == ones || ones == 0)
            return 1;

        var k = Math.Min(ones, positions - ones);
        var result = 1L;

        for (var i = 1; i <= k; i++)
            result = result * (positions - k + i) / i;

        return result;
    }
}