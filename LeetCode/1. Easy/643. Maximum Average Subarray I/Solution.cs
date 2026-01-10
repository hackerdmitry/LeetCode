using System;
using System.Linq;

namespace LeetCode._1._Easy._643._Maximum_Average_Subarray_I;

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        var sum = nums.Take(k).Sum();
        var maxSum = sum;
        for (var i = k; i < nums.Length; i++)
        {
            sum += nums[i] - nums[i - k];
            maxSum = Math.Max(maxSum, sum);
        }

        return (double)maxSum / k;
    }
}