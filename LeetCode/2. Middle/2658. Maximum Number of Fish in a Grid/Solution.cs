using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._2658._Maximum_Number_of_Fish_in_a_Grid;

public class Solution
{
    private static Queue<(int, int)> queue = new();
    private static readonly int[] moves = {0, -1, 0, 1, 0};

    public int FindMaxFish(int[][] grid)
    {
        var height = grid.Length;
        var width = grid[0].Length;

        var visited = new bool[height][];
        for (var y = 0; y < height; y++)
            visited[y] = new bool[width];

        var result = 0;
        for (var y = 0; y < height; y++)
            for (var x = 0; x < width; x++)
                if (grid[y][x] > 0 && !visited[y][x])
                    result = Math.Max(result, BFS(grid, visited, y, x));

        return result;
    }

    private int BFS(int[][] grid, bool[][] visited, int startY, int startX)
    {
        var height = grid.Length;
        var width = grid[0].Length;

        visited[startY][startX] = true;
        var sum = grid[startY][startX];
        queue.Enqueue((startY, startX));
        while (queue.Count > 0)
        {
            var (y, x) = queue.Dequeue();
            for (var i = 0; i < 4; i++)
            {
                var (ny, nx) = (y + moves[i], x + moves[i + 1]);
                if (ny >= 0 && ny < height && nx >= 0 && nx < width && grid[ny][nx] > 0 && !visited[ny][nx])
                {
                    visited[ny][nx] = true;
                    sum += grid[ny][nx];
                    queue.Enqueue((ny, nx));
                }
            }
        }

        return sum;
    }
}