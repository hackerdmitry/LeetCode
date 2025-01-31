using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._827._Making_A_Large_Island;

public class Solution
{
    private readonly Queue<(int, int)> queue = new();
    private readonly int[] dirs = {0, -1, 0, 1, 0};
    private readonly HashSet<int> neighbours = new(4);

    private int height, width;

    public int LargestIsland(int[][] grid)
    {
        height = grid.Length;
        width = grid[0].Length;

        var islands = new List<int>();
        var result = 0;
        for (var y = 0; y < height; y++)
            for (var x = 0; x < width; x++)
                if (grid[y][x] == 1)
                {
                    var islandResult = BFS(grid, y, x, islands.Count + 2);
                    result = Math.Max(result, islandResult);
                    islands.Add(islandResult);
                }

        if (islands.Count == 1 && islands[0] == height * width)
            return islands[0];

        for (var y = 0; y < height; y++)
            for (var x = 0; x < width; x++)
                if (grid[y][x] == 0)
                    result = Math.Max(result, MaxConnected(y, x, grid, islands));

        return result + 1;
    }

    private int BFS(int[][] grid, int startY, int startX, int numIsland)
    {
        queue.Enqueue((startY, startX));
        var result = 1;
        grid[startY][startX] = numIsland;

        while (queue.Count > 0)
        {
            var (y, x) = queue.Dequeue();
            for (var i = 0; i < 4; i++)
            {
                var ny = y + dirs[i + 1];
                var nx = x + dirs[i];
                if (InGrid(ny, nx) && grid[ny][nx] == 1)
                {
                    grid[ny][nx] = numIsland;
                    result++;
                    queue.Enqueue((ny, nx));
                }
            }
        }

        return result;
    }

    private int MaxConnected(int y, int x, int[][] grid, List<int> islands)
    {
        neighbours.Clear();
        neighbours.Add(GetIsland(y - 1, x, grid));
        neighbours.Add(GetIsland(y + 1, x, grid));
        neighbours.Add(GetIsland(y, x - 1, grid));
        neighbours.Add(GetIsland(y, x + 1, grid));

        return neighbours.Where(i => i >= 0).Sum(i => islands[i]);
    }

    private int GetIsland(int y, int x, int[][] grid) =>
        InGrid(y, x) && grid[y][x] > 1
            ? grid[y][x] - 2
            : -1;

    private bool InGrid(int y, int x) =>
        y >= 0 && y < height && x >= 0 && x < width;
}