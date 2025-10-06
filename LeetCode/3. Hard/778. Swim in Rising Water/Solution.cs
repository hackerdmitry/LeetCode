using System;
using System.Collections.Generic;

namespace LeetCode._3._Hard._778._Swim_in_Rising_Water;

public class Solution
{
    private readonly int[] positions = {0, -1, 0, 1, 0};

    public int SwimInWater(int[][] grid)
    {
        var height = grid.Length;
        var width = grid[0].Length;
        if (height == 1 && width == 1)
            return grid[0][0];

        var queue = new PriorityQueue<(int y, int x, int time), int>();
        var visited = new HashSet<int>(width * height);

        var startTime = grid[0][0];
        queue.Enqueue((0, 0, startTime), startTime);
        visited.Add(startTime);

        while (queue.Count > 0)
        {
            var (y, x, time) = queue.Dequeue();
            for (var i = 0; i < 4; i++)
            {
                var ny = y + positions[i];
                var nx = x + positions[i + 1];
                if (ny >= 0 && nx >= 0 && ny < height && nx < width && visited.Add(grid[ny][nx]))
                {
                    var nTime = Math.Max(time, grid[ny][nx]);
                    if (ny == height - 1 && nx == width - 1)
                        return nTime;
                    queue.Enqueue((ny, nx, nTime), nTime);
                }
            }
        }

        throw new NotImplementedException();
    }
}