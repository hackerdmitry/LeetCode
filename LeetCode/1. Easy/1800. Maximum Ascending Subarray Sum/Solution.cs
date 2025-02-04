using System;

namespace LeetCode._1._Easy._1800._Maximum_Ascending_Subarray_Sum;

public class Solution
{
    public int MaxAscendingSum(int[] nums)
    {
        var result = nums[0];
        var sum = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
                sum += nums[i];
            else
                sum = nums[i];
            result = Math.Max(result, sum);
        }

        return result;
    }
}
