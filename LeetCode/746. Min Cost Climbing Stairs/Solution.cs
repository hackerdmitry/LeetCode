using System;
using System.Text.RegularExpressions;

namespace LeetCode._746._Min_Cost_Climbing_Stairs
{
    public class Solution
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            var minCosts = new int[cost.Length];
            minCosts[0] = cost[0];
            minCosts[1] = cost[1];

            for (var i = 2; i < minCosts.Length; i++)
                minCosts[i] = Math.Min(minCosts[i - 1], minCosts[i - 2]) + cost[i];

            return Math.Min(minCosts[^1], minCosts[^2]);
        }
    }
}