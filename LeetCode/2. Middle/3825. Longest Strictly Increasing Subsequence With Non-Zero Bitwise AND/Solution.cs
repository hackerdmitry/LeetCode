using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3825._Longest_Strictly_Increasing_Subsequence_With_Non_Zero_Bitwise_AND;

public class Solution
{
    public int LongestSubsequence(int[] nums)
    {
        var dp = new List<int>[30];
        for (var i = 0; i < dp.Length; i++)
            dp[i] = new List<int>();

        foreach (var num in nums)
            FillDP(dp, num);
        return dp.Max(x => x.Count);
    }

    private void FillDP(List<int>[] dp, int num)
    {
        var initNum = num;
        for (var i = 0; num > 0; i++, num >>= 1)
            if ((num & 1) == 1)
                CountTails(dp[i], initNum);
    }

    private void CountTails(List<int> tails, int num)
    {
        if (tails.Count == 0 || tails[^1] < num)
            tails.Add(num);
        else
        {
            var index = BinarySearchMin(0, tails.Count - 1, i => tails[i] >= num);
            tails[index] = num;
        }
    }

    private int BinarySearchMin(int left, int right, Func<int, bool> canBeRight)
    {
        while (left < right)
        {
            var mid = (left + right) / 2;
            var isRight = canBeRight(mid);
            if (isRight)
                right = mid;
            else if (left == mid)
                left++;
            else
                left = mid;
        }

        return left;
    }
}