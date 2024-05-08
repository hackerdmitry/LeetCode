using System.Linq;

namespace LeetCode._1._Easy._506._Relative_Ranks;

public class Solution
{
    public string[] FindRelativeRanks(int[] score)
    {
        return score
            .Select((x, i) => (x, i))
            .OrderByDescending(x => x.Item1)
            .Select((x, i) => ((i + 1) switch
            {
                1 => "Gold Medal",
                2 => "Silver Medal",
                3 => "Bronze Medal",
                _ => (i + 1).ToString(),
            }, x.Item2))
            .OrderBy(x => x.Item2)
            .Select(x => x.Item1)
            .ToArray();
    }
}