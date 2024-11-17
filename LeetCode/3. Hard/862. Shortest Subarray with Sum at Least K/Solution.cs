using System;
using System.Collections.Generic;

namespace LeetCode._3._Hard._862._Shortest_Subarray_with_Sum_at_Least_K;

public class Solution
{
    public int ShortestSubarray(int[] nums, int k)
    {
        var priorityQueue = new PriorityQueue<(long Sum, int Index), long>();
        var minLength = int.MaxValue;

        var cumulativeSum = 0L;
        for (var i = 0; i < nums.Length; i++)
        {
            cumulativeSum += nums[i];
            if (cumulativeSum >= k)
                minLength = Math.Min(minLength, i + 1);
            while (TryUpdateMinLength(priorityQueue, k, cumulativeSum, i, ref minLength))
                priorityQueue.Dequeue();
            priorityQueue.Enqueue((cumulativeSum, i), cumulativeSum);
        }

        return minLength == int.MaxValue
            ? -1
            : minLength;
    }

    private bool TryUpdateMinLength(PriorityQueue<(long Sum, int Index), long> priorityQueue, int k, long cumulativeSum, int currentIndex, ref int minLength)
    {
        if (priorityQueue.Count != 0)
        {
            var (minSum, index) = priorityQueue.Peek();
            if (cumulativeSum - minSum >= k)
            {
                minLength = Math.Min(minLength, currentIndex - index);
                return true;
            }
        }

        return false;
    }
}