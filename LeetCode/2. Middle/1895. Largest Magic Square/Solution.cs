using System;

namespace LeetCode._2._Middle._1895._Largest_Magic_Square;

public class Solution
{
    public int LargestMagicSquare(int[][] grid)
    {
        var n = grid.Length;
        var m = grid[0].Length;

        var sums = new int[n, m][];
        for (var i = 0; i < n; i++)
            for (var j = 0; j < m; j++)
            {
                var cell = grid[i][j];
                sums[i, j] = new[] {cell, cell, cell};
            }

        var maxSize = 1;
        var maxBoundSize = Math.Min(n, m);
        for (var offset = 1; offset < maxBoundSize; offset++)
            for (var i = 0; i < n - offset; i++)
                for (var j = 0; j < m - offset; j++)
                {
                    var localSums = sums[i, j];
                    localSums[0] += grid[i + offset][j];
                    localSums[1] += grid[i][j + offset];
                    localSums[2] += grid[i + offset][j + offset];

                    if (maxSize < offset + 1 && localSums[0] == localSums[1] && localSums[1] == localSums[2] && IsMagicSquare(grid, i, j, offset + 1))
                        maxSize = offset + 1;
                }

        return maxSize;
    }

    private bool IsMagicSquare(int[][] grid, int x, int y, int size)
    {
        var targetSum = 0;
        for (var j = 0; j < size; j++)
            targetSum += grid[x][y + j];

        for (var i = 0; i < size; i++)
        {
            var rowSum = 0;
            for (var j = 0; j < size; j++)
                rowSum += grid[x + i][y + j];
            if (rowSum != targetSum)
                return false;
        }

        for (var j = 0; j < size; j++)
        {
            var colSum = 0;
            for (var i = 0; i < size; i++)
                colSum += grid[x + i][y + j];
            if (colSum != targetSum)
                return false;
        }

        var diag1Sum = 0;
        var diag2Sum = 0;
        for (var i = 0; i < size; i++)
        {
            diag1Sum += grid[x + i][y + i];
            diag2Sum += grid[x + i][y + size - 1 - i];
        }

        return diag1Sum == targetSum && diag2Sum == targetSum;
    }
}