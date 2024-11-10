using System;

namespace LeetCode._2._Middle._3097._Shortest_Subarray_With_OR_at_Least_K_II;

public class Solution
{
    public int MinimumSubarrayLength(int[] nums, int k)
    {
        var result = int.MaxValue;
        var startWindow = 0;
        var endWindow = 0;

        var binaryCounts = new int[32];
        while (endWindow != nums.Length)
        {
            AddNumber(binaryCounts, nums[endWindow++]);

            while (CountDisjunction(binaryCounts) >= k && startWindow < endWindow)
            {
                result = Math.Min(result, endWindow - startWindow);
                RemoveNumber(binaryCounts, nums[startWindow++]);
            }
        }

        return result == int.MaxValue ? -1 : result;
    }

    private void AddNumber(int[] binaryCounts, int number)
    {
        for (var i = binaryCounts.Length - 1; i >= 0 && number > 0; i--, number >>= 1)
            if (number % 2 == 1)
                binaryCounts[i]++;
    }

    private void RemoveNumber(int[] binaryCounts, int number)
    {
        for (var i = binaryCounts.Length - 1; i >= 0 && number > 0; i--, number >>= 1)
            if (number % 2 == 1)
                binaryCounts[i]--;
    }

    private int CountDisjunction(int[] binaryCounts)
    {
        var result = 0;
        foreach (var binaryCount in binaryCounts)
        {
            result <<= 1;
            if (binaryCount != 0)
                result++;
        }

        return result;
    }
}