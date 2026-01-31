using System;

namespace LeetCode._3._Hard._3826._Minimum_Partition_Score;

public class Solution
{
    public long MinPartitionScore(int[] nums, int k)
    {
        var prefixSum = CreatePrefixSum(nums);

        var dp = new long[k][];
        for (var i = 0; i < k; i++)
            dp[i] = new long[nums.Length - i];

        for (var i = 0; i < nums.Length; i++)
            dp[0][i] = CalculateScore(prefixSum[i]);
        for (var i = 1; i < k; i++)
            dp[i][0] = dp[i - 1][0] + CalculateScore(nums[i]);

        for (var i = 1; i < k; i++)
            for (var j = 1; j < nums.Length - i; j++)
            {
                var minScore = long.MaxValue;
                for (var t = 0; t <= j; t++)
                    minScore = Math.Min(minScore, dp[i - 1][t] + CalculateScore(prefixSum[i + j] - prefixSum[i + t - 1]));
                dp[i][j] = minScore;
            }

        return dp[^1][^1];
    }

    private long CalculateScore(long sum)
    {
        return sum * (sum + 1) / 2;
    }

    private int[] CreatePrefixSum(int[] nums)
    {
        var totalSum = 0;
        var prefixSum = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            totalSum += nums[i];
            prefixSum[i] = totalSum;
        }

        return prefixSum;
    }
}