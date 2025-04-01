using System;

namespace LeetCode._2._Middle._2140._Solving_Questions_With_Brainpower;

public class Solution
{
    public long MostPoints(int[][] questions)
    {
        var n = questions.Length;
        var dp = new long[n];
        var result = 0L;
        for (var i = 0; i < n; i++)
        {
            if (i > 0)
                dp[i] = Math.Max(dp[i - 1], dp[i]);

            var nextIndex = i + questions[i][1] + 1;
            if (nextIndex < n)
                dp[nextIndex] = Math.Max(dp[nextIndex], dp[i] + questions[i][0]);
            else
                result = Math.Max(result, dp[i] + questions[i][0]);

        }

        return result;
    }
}