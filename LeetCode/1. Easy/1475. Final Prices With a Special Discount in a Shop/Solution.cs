namespace LeetCode._1._Easy._1475._Final_Prices_With_a_Special_Discount_in_a_Shop;

public class Solution
{
    public int[] FinalPrices(int[] prices)
    {
        for (var i = 0; i < prices.Length; i++)
            for (var j = i + 1; j < prices.Length; j++)
                if (prices[j] <= prices[i])
                {
                    prices[i] -= prices[j];
                    break;
                }

        return prices;
    }
}
