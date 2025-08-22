using System;

namespace LeetCode._2._Middle._3195._Find_the_Minimum_Area_to_Cover_All_Ones_I;

public class Solution
{
    public int MinimumArea(int[][] grid)
    {
        var minX = int.MaxValue;
        var minY = int.MaxValue;
        var maxX = int.MinValue;
        var maxY = int.MinValue;

        for (var y = 0; y < grid.Length; y++)
            for (var x = 0; x < grid[y].Length; x++)
                if (grid[y][x] == 1)
                {
                    minY = Math.Min(y, minY);
                    maxY = Math.Max(y, maxY);
                    minX = Math.Min(x, minX);
                    maxX = Math.Max(x, maxX);
                }

        if (minX == int.MaxValue)
            return 0;

        return (maxY - minY + 1) * (maxX - minX + 1);
    }
}
