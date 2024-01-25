using System;

namespace LeetCode._2._Middle._1143._Longest_Common_Subsequence;

public class Solution
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        var dp = new int[text1.Length];

        foreach (var letter2 in text2)
        {
            var isUsed = false;
            for (var i = 0; i < text1.Length; i++)
            {
                var prevDP = i == 0 ? 0 : dp[i - 1];

                var letter1 = text1[i];

                var var1 = !isUsed && letter1 == letter2
                    ? prevDP + 1
                    : prevDP;
                var var2 = dp[i];

                if (var1 > var2)
                {
                    isUsed = true;
                    dp[i] = var1;
                }
                else
                {
                    isUsed = false;
                    dp[i] = var2;
                }
            }
        }

        return dp[^1];
    }
}
