using System.Linq;

namespace LeetCode._2._Middle._2598._Smallest_Missing_Non_negative_Integer_After_Operations;

public class Solution
{
    public int FindSmallestInteger(int[] nums, int value)
    {
        var mods = nums
            .Select(x => x % value)
            .GroupBy(x => x < 0 ? x + value : x)
            .ToDictionary(x => x.Key, x => x.Count());
        for (var i = 0; ; i++)
        {
            var mod = i % value;
            if (!mods.ContainsKey(mod) || mods[mod] == 0)
                return i;
            mods[mod]--;
        }
    }
}
