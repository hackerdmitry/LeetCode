using System.Collections.Generic;

namespace LeetCode._2._Middle._898._Bitwise_ORs_of_Subarrays;

public class Solution
{
    public int SubarrayBitwiseORs(int[] arr)
    {
        var result = new HashSet<int>();

        var set1 = new HashSet<int>{0};
        var set2 = new HashSet<int>();
        for (var i = 0; i < arr.Length; i++)
            if (i % 2 == 0)
                Step(set1, set2, arr[i], result);
            else
                Step(set2, set1, arr[i], result);

        return result.Count;
    }

    private void Step(HashSet<int> set1, HashSet<int> set2, int num, HashSet<int> result)
    {
        set2.Add(num);
        foreach (var curr in set1)
            set2.Add(curr | num);
        result.UnionWith(set2);
        set1.Clear();
    }
}
