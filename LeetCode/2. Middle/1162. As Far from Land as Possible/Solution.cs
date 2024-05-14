using System.Collections.Generic;

namespace LeetCode._2._Middle._1162._As_Far_from_Land_as_Possible;

public class Solution
{
    private static readonly (int y, int x)[] moves = {(-1, 0), (1, 0), (0, -1), (0, 1)};

    public int MaxDistance(int[][] grid)
    {
        var height = grid.Length;
        var width = grid[0].Length;

        var queue = new Queue<(int y, int x)>();
        for (var y = 0; y < height; y++)
            for (var x = 0; x < width; x++)
                if (grid[y][x] == 1)
                    queue.Enqueue((y, x));

        var furthest = -1;

        while (queue.Count > 0)
        {
            var point = queue.Dequeue();
            var newCost = grid[point.y][point.x] + 1;

            foreach (var move in moves)
            {
                var ny = point.y + move.y;
                var nx = point.x + move.x;
                if (ny >= 0 && ny < height && nx >= 0 && nx < width && grid[ny][nx] == 0)
                {
                    grid[ny][nx] = newCost;
                    queue.Enqueue((ny, nx));

                    if (furthest < newCost - 1)
                        furthest = newCost - 1;
                }
            }
        }

        return furthest;
    }
}