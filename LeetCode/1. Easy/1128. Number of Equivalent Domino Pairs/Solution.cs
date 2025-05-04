using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._1128._Number_of_Equivalent_Domino_Pairs;

public class Solution
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        var dict = new Dictionary<(int, int), int>();
        foreach (var domino in dominoes.Select(x => (Math.Min(x[0], x[1]), Math.Max(x[0], x[1]))))
            if (!dict.TryAdd(domino, 1))
                dict[domino]++;
        return dict.Sum(x => x.Value * (x.Value - 1) / 2);
    }
}