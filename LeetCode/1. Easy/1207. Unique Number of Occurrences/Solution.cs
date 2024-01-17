using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._1207._Unique_Number_of_Occurrences;

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var dict = new Dictionary<int, int>();
        foreach (var i in arr)
        {
            if (!dict.ContainsKey(i))
                dict[i] = 1;
            else
                dict[i]++;
        }

        var hash = new HashSet<int>();
        foreach (var (_, value) in dict)
            if (!hash.Add(value))
                return false;

        return true;
    }
}
