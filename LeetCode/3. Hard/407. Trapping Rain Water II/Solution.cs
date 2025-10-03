using System;
using System.Collections.Generic;

namespace LeetCode._3._Hard._407._Trapping_Rain_Water_II;

public class Solution
{
    private const int maxRainHeight = 20_000;
    private static readonly int[] positions = {0, -1, 0, 1, 0};

    public int TrapRainWater(int[][] heightMap)
    {
        var height = heightMap.Length;
        var width = heightMap[0].Length;
        var rainHeightMap = CreateRainHeightMap(heightMap, height, width);
        MinimizeRainHeightMap(rainHeightMap, height, width);
        return CountTrappedWater(rainHeightMap, height, width);
    }

    private static int CountTrappedWater(RainHeightCell[][] rainHeightMap, int height, int width)
    {
        var result = 0;
        for (var y = 0; y < height; y++)
            for (var x = 0; x < width; x++)
                result += rainHeightMap[y][x].RainHeight - rainHeightMap[y][x].Height;
        return result;
    }

    private static void MinimizeRainHeightMap(RainHeightCell[][] rainHeightMap, int height, int width)
    {
        var queue = new PriorityQueue<RainHeightCell, int>();

        for (var y = 1; y < height - 1; y++)
        {
            queue.Enqueue(rainHeightMap[y][0], rainHeightMap[y][0].Height);
            queue.Enqueue(rainHeightMap[y][^1], rainHeightMap[y][^1].Height);
        }

        for (var x = 1; x < width - 1; x++)
        {
            queue.Enqueue(rainHeightMap[0][x], rainHeightMap[0][x].Height);
            queue.Enqueue(rainHeightMap[^1][x], rainHeightMap[^1][x].Height);
        }

        while (queue.Count > 0)
        {
            var cell = queue.Dequeue();
            cell.Visited = true;
            for (var i = 0; i < 4; i++)
            {
                var y = cell.Y + positions[i];
                var x = cell.X + positions[i + 1];
                if (y >= 0 && y < height && x >= 0 && x < width)
                {
                    var neighbour = rainHeightMap[y][x];
                    if (!neighbour.Visited && !neighbour.OnBoundary)
                    {
                        neighbour.RainHeight = Math.Max(neighbour.Height, cell.RainHeight);
                        queue.Enqueue(neighbour, neighbour.RainHeight);
                    }
                }
            }
        }
    }

    private static RainHeightCell[][] CreateRainHeightMap(int[][] heightMap, int height, int width)
    {
        var rainHeightMap = new RainHeightCell[height][];
        for (var y = 0; y < height; y++)
        {
            rainHeightMap[y] = new RainHeightCell[width];
            for (var x = 0; x < width; x++)
            {
                var onBoundary = y == 0 || y == height - 1 || x == 0 || x == width - 1;
                rainHeightMap[y][x] = new RainHeightCell
                {
                    RainHeight = onBoundary ? heightMap[y][x] : maxRainHeight,
                    Height = heightMap[y][x],
                    OnBoundary = onBoundary,
                    Y = y,
                    X = x,
                };
            }
        }

        return rainHeightMap;
    }

    private class RainHeightCell
    {
        public int Height { get; set; }
        public int RainHeight { get; set; }
        public bool Visited { get; set; }
        public bool OnBoundary { get; set; }
        public int Y { get; set; }
        public int X { get; set; }
    }
}