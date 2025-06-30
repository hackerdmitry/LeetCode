using System;
using System.Linq;

namespace LeetCode._1._Easy._594._Longest_Harmonious_Subsequence;

public class Solution
{
    public int FindLHS(int[] nums)
    {
        var prevValue = -1;
        var prevCount = -1;
        var maxHarmoniusArrayLength = 0;

        foreach (var grouping in nums.GroupBy(x => x).OrderBy(x => x.Key))
        {
            var (value, count) = (grouping.Key, grouping.Count());
            if (prevCount != -1 && value - 1 == prevValue)
                maxHarmoniusArrayLength = Math.Max(maxHarmoniusArrayLength, count + prevCount);
            prevValue = value;
            prevCount = count;
        }

        return maxHarmoniusArrayLength;
    }
}
