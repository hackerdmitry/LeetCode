using System;

namespace LeetCode._2._Middle._1493._Longest_Subarray_of_1_s_After_Deleting_One_Element;

public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        var prevContinuousOnesCount = 0;
        var currentContinuousOnesCount = 0;

        var result = 0;

        foreach (var num in nums)
            if (num == 1)
                currentContinuousOnesCount++;
            else
            {
                result = Math.Max(result, currentContinuousOnesCount + prevContinuousOnesCount);
                prevContinuousOnesCount = currentContinuousOnesCount;
                currentContinuousOnesCount = 0;
            }

        return Math.Min(nums.Length - 1, Math.Max(result, currentContinuousOnesCount + prevContinuousOnesCount));
    }
}
