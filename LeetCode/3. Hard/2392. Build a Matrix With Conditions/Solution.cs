using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._2392._Build_a_Matrix_With_Conditions;

public class Solution
{
    public int[][] BuildMatrix(int k, int[][] rowConditions, int[][] colConditions)
    {
        var rows = SolveConditions(rowConditions, k);
        var cols = SolveConditions(colConditions, k);

        if (rows.Length == 0 || cols.Length == 0)
            return Array.Empty<int[]>();

        var result = new int[k][];
        for (var i = 0; i < k; i++)
        {
            result[i] = new int[k];
            for (var j = 0; j < k; j++)
                if (cols[j] == rows[i])
                    result[i][j] = cols[j];
        }

        return result;
    }

    int[] SolveConditions(int[][] conditions, int k)
    {
        var greaterNums = Enumerable.Range(1, k).ToDictionary(x => x, _ => new HashSet<int>());
        foreach (var group in conditions.GroupBy(x => x[0], x => x[1]))
            greaterNums[group.Key] = group.ToHashSet();
        var reverseGreaterNums = conditions.GroupBy(x => x[1], x => x[0]).ToDictionary(x => x.Key, x => x.ToHashSet());

        var result = new int[k];

        for (var i = k - 1; i >= 0; i--)
        {
            var isFit = false;
            for (var v = 1; v <= k; v++)
                if (greaterNums.ContainsKey(v) && greaterNums[v].Count == 0)
                {
                    greaterNums.Remove(v);
                    if (reverseGreaterNums.TryGetValue(v, out var toRemoveKeys))
                        foreach (var key in toRemoveKeys)
                            greaterNums[key].Remove(v);

                    result[i] = v;
                    isFit = true;
                    break;
                }

            if (!isFit)
                return Array.Empty<int>();
        }

        return result;
    }
}