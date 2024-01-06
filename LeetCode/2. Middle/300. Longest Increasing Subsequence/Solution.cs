using System;

namespace LeetCode._2._Middle._300._Longest_Increasing_Subsequence;

public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        var counts = new int[nums.Length];
        var result = 0;

        for (var i = 0; i < counts.Length; i++)
        {
            var max = -1;
            for (var j = 0; j < i; j++)
                if (nums[j] < nums[i] && counts[j] > max)
                    max = counts[j];

            if (max == -1)
                counts[i] = 1;
            else
                counts[i] = max + 1;

            result = Math.Max(counts[i], result);
        }

        return result;
    }
}
