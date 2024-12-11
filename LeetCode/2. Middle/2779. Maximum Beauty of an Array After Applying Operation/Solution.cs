using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._2779._Maximum_Beauty_of_an_Array_After_Applying_Operation;

public class Solution
{
    public int MaximumBeauty(int[] nums, int k)
    {
        var dictFrom = new Dictionary<int, int>();
        var dictTo = new Dictionary<int, int>();
        var min = int.MaxValue;
        var max = int.MinValue;

        foreach (var num in nums)
        {
            var from = num - k;
            if (!dictFrom.TryAdd(from, 1))
                dictFrom[from]++;
            min = Math.Min(min, from);

            var to = num + k;
            if (!dictTo.TryAdd(to, 1))
                dictTo[to]++;
            max = Math.Max(max, to);
        }

        var result = 0;
        var beauty = 0;
        for (var i = min; i <= max; i++)
        {
            if (dictFrom.TryGetValue(i, out var value))
                beauty += value;
            result = Math.Max(result, beauty);
            if (dictTo.TryGetValue(i, out value))
                beauty -= value;
        }

        return result;
    }
}
