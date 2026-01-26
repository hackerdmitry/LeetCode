using System;
using System.Collections.Generic;

namespace LeetCode._1._Easy._1200._Minimum_Absolute_Difference;

public class Solution
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        var result = new List<IList<int>>();

        Array.Sort(arr);
        var minDiff = int.MaxValue;
        for (var i = 1; i < arr.Length; i++)
            minDiff = Math.Min(minDiff, arr[i] - arr[i - 1]);

        for (var i = 1; i < arr.Length; i++)
            if (arr[i] - arr[i - 1] == minDiff)
                result.Add(new[] {arr[i - 1], arr[i]});

        return result;
    }
}