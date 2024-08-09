using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._840._Magic_Squares_In_Grid;

public class Solution
{
    private readonly HashSet<int> helpHashSet = new();

    public int NumMagicSquaresInside(int[][] grid)
    {
        var height = grid.Length;
        var width = grid[0].Length;

        var resultCount = 0;

        for (var y = 0; y < height; y++)
            for (var x = 0; x < width; x++)
                if (IsMagicSquare(grid, y, x))
                    resultCount++;

        return resultCount;
    }

    private bool IsMagicSquare(int[][] grid, int startY, int startX)
    {
        helpHashSet.Clear();

        var sums = new int[8];

        for (int y = 0, gridY = startY; y < 3; y++, gridY++)
        {
            for (int x = 0, gridX = startX; x < 3; x++, gridX++)
            {
                if (!InGrid(grid, gridY, gridX))
                    return false;

                var value = grid[gridY][gridX];
                helpHashSet.Add(value);
                sums[y] += value;
                sums[3 + x] += value;
                if (x == y)
                    sums[6] += value;
                if (2 - x == y)
                    sums[7] += value;
            }
        }

        return Enumerable.Range(1, 9).All(helpHashSet.Contains) &&
               sums.All(sum => sum == sums[0]);
    }

    private bool InGrid(int[][] grid, int y, int x) =>
        y >= 0 && y < grid.Length &&
        x >= 0 && x < grid[0].Length;
}