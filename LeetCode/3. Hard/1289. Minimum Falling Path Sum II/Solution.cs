using System.Linq;

namespace LeetCode._3._Hard._1289._Minimum_Falling_Path_Sum_II;

public class Solution
{
    public int MinFallingPathSum(int[][] grid)
    {
        var n = grid.Length;
        if (n == 1)
            return grid[0][0];

        for (var i = 1; i < n; i++)
        {
            var first = int.MaxValue;
            var firstIndex = -1;
            var second = int.MaxValue;

            for (var j = 0; j < n; j++)
                if (grid[i - 1][j] < first)
                {
                    second = first;
                    first = grid[i - 1][j];
                    firstIndex = j;
                }
                else if (grid[i - 1][j] < second)
                    second = grid[i - 1][j];

            for (var j = 0; j < n; j++)
                grid[i][j] += j != firstIndex ? first : second;
        }

        return grid[n - 1].Min();
    }
}