using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._1488._Avoid_Flood_in_The_City;

public class Solution
{
    public int[] AvoidFlood(int[] rains)
    {
        var floodedLakes = new HashSet<int>();
        var needToDryLake = new PriorityQueue<int, int>();
        var nextRain = new int[rains.Length];
        var prevRain = new Dictionary<int, int>();

        for (var i = 0; i < rains.Length; i++)
            if (rains[i] > 0)
            {
                prevRain.TryGetValue(rains[i], out var prevIndex);
                nextRain[prevIndex] = i;
                prevRain[rains[i]] = i;
            }

        for (var i = 0; i < rains.Length; i++)
            if (rains[i] > 0)
            {
                if (!floodedLakes.Add(rains[i]))
                    return Array.Empty<int>();
                if (nextRain[i] > 0)
                    needToDryLake.Enqueue(rains[i], nextRain[i]);
                nextRain[i] = -1;
            }
            else if (needToDryLake.Count > 0)
            {
                var lake = needToDryLake.Dequeue();
                floodedLakes.Remove(lake);
                nextRain[i] = lake;
            }
            else
                nextRain[i] = 1;

        return nextRain;
    }
}