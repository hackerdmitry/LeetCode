using System;

namespace LeetCode._2._Middle._2017._Grid_Game;

public class Solution
{
    public long GridGame(int[][] grid)
    {
        var n = grid[0].Length;

        var up = 0L;
        var down = 0L;

        for (var i = 1; i < n; i++)
            up += grid[0][i];

        var result = up;

        for (var i = 1; i < n; i++)
        {
            up -= grid[0][i];
            down += grid[1][i - 1];
            result = Math.Min(result, Math.Max(up, down));
        }

        return result;
    }
}
