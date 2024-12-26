using System.Collections.Generic;

namespace LeetCode._2._Middle._494._Target_Sum;

public class Solution
{
    public int FindTargetSumWays(int[] nums, int target)
    {
        var sumCounts = new Dictionary<int, int>
        {
            [nums[0]] = 1,
            [-nums[0]] = 1,
        };
        if (nums[0] == 0)
            sumCounts[0]++;
        var helpDictionary = new Dictionary<int, int>();

        for (var i = 1; i < nums.Length; i++)
        {
            helpDictionary.Clear();

            foreach (var (sum, count) in sumCounts)
            {
                AddNum(sum, nums[i], count, helpDictionary);
                AddNum(sum, -nums[i], count, helpDictionary);
            }

            (sumCounts, helpDictionary) = (helpDictionary, sumCounts);
        }

        return sumCounts.GetValueOrDefault(target, 0);
    }

    private void AddNum(int num, int addNum, int value, Dictionary<int, int> helpDictionary)
    {
        var sum = num + addNum;
        if (!helpDictionary.TryAdd(sum, value))
            helpDictionary[sum] += value;
    }
}
