using System;
using System.Linq;

namespace LeetCode._3._Hard._1235._Maximum_Profit_in_Job_Scheduling;

public class Solution
{
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        var length = startTime.Length;

        var bricks = Enumerable.Range(0, length)
            .Select(i => new Brick(startTime[i], endTime[i], profit[i]))
            .OrderBy(x => x.EndTime)
            .ToArray();
        var bestProfits = new BestProfit[length];

        var bestProfit = 0;
        for (var i = 0; i < length; i++)
        {
            var brick = bricks[i];
            var maxProfit = FindMaxProfit(brick.StartTime, i, bestProfits);
            bestProfits[i] = new BestProfit(brick.EndTime, Math.Max(maxProfit + brick.Profit, bestProfit));
            if (bestProfits[i].Profit > bestProfit)
                bestProfit = bestProfits[i].Profit;
        }

        return bestProfit;
    }

    private int FindMaxProfit(int startTime, int endIndex, BestProfit[] bestProfits)
    {
        var maxProfit = 0;
        var left = 0;
        var right = endIndex;

        while (left < right)
        {
            var middle = (left + right) / 2;

            if (bestProfits[middle].StartTime <= startTime &&
                bestProfits[middle].Profit > maxProfit)
                maxProfit = bestProfits[middle].Profit;

            if (bestProfits[middle].StartTime > startTime)
                right = middle;
            else if (left == middle)
                left++;
            else
                left = middle;
        }

        return maxProfit;
    }

    private record Brick(int StartTime, int EndTime, int Profit);

    private record BestProfit(int StartTime, int Profit);
}
