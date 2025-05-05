using System;

namespace LeetCode._2._Middle._790._Domino_and_Tromino_Tiling;

public class Solution
{
    /// Explanation alg:
    ///
    /// type 1: dp[i-1]
    /// |
    /// |
    ///
    /// type 2: dp[i-2]
    /// --
    /// --
    ///
    /// type 3: for j (3..n, step=2) : dp[i-j] and +2
    /// ┌-|  ->  ┌----|
    /// |-┘  ->  |----┘
    ///
    /// |-┐  ->  |----┐
    /// └-|  ->  └----|
    ///
    /// ┌--┐  ->  ┌----┐
    /// |--|  ->  |----|
    ///
    /// |--|  ->  |----|
    /// └--┘  ->  └----┘
    private const int module = 1_000_000_007;

    public int NumTilings(int n)
    {
        var dp = new int[Math.Max(4, n)];
        dp[0] = 1;
        dp[1] = 2;

        for (var i = 2; i < n; i++)
        {
            var variantsCount = 2L + dp[i - 2] + dp[i - 1];
            for (var j = 0; j < i - 2; j++)
                variantsCount += dp[j] * 2;
            dp[i] = (int) (variantsCount % module);
        }

        return dp[n - 1];
    }
}