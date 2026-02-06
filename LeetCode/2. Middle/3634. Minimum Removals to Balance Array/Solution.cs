using System;

namespace LeetCode._2._Middle._3634._Minimum_Removals_to_Balance_Array;

public class Solution
{
    public int MinRemoval(int[] nums, int k)
    {
        Array.Sort(nums);

        var left = 0;
        var minRemoval = int.MaxValue;
        for (var right = 0; right < nums.Length; right++)
        {
            while ((long) k * nums[left] < nums[right])
                left++;

            minRemoval = Math.Min(minRemoval, nums.Length - (right - left + 1));
        }

        return minRemoval;
    }
}