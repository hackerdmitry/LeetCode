using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1438._Longest_Continuous_Subarray_With_Absolute_Diff_Less_Than_or_Equal_to_Limit;

public class Solution
{
    public int LongestSubarray(int[] nums, int limit)
    {
        var left = 0;
        var right = 0;
        var longestSubarray = 1;

        var dictionary = new Dictionary<int, int>();
        var sortedSet = new SortedSet<int>();

        while (right < nums.Length)
        {
            AddNumber(dictionary, sortedSet, nums[right++]);
            if (sortedSet.Max - sortedSet.Min <= limit)
                longestSubarray = Math.Max(longestSubarray, right - left);
            else
                RemoveNumber(dictionary, sortedSet, nums[left++]);
        }

        return longestSubarray;
    }

    private void AddNumber(Dictionary<int, int> dictionary, SortedSet<int> sortedSet, int number)
    {
        if (!dictionary.TryAdd(number, 1))
            dictionary[number]++;
        else
            sortedSet.Add(number);
    }

    private void RemoveNumber(Dictionary<int, int> dictionary, SortedSet<int> sortedSet, int number)
    {
        dictionary[number]--;
        if (dictionary[number] == 0)
        {
            dictionary.Remove(number);
            sortedSet.Remove(number);
        }
    }
}