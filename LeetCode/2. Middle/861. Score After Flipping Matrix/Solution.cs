using System;
using System.Linq;

namespace LeetCode._2._Middle._861._Score_After_Flipping_Matrix;

public class Solution
{
    public int MatrixScore(int[][] grid)
    {
        while (true)
        {
            var avdY = new int[grid.Length];
            var avdX = new int[grid[0].Length];

            for (var y = 0; y < grid.Length; y++)
                for (int x = grid[0].Length - 1, b = 1; x >= 0; x--, b <<= 1)
                    if (grid[y][x] == 1)
                    {
                        avdX[x] -= b;
                        avdY[y] -= b;
                    }
                    else
                    {
                        avdX[x] += b;
                        avdY[y] += b;
                    }

            var (maxX, maxIndexX) = avdX.Select((x, i) => (x, i)).MaxBy(x => x.x);
            var (maxY, maxIndexY) = avdY.Select((x, i) => (x, i)).MaxBy(x => x.x);

            if (maxX <= 0 && maxY <= 0)
                return CountScore(grid);

            if (maxX > maxY)
                SwapHorizontal(grid, maxIndexX);
            else
                SwapVertical(grid, maxIndexY);
        }
    }

    private int CountScore(int[][] grid)
    {
        var result = 0;
        for (var y = 0; y < grid.Length; y++)
        {
            var sum = 0;
            for (var x = 0; x < grid[0].Length; x++)
                sum = (sum << 1) + grid[y][x];
            result += sum;
        }

        return result;
    }

    private void SwapHorizontal(int[][] grid, int x)
    {
        for (var y = 0; y < grid.Length; y++)
            grid[y][x] = Math.Abs(grid[y][x] - 1);
    }

    private void SwapVertical(int[][] grid, int y)
    {
        for (var x = 0; x < grid[0].Length; x++)
            grid[y][x] = Math.Abs(grid[y][x] - 1);
    }
}