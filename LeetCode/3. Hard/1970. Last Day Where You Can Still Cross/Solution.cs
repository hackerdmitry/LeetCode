using System;
using System.Collections.Generic;

namespace LeetCode._3._Hard._1970._Last_Day_Where_You_Can_Still_Cross;

public class Solution
{
    private readonly int[] directions = {0, -1, 0, 1, 0};
    private readonly Queue<(int y, int x)> queue = new();
    private readonly HashSet<(int y, int x)> visited = new();

    public int LatestDayToCross(int row, int col, int[][] cells)
    {
        var map = new Map(row, col, cells);
        return BinarySearchMax(0, cells.Length, day => CanCrossMap(map, day)) - 1;
    }

    private int BinarySearchMax(int left, int right, Func<int, bool> canBeLeft)
    {
        while (left < right)
        {
            var mid = (left + right) / 2;
            if (left == mid)
                mid++;
            var isLeft = canBeLeft(mid);
            if (isLeft)
                left = mid;
            else if (right == mid)
                right--;
            else
                right = mid;
        }

        return left;
    }

    private bool CanCrossMap(Map map, int day)
    {
        queue.Clear();
        visited.Clear();

        FillQueueByTopLine(map, day);

        while (queue.Count > 0)
        {
            var (y, x) = queue.Dequeue();
            for (var i = 0; i < 4; i++)
            {
                var ny = y + directions[i];
                var nx = x + directions[i + 1];
                if (map.InBoundary(ny, nx) && map[ny, nx] >= day && visited.Add((ny, nx)))
                {
                    if (ny == map.Height - 1)
                        return true;

                    queue.Enqueue((ny, nx));
                }
            }
        }

        return false;
    }

    private void FillQueueByTopLine(Map map, int day)
    {
        var prevEmpty = false;
        for (var x = 0; x < map.Width; x++)
            if (map[0, x] >= day)
            {
                if (!prevEmpty)
                    queue.Enqueue((0, x));
                prevEmpty = true;
            }
            else
                prevEmpty = false;
    }

    private class Map
    {
        private readonly int[,] map;

        public int Width { get; }
        public int Height { get; }

        public Map(int row, int col, int[][] cells)
        {
            Height = row;
            Width = col;

            map = new int[row, col];
            for (var i = 0; i < cells.Length; i++)
            {
                var cell = cells[i];
                map[cell[0] - 1, cell[1] - 1] = i + 1;
            }
        }

        public int this[int row, int col] => map[row, col];

        public bool InBoundary(int y, int x) => y >= 0 && y < Height && x >= 0 && x < Width;
    }
}
