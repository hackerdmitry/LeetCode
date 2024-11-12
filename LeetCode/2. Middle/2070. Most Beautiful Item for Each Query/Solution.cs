using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2070._Most_Beautiful_Item_for_Each_Query;

public class Solution
{
    public int[] MaximumBeauty(int[][] items, int[] queries)
    {
        var bestBeauties = new Dictionary<int, int>();
        foreach (var item in items)
            bestBeauties[item[0]] = bestBeauties.ContainsKey(item[0])
                ? Math.Max(bestBeauties[item[0]], item[1])
                : item[1];

        var prices = GetPrices(bestBeauties).ToArray();

        bestBeauties[-1] = 0;

        for (var i = 0; i < queries.Length; i++)
            queries[i] = bestBeauties[FindPrice(prices, queries[i])];

        return queries;
    }

    private IEnumerable<int> GetPrices(Dictionary<int, int> bestBeauties)
    {
        var lastMaxBeauty = -1;
        foreach (var (price, beauty) in bestBeauties.OrderBy(x => x.Key))
            if (beauty > lastMaxBeauty)
            {
                lastMaxBeauty = beauty;
                yield return price;
            }
    }

    private int FindPrice(int[] prices, int maxPrice)
    {
        if (prices.Length == 0 || prices[0] > maxPrice)
            return -1;
        if (prices[^1] <= maxPrice)
            return prices[^1];

        var left = 0;
        var right = prices.Length - 1;

        while (left < right)
        {
            if (right - 1 == left)
                return prices[left];

            var middle = (left + right) / 2;
            var curPrice = prices[middle];
            if (curPrice <= maxPrice)
                left = middle;
            else
                right = middle;
        }

        return -1;
    }
}