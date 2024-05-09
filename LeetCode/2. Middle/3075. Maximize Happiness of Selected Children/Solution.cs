using System;

namespace LeetCode._2._Middle._3075._Maximize_Happiness_of_Selected_Children;

public class Solution
{
    public long MaximumHappinessSum(int[] happiness, int k)
    {
        Array.Sort(happiness);
        var result = 0L;
        for (var i = 0; i < happiness.Length && i < k; i++)
            result += Math.Max(happiness[happiness.Length - 1 - i] - i, 0);
        return result;
    }
}