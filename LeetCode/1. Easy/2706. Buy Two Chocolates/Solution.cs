namespace LeetCode._1._Easy._2706._Buy_Two_Chocolates;

public class Solution
{
    public int BuyChoco(int[] prices, int money)
    {
        var min1 = int.MaxValue;
        var min2 = int.MaxValue;

        foreach (var price in prices)
        {
            if (price < min1)
            {
                min2 = min1;
                min1 = price;
            }
            else if (price < min2) min2 = price;
        }

        return min1 + min2 > money ? money : money - min1 - min2;
    }
}
