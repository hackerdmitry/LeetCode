namespace LeetCode._2._Middle._122._Best_Time_to_Buy_and_Sell_Stock_II;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;

        for (var i = 1; i < prices.Length; i++)
            if (prices[i] > prices[i - 1])
                maxProfit += prices[i] - prices[i - 1];
        return maxProfit;
    }
}
