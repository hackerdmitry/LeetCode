using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._2462._Total_Cost_to_Hire_K_Workers;

public class Solution
{
    public long TotalCost(int[] costs, int k, int candidates)
    {
        var leftQueue = new PriorityQueue<int, int>(candidates);
        var rightQueue = new PriorityQueue<int, int>(candidates);

        var leftIndex = 0;
        for (; leftIndex < candidates; leftIndex++)
            leftQueue.Enqueue(costs[leftIndex], costs[leftIndex]);

        candidates = Math.Min(candidates, costs.Length - leftQueue.Count);
        var rightIndex = costs.Length - 1;
        for (; rightIndex >= costs.Length - candidates; rightIndex--)
            rightQueue.Enqueue(costs[rightIndex], costs[rightIndex]);

        var totalCost = 0L;
        for (var i = 0; i < k; i++)
        {
            var left = leftQueue.Count > 0 ? leftQueue.Peek() : int.MaxValue;
            var right = rightQueue.Count > 0 ? rightQueue.Peek() : int.MaxValue;
            if (left <= right)
            {
                totalCost += leftQueue.Dequeue();
                if (leftIndex <= rightIndex)
                    leftQueue.Enqueue(costs[leftIndex], costs[leftIndex++]);
            }
            else
            {
                totalCost += rightQueue.Dequeue();
                if (leftIndex <= rightIndex)
                    rightQueue.Enqueue(costs[rightIndex], costs[rightIndex--]);
            }
        }

        return totalCost;
    }
}
