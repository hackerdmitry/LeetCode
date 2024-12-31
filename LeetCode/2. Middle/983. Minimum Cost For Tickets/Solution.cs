using System;
using System.Linq;

namespace LeetCode._2._Middle._983._Minimum_Cost_For_Tickets;

public class Solution
{
    private const int countDays = 365;

    public int MincostTickets(int[] days, int[] costs)
    {
        var minCosts = new int[countDays];

        var wishTravelDays = new bool[countDays];
        foreach (var day in days)
            wishTravelDays[day - 1] = true;

        if (wishTravelDays[0])
            minCosts[0] = costs[0];

        var minPrice = costs.Min();

        for (var i = 1; i < countDays; i++)
        {
            minCosts[i] = !wishTravelDays[i]
                ? minCosts[i - 1]
                : minCosts[i - 1] + minPrice;

            if (i == 6)
                minCosts[i] = Math.Min(minCosts[i], costs[1]);
            if (i >= 7)
                minCosts[i] = Math.Min(minCosts[i], minCosts[i - 7] + costs[1]);

            if (i == 29)
                minCosts[i] = Math.Min(minCosts[i], costs[2]);
            if (i >= 30)
                minCosts[i] = Math.Min(minCosts[i], minCosts[i - 30] + costs[2]);
        }

        return minCosts[^1];
    }
}
