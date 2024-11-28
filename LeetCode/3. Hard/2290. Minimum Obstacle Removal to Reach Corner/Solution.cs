using System.Collections.Generic;

namespace LeetCode._3._Hard._2290._Minimum_Obstacle_Removal_to_Reach_Corner;

public class Solution
{
    public int MinimumObstacles(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var costs = new int[m][];
        for (var i = 0; i < m; i++)
        {
            costs[i] = new int[n];
            for (var j = 0; j < n; j++)
                costs[i][j] = int.MaxValue;
        }

        Dijkstra(grid, costs);

        return costs[m - 1][n - 1];
    }

    private static void Dijkstra(int[][] grid, int[][] costs)
    {
        var queue = new PriorityQueue<(int Y, int X, int Cost), int>();
        queue.Enqueue((0, 0, grid[0][0]), 0);

        var directions = new[]
        {
            (-1, 0),
            (0, 1),
            (1, 0),
            (0, -1),
        };

        while (queue.Count > 0)
        {
            var (y, x, cost) = queue.Dequeue();
            if (costs[y][x] <= cost)
                continue;
            costs[y][x] = cost;

            foreach (var (dy, dx) in directions)
            {
                var nextY = y + dy;
                var nextX = x + dx;
                if (IsInRangeMatrix(nextY, nextX, grid))
                {
                    var nextCost = cost + grid[nextY][nextX];
                    if (costs[nextY][nextX] > cost + grid[nextY][nextX])
                        queue.Enqueue((nextY, nextX, nextCost), nextCost);
                }
            }
        }
    }

    private static bool IsInRangeMatrix(int y, int x, int[][] matrix) =>
        y >= 0 && y < matrix.Length &&
        x >= 0 && x < matrix[0].Length;
}