using System;

namespace LeetCode._1._Easy._1984._Minimum_Difference_Between_Highest_and_Lowest_of_K_Scores;

public class Solution
{
    public int MinimumDifference(int[] nums, int k)
    {
        Array.Sort(nums);
        var result = int.MaxValue;
        for (var i = --k; i < nums.Length; i++)
            result = Math.Min(result, nums[i] - nums[i - k]);
        return result;
    }
}
