using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1481._Least_Number_of_Unique_Integers_after_K_Removals;

public class Solution
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        var dict = new Dictionary<int, int>();
        foreach (var a in arr)
            if (dict.ContainsKey(a))
                dict[a]++;
            else
                dict[a] = 1;

        var result = dict.Count;
        foreach (var (_, count) in dict.OrderBy(x => x.Value))
        {
            k -= count;
            if (k < 0)
                break;

            result--;
        }

        return result;
    }
}