using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._115._Distinct_Subsequences;

public class Solution
{
    public int NumDistinct(string s, string t)
    {
        var dpPrev = new LinkedList<(int Index, int Count)>();
        var dpNext = new LinkedList<(int Index, int Count)>();

        var indexes = GroupIndexes(s);
        for (var i = 0; i < t.Length; i++)
        {
            var c = t[i];
            if (i != 0)
            {
                (dpPrev, dpNext) = (dpNext, dpPrev);
                dpNext.Clear();

                var node = dpPrev.First;
                var sum = 0;
                foreach (var index in indexes[GetIndex(c)])
                {
                    while (node != null && node.Value.Index < index)
                    {
                        sum += node.Value.Count;
                        node = node.Next;
                    }

                    if (sum > 0)
                        dpNext.AddLast((index, sum));
                }
            }
            else
                foreach (var index in indexes[GetIndex(c)])
                    dpNext.AddLast((index, 1));
        }

        return dpNext.Sum(x => x.Count);
    }

    private int[][] GroupIndexes(string s)
    {
        var counts = new int[52];
        foreach (var c in s)
            counts[GetIndex(c)]++;

        var indexes = new int[52][];
        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            var index =GetIndex(c);
            if (indexes[index] == null)
            {
                indexes[index] = new int[counts[index]];
                counts[index] = 0;
            }

            indexes[index][counts[index]++] = i;
        }

        for (var i = 0; i < 26; i++)
            indexes[i] ??= Array.Empty<int>();

        return indexes;
    }

    private int GetIndex(char c)
    {
        return c switch
        {
            >= 'a' and <= 'z' => c - 'a',
            >= 'A' and <= 'Z' => c - 'A' + 26,
        };
    }
}
