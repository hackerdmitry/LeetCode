using System.Linq;

namespace LeetCode._2._Middle._3016._Minimum_Number_of_Pushes_to_Type_Word_II;

public class Solution
{
    public int MinimumPushes(string word)
    {
        return word
            .GroupBy(x => x)
            .Select(x => x.Count())
            .OrderByDescending(x => x)
            .Select((x, i) => x * (i / 8 + 1))
            .Sum();
    }
}
