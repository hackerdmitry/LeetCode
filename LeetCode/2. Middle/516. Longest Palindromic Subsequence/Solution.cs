using System;

namespace LeetCode._2._Middle._516._Longest_Palindromic_Subsequence;

public class Solution
{
    public int LongestPalindromeSubseq(string s)
    {
        var dp = new int[s.Length][];
        for (var i = 0; i < s.Length; i++)
        {
            dp[i] = new int[s.Length - i];
            dp[i][0] = 1;
        }

        var result = 1;
        for (var i = 1; i < s.Length; i++)
        {
            for (var j = 0; j < s.Length - i; j++)
            {
                dp[j][i] = s[j] == s[j + i] ? 2 : 0;

                var max = 0;
                for (var k = 0; k < i - 1; k++)
                    if (dp[j + 1][k] > max)
                        max = dp[j + 1][k];

                dp[j][i] += max;
                dp[j][i] = Math.Max(dp[j][i], Math.Max(dp[j + 1][i - 1], dp[j][i - 1]));

                if (dp[j][i] > result)
                    result = dp[j][i];
            }
        }

        return result;
    }
}