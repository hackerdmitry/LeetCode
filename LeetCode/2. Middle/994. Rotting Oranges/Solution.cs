using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._994._Rotting_Oranges;

public class Solution
{
    private static readonly int[] directions = { 0, 1, 0, -1, 0 };

    public int OrangesRotting(int[][] grid)
    {
        var freshOranges = 0;
        var queue = new Queue<(int y, int x, int minutes)>();
        var n = grid.Length;
        var m = grid[0].Length;
        for (var i = 0; i < n; i++)
            for (var j = 0; j < m; j++)
                if (grid[i][j] == 1)
                    freshOranges++;
                else if (grid[i][j] == 2)
                    queue.Enqueue((i, j, 0));

        var maxMinutes = 0;
        while (queue.Count > 0)
        {
            var (y,x,minutes) = queue.Dequeue();
            maxMinutes = Math.Max(maxMinutes, minutes);
            for (var d = 0; d < 4; d++)
            {
                var newY = y + directions[d];
                var newX = x + directions[d + 1];
                if (newY >= 0 && newY < n && newX >= 0 && newX < m && grid[newY][newX] == 1)
                {
                    freshOranges--;
                    grid[newY][newX] = 2;
                    queue.Enqueue((newY, newX, minutes + 1));
                }
            }
        }

        return freshOranges == 0 ? maxMinutes : -1;
    }
}
