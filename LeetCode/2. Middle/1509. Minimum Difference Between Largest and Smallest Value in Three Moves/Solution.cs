using System;

namespace LeetCode._2._Middle._1509._Minimum_Difference_Between_Largest_and_Smallest_Value_in_Three_Moves;

public class Solution
{
    public int MinDifference(int[] nums)
    {
        if (nums.Length <= 4)
            return 0;

        Array.Sort(nums);

        var minCount = nums.Length - 4;
        var minDiff = int.MaxValue;
        for (var i = minCount; i < nums.Length; i++)
            minDiff = Math.Min(nums[i] - nums[i - minCount], minDiff);

        return minDiff;
    }
}
