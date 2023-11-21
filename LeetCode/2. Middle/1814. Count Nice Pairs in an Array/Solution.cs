using System.Collections.Generic;

namespace LeetCode._2._Middle._1814._Count_Nice_Pairs_in_an_Array;

public class Solution
{
    private const int module = 1_000_000_007;

    public int CountNicePairs(int[] nums)
    {
        var dictDiffs = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            var diff = num - GetRev(num);
            if (dictDiffs.ContainsKey(diff))
                dictDiffs[diff]++;
            else
                dictDiffs[diff] = 1;
        }

        var sum = 0L;
        foreach (var (_, count) in dictDiffs)
        {
            sum += (long)count * (count - 1) / 2;
            sum %= module;
        }

        return (int)sum;
    }

    private int GetRev(int num)
    {
        var revNum = 0;
        while (num > 0)
        {
            revNum = revNum * 10 + num % 10;
            num /= 10;
        }

        return revNum;
    }
}
