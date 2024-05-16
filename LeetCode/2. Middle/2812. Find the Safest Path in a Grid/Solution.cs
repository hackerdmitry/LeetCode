using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._2812._Find_the_Safest_Path_in_a_Grid;

public class Solution
{
    private static readonly (int y, int x)[] moves = {(0, -1), (0, 1), (-1, 0), (1, 0)};

    public int MaximumSafenessFactor(IList<IList<int>> grid)
    {
        var queue = new Queue<(int y, int x)>();

        var height = grid.Count;
        var width = grid[0].Count;

        for (var y = 0; y < height; y++)
            for (var x = 0; x < width; x++)
                if (grid[y][x] == 1)
                    queue.Enqueue((y, x));

        while (queue.Count > 0)
        {
            var point = queue.Dequeue();
            var nextCost = grid[point.y][point.x] + 1;

            foreach (var (my, mx) in moves)
            {
                var ny = point.y + my;
                var nx = point.x + mx;

                if (ny >= 0 && nx >= 0 && ny < height && nx < width && grid[ny][nx] == 0)
                {
                    grid[ny][nx] = nextCost;
                    queue.Enqueue((ny, nx));
                }
            }
        }

        var priorityQueue = new PriorityQueue<(int y, int x, int cost), int>();
        priorityQueue.Enqueue((0, 0, grid[0][0]), -grid[0][0]);
        grid[0][0] = -1;
        while (priorityQueue.Count > 0)
        {
            var point = priorityQueue.Dequeue();
            if (point.y == height - 1 && point.x == width - 1)
                return point.cost - 1;

            foreach (var (my, mx) in moves)
            {
                var ny = point.y + my;
                var nx = point.x + mx;

                if (ny >= 0 && nx >= 0 && ny < height && nx < width && grid[ny][nx] != -1)
                {
                    var cost = Math.Min(grid[ny][nx], point.cost);
                    grid[ny][nx] = -1;
                    priorityQueue.Enqueue((ny, nx, cost), -cost);
                }
            }
        }

        return -1;
    }
}