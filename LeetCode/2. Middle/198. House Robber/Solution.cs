using System;
using System.Linq;

namespace LeetCode._2._Middle._198._House_Robber;

public class Solution
{
    public int Rob(int[] nums)
    {
        var dp = new int[nums.Length];
        if (nums.Length > 0)
            dp[0] = nums[0];
        if (nums.Length > 1)
            dp[1] = nums[1];
        for (var i = 2; i < nums.Length; i++)
            dp[i] = nums[i] +
                    (i == 2
                        ? dp[0]
                        : Math.Max(dp[i - 2], dp[i - 3]));

        return Math.Max(dp.LastOrDefault(0), dp.SkipLast(1).LastOrDefault(0));
    }
}