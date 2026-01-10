using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._2352._Equal_Row_and_Column_Pairs;

public class Solution
{
    public int EqualPairs(int[][] grid)
    {
        Span<char> span = stackalloc char[grid.Length];

        var rows = new Dictionary<string, int>();
        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid.Length; j++)
                span[j] = (char)grid[i][j];
            var str = new string(span);
            if (!rows.TryAdd(str, 1))
                rows[str]++;
        }

        var cols = new Dictionary<string, int>();
        for (var j = 0; j < grid.Length; j++)
        {
            for (var i = 0; i < grid.Length; i++)
                span[i] = (char)grid[i][j];
            var str = new string(span);
            if (!cols.TryAdd(str, 1))
                cols[str]++;
        }

        var result = 0;
        foreach (var (row, countRows) in rows)
            if (cols.TryGetValue(row, out var countCols))
                result += countRows * countCols;
        return result;
    }
}