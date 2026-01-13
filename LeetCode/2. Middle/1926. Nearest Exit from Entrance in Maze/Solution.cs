using System.Collections.Generic;

namespace LeetCode._2._Middle._1926._Nearest_Exit_from_Entrance_in_Maze;

public class Solution
{
    private static readonly int[] directions = { 0, 1, 0, -1, 0 };

    public int NearestExit(char[][] maze, int[] entrance)
    {
        var n = maze.Length;
        var m = maze[0].Length;

        var queue = new Queue<(int y, int x, int numSteps)>();
        queue.Enqueue((entrance[0], entrance[1], 0));

        maze[entrance[0]][entrance[1]] = '+';

        while (queue.Count > 0)
        {
            var (y, x, numSteps) = queue.Dequeue();
            for (var i = 0; i < 4; i++)
            {
                var newY = y + directions[i];
                var newX = x + directions[i + 1];
                if (newY >= 0 && newY < n && newX >= 0 && newX < m && maze[newY][newX] == '.')
                {
                    if (newY == 0 || newY == n - 1 || newX == 0 || newX == m - 1)
                        return numSteps + 1;

                    maze[newY][newX] = '+';
                    queue.Enqueue((newY, newX, numSteps + 1));
                }
            }
        }

        return -1;
    }
}
