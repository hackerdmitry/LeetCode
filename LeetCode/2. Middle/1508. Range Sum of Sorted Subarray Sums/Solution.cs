using System.Collections.Generic;

namespace LeetCode._2._Middle._1508._Range_Sum_of_Sorted_Subarray_Sums;

public class Solution
{
    private const int modulo = 1_000_000_007;

    public int RangeSum(int[] nums, int n, int left, int right)
    {
        var sortedDictionary = new SortedDictionary<int, int>();

        for (var i = 0; i < n; i++)
        {
            var sum = 0;
            for (var j = i; j < n; j++)
            {
                sum += nums[j];
                if (!sortedDictionary.TryAdd(sum, 1))
                    sortedDictionary[sum]++;
            }
        }

        var resultSum = 0;
        var counter = 1;
        foreach (var (sum, count) in sortedDictionary)
            for (var i = 0; i < count; i++, counter++)
            {
                if (counter >= left)
                    resultSum = (resultSum + sum) % modulo;

                if (counter == right)
                    return resultSum;
            }

        return resultSum;
    }
}