using System;

namespace LeetCode._2._Middle._72._Edit_Distance;

public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        var m = word1.Length;
        var n = word2.Length;

        if (m == 0 || n == 0)
            return Math.Max(m, n);

        var dp = new int[m, n];
        if (word1[0] == word2[0])
        {
            for (var y = 1; y < m; y++)
                dp[y, 0] = y;
            for (var x = 1; x < n; x++)
                dp[0, x] = x;
        }
        else
        {
            dp[0, 0] = 1;
            var isEqual = false;
            for (var y = 1; y < m; y++)
                if (!isEqual && word1[y] == word2[0])
                {
                    dp[y, 0] = dp[y - 1, 0];
                    isEqual = true;
                }
                else
                    dp[y, 0] = dp[y - 1, 0] + 1;
            isEqual = false;
            for (var x = 1; x < n; x++)
                if (!isEqual && word1[0] == word2[x])
                {
                    dp[0, x] = dp[0, x - 1];
                    isEqual = true;
                }
                else
                    dp[0, x] = dp[0, x - 1] + 1;
        }

        for (var y = 1; y < m; y++)
            for (var x = 1; x < n; x++)
                if (word1[y] == word2[x])
                    dp[y, x] = dp[y - 1, x - 1];
                else
                    dp[y, x] = GetMinPrev(y, x, dp) + 1;

        return dp[m - 1, n - 1];
    }

    private int GetMinPrev(int y, int x, int[,] dp)
    {
        if (y == 0 && x == 0)
            return 0;

        var prevXY = y > 0 && x > 0 ? dp[y - 1, x - 1] : int.MaxValue;
        var prevX = x > 0 ? dp[y, x - 1] : int.MaxValue;
        var prevY = y > 0 ? dp[y - 1, x] : int.MaxValue;

        return Math.Min(prevXY, Math.Min(prevX, prevY));
    }
}