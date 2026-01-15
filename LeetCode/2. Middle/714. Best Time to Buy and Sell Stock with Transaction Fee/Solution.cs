using System;

namespace LeetCode._2._Middle._714._Best_Time_to_Buy_and_Sell_Stock_with_Transaction_Fee;

public class Solution
{
    public int MaxProfit(int[] prices, int fee)
    {
        var buy = new int[prices.Length];
        var sell = new int[prices.Length];
        buy[0] = -prices[0];

        for (var i = 1; i < prices.Length; i++)
        {
            buy[i] = Math.Max(buy[i - 1], sell[i - 1] - prices[i]);
            sell[i] = Math.Max(sell[i - 1], buy[i - 1] + prices[i] - fee);
        }

        return sell[^1];
    }
}