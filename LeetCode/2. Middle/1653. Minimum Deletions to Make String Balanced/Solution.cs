using System;
using System.Linq;

namespace LeetCode._2._Middle._1653._Minimum_Deletions_to_Make_String_Balanced;

public class Solution
{
    public int MinimumDeletions(string s)
    {
        var count = s.Count(x => x == 'a');
        var minCount = count;
        foreach (var c in s)
        {
            count = c == 'a' ? count - 1 : count + 1;
            minCount = Math.Min(minCount, count);
        }

        return minCount;
    }
}
