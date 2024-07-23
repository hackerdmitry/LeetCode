using System.Linq;

namespace LeetCode._1._Easy._1636._Sort_Array_by_Increasing_Frequency;

public class Solution
{
    public int[] FrequencySort(int[] nums)
    {
        return nums
            .GroupBy(x => x)
            .OrderBy(x => x.Count())
            .ThenByDescending(x => x.Key)
            .SelectMany(x => x.Select(y => y))
            .ToArray();
    }
}