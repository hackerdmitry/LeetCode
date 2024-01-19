using System;
using System.Linq;

namespace LeetCode._2._Middle._931._Minimum_Falling_Path_Sum;

public class Solution
{
    public int MinFallingPathSum(int[][] matrix)
    {
        var dp = new int[matrix[0].Length];
        for (int i = 0; i < dp.Length; i++)
            dp[i] = matrix[0][i];
        var helpDP = new int[dp.Length];
        for (int j = 1; j < matrix.Length; j++)
        {
            for (int i = 0; i < dp.Length; i++)
                helpDP[i] = dp[i];

            for (int i = 0; i < dp.Length; i++)
                dp[i] = matrix[j][i] +
                        (i == 0
                            ? Math.Min(helpDP[0], helpDP[1])
                            : i == dp.Length - 1
                                ? Math.Min(helpDP[^2], helpDP[^1])
                                : Math.Min(helpDP[i - 1], Math.Min(helpDP[i], helpDP[i + 1])));
        }

        return dp.Min();
    }
}