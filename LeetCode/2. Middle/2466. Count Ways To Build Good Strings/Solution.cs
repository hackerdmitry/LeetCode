using System.Collections.Generic;

namespace LeetCode._2._Middle._2466._Count_Ways_To_Build_Good_Strings;

public class Solution
{
    private const int mod = 1_000_000_007;

    public int CountGoodStrings(int low, int high, int zero, int one)
    {
        var sum = 0;

        var arr = new int[high + 1];
        arr[0] = 1;

        for (var i = 1; i <= high; i++)
        {
            if (zero <= i)
                arr[i] = (arr[i] + arr[i - zero]) % mod;
            if (one <= i)
                arr[i] = (arr[i] + arr[i - one]) % mod;
            if (i >= low)
                sum = (sum + arr[i]) % mod;
        }

        return sum;
    }
}
