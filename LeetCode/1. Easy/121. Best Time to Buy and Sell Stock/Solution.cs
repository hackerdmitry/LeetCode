using System;

namespace LeetCode._1._Easy._121._Best_Time_to_Buy_and_Sell_Stock;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var minStock = prices[0];
        var maxProfit = 0;

        for (var i = 1; i < prices.Length; i++)
            if (minStock > prices[i])
                minStock = prices[i];
            else
                maxProfit = Math.Max(maxProfit, prices[i] - minStock);

        return maxProfit;
    }
}
