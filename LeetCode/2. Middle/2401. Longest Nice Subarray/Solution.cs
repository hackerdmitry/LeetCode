using System;

namespace LeetCode._2._Middle._2401._Longest_Nice_Subarray;

public class Solution
{
    public int LongestNiceSubarray(int[] nums)
    {
        var maxLength = 1;
        var endIndex = 0;
        var result = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            while ((result & nums[i]) != 0)
                result ^= nums[endIndex++];
            result ^= nums[i];
            maxLength = Math.Max(i - endIndex + 1, maxLength);
        }

        return maxLength;
    }
}
