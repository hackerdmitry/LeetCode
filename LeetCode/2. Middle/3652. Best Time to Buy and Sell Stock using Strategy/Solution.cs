using System;
using System.Linq;

namespace LeetCode._2._Middle._3652._Best_Time_to_Buy_and_Sell_Stock_using_Strategy;

public class Solution
{
    public long MaxProfit(int[] prices, int[] strategy, int k)
    {
        var defaultProfit = Enumerable.Range(0, prices.Length).Sum(i => (long) prices[i] * strategy[i]);
        var maxProfit = defaultProfit;

        var currentProfit = defaultProfit;
        var startK = 0;
        var middleK = k / 2;
        var endK = k;
        for (var i = startK; i < middleK; i++)
            currentProfit -= prices[i] * strategy[i];
        for (var i = middleK; i < endK; i++)
            currentProfit += prices[i] * (1 - strategy[i]);
        maxProfit = Math.Max(maxProfit, currentProfit);

        for (var i = k; i < prices.Length; i++, startK++, middleK++, endK++)
        {
            currentProfit += prices[startK] * strategy[startK];
            currentProfit -= prices[middleK];
            currentProfit += prices[endK] * (1 - strategy[endK]);
            maxProfit = Math.Max(maxProfit, currentProfit);
        }

        return maxProfit;
    }
}
