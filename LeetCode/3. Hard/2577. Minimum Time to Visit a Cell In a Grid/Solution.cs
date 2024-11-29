using System.Collections.Generic;

namespace LeetCode._3._Hard._2577._Minimum_Time_to_Visit_a_Cell_In_a_Grid;

public class Solution
{
    public int MinimumTime(int[][] grid)
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

        if (grid[1][0] > 1 && grid[0][1] > 1)
            return -1;

        Dijkstra(grid, costs);

        return costs[m - 1][n - 1];
    }

    private static void Dijkstra(int[][] grid, int[][] costs)
    {
        var queue = new PriorityQueue<(int Y, int X, int Cost), int>();
        queue.Enqueue((0, 0, grid[0][0]), 0);

        var directions = new[] {0,-1,0,1,0};
        while (queue.Count > 0)
        {
            var (y, x, cost) = queue.Dequeue();
            if (costs[y][x] <= cost)
                continue;
            costs[y][x] = cost;

            for (var i = 1; i < directions.Length; i++)
            {
                var nextY = y + directions[i];
                var nextX = x + directions[i - 1];
                if (IsInRangeMatrix(nextY, nextX, grid))
                {
                    var nextCost = CalculateNextCost(cost, grid[nextY][nextX]);
                    if (costs[nextY][nextX] > nextCost)
                        queue.Enqueue((nextY, nextX, nextCost), nextCost);
                }
            }
        }
    }

    private static bool IsInRangeMatrix(int y, int x, int[][] matrix) =>
        y >= 0 && y < matrix.Length &&
        x >= 0 && x < matrix[0].Length;

    private static int CalculateNextCost(int cost, int gridCell) =>
        ++cost >= gridCell
            ? cost
            : cost + 2 * Ceil(gridCell - cost, 2);

    private static int Ceil(int val1, int val2) =>
        val1 % val2 == 0
            ? val1 / val2
            : val1 / val2 + 1;
}