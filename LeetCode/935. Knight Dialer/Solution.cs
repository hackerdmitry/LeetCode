using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._935._Knight_Dialer;

public class Solution
{
    private const int module = 1_000_000_007;

    public int KnightDialer(int n)
    {
        var prev = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        var cur = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        var possibleSteps = new Dictionary<int, int[]>
        {
            [0] = new[] { 4, 6 },
            [1] = new[] { 6, 8 },
            [2] = new[] { 7, 9 },
            [3] = new[] { 4, 8 },
            [4] = new[] { 3, 9, 0 },
            [5] = Array.Empty<int>(),
            [6] = new[] { 1, 7, 0 },
            [7] = new[] { 2, 6 },
            [8] = new[] { 1, 3 },
            [9] = new[] { 2, 4 },
        };

        for (var i = 1; i < n; i++)
        {
            for (var j = 0; j < cur.Length; j++)
                cur[j] = (int)(possibleSteps[j].Sum(x => (long)prev[x]) % module);
            for (var j = 0; j < prev.Length; j++)
                prev[j] = cur[j];
        }

        return (int)(cur.Select(x => (long)x).Sum() % module);
    }
}
