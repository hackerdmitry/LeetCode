using System;

namespace LeetCode._3._Hard._85._Maximal_Rectangle;

public class Solution
{
    public int MaximalRectangle(char[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var dp = CreateMaxAvailableWidthMatrix(matrix, m, n);
        return FindMaxArea(dp, n, m);
    }

    private static int[][] CreateMaxAvailableWidthMatrix(char[][] matrix, int m, int n)
    {
        var dp = new int[m][];
        for (var i = 0; i < m; i++)
        {
            dp[i] = new int[n];
            for (var j = 0; j < n; j++)
                dp[i][j] = matrix[i][j] == '1' ? j == 0 ? 1 : dp[i][j - 1] + 1 : 0;
        }

        return dp;
    }

    private static int FindMaxArea(int[][] dp, int n, int m)
    {
        var maxArea = 0;
        for (var j = 0; j < n; j++)
            for (var i = 0; i < m; i++)
            {
                var currentWidth = dp[i][j];
                if (currentWidth > 0)
                    for (var k = i; k < m && dp[k][j] > 0; k++)
                    {
                        currentWidth = Math.Min(currentWidth, dp[k][j]);
                        maxArea = Math.Max(maxArea, currentWidth * (k - i + 1));
                    }
            }
        return maxArea;
    }
}