using System;

namespace LeetCode._1._Easy._2373._Largest_Local_Values_in_a_Matrix;

public class Solution
{
    public int[][] LargestLocal(int[][] grid)
    {
        var width = grid.Length;
        var height = grid[0].Length;

        var result = new int[width - 2][];

        for (var i = 1; i < width - 1; i++)
        {
            result[i - 1] = new int[height - 2];
            for (var j = 1; j < height - 1; j++)
            {
                var localMax = int.MinValue;
                for (var x = -1; x <= 1; x++)
                    for (var y = -1; y <= 1; y++)
                        localMax = Math.Max(localMax, grid[i + x][j + y]);

                result[i - 1][j - 1] = localMax;
            }
        }

        return result;
    }
}