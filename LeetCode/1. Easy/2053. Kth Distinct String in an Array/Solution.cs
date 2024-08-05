using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._2053._Kth_Distinct_String_in_an_Array;

public class Solution
{
    public string KthDistinct(string[] arr, int k)
    {
        var countStrings = arr.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        return arr.Where(x => countStrings[x] == 1).Skip(k - 1).FirstOrDefault() ?? string.Empty;
    }
}
