using System;

namespace LeetCode._2._Middle._1561._Maximum_Number_of_Coins_You_Can_Get;

public class Solution
{
    public int MaxCoins(int[] piles)
    {
        Array.Sort(piles);
        var sum = 0;
        for (int i = piles.Length - 2, c = 0; c < piles.Length / 3; i -= 2, c++)
            sum += piles[i];

        return sum;
    }
}
