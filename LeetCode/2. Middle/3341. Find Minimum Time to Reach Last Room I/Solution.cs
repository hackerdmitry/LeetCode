using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._3341._Find_Minimum_Time_to_Reach_Last_Room_I;

public class Solution
{
    private readonly int[] positions = {0, -1, 0, 1, 0};

    public int MinTimeToReach(int[][] moveTime)
    {
        var n = moveTime.Length;
        var m = moveTime[0].Length;

        var priorityQueue = new PriorityQueue<(int, int, int), int>();
        priorityQueue.Enqueue((0, 0, 0), 0);

        var visited = new HashSet<(int, int)>();
        visited.Add((0, 0));

        while (priorityQueue.Count > 0)
        {
            var (y, x, curTime) = priorityQueue.Dequeue();
            if (y == n - 1 && x == m - 1)
                return curTime;

            for (var i = 0; i < 4; i++)
            {
                var newX = x + positions[i];
                var newY = y + positions[i + 1];

                if (newY >= 0 && newY < n && newX >= 0 && newX < m && !visited.Contains((newY, newX)))
                {
                    var nextTime = Math.Max(moveTime[newY][newX] + 1, curTime + 1);
                    visited.Add((newY, newX));
                    priorityQueue.Enqueue((newY, newX, nextTime), nextTime);
                }
            }
        }

        return -1;
    }
}