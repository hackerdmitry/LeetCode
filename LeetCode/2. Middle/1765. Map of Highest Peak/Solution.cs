using System.Collections.Generic;

namespace LeetCode._2._Middle._1765._Map_of_Highest_Peak;

public class Solution
{
    private readonly int[] directions = {0, -1, 0, 1, 0};

    public int[][] HighestPeak(int[][] isWater)
    {
        var height = isWater.Length;
        var width = isWater[0].Length;
        var result = new int[height][];
        var points = new Queue<(int Y, int X)>();
        for (var y = 0; y < height; y++)
        {
            result[y] = new int[width];
            for (var x = 0; x < width; x++)
                if (isWater[y][x] == 0)
                    result[y][x] = -1;
                else
                    points.Enqueue((y, x));
        }

        while (points.Count > 0)
        {
            var (y, x) = points.Dequeue();
            for (var i = 0; i < 4; i++)
            {
                var (ny, nx) = (y + directions[i], x + directions[i + 1]);
                if (ny >= 0 && ny < height && nx >= 0 && nx < width && result[ny][nx] == -1)
                {
                    result[ny][nx] = result[y][x] + 1;
                    points.Enqueue((ny, nx));
                }
            }
        }

        return result;
    }
}