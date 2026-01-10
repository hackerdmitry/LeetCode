using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._712._Minimum_ASCII_Delete_Sum_for_Two_Strings;

public class Solution
{
    public int MinimumDeleteSum(string s1, string s2)
    {
        var dp = new int[s1.Length, s2.Length];

        // Угол
        var isEqual = s1[0] == s2[0];
        dp[0, 0] = isEqual ? s1[0] : 0;

        // Верхняя линия
        for (var j = 1; j < s2.Length; j++)
        {
            isEqual |= s2[j] == s1[0];
            dp[0, j] = isEqual ? s1[0] : 0;
        }

        // Боковая линия
        isEqual = s1[0] == s2[0];
        for (var i = 0; i < s1.Length; i++)
        {
            isEqual |= s1[i] == s2[0];
            dp[i, 0] = isEqual ? s2[0] : 0;
        }

        // Основное заполнение DP без заебов
        for (var i = 1; i < s1.Length; i++)
            for (var j = 1; j < s2.Length; j++)
                dp[i, j] = Math.Max((s1[i] == s2[j] ? s1[i] : 0) + dp[i - 1, j - 1], Math.Max(dp[i - 1, j], dp[i, j - 1]));

        var s1sum = s1.Sum(x => x);
        var s2sum = s2.Sum(x => x);
        return s1sum + s2sum - 2 * dp[s1.Length - 1, s2.Length - 1];
    }
}