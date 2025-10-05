using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._417._Pacific_Atlantic_Water_Flow;

public class Solution
{
    private readonly int[] positions = {0, -1, 0, 1, 0};

    public IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        var height = heights.Length;
        var width = heights[0].Length;
        var map = new Map(heights, height, width);
        BFS(CreatePacificOceanQueue(map), map, c => c.VisitedPacificOcean, c => c.VisitedPacificOcean = true);
        BFS(CreateAtlanticOceanQueue(map), map, c => c.VisitedAtlanticOcean, c => c.VisitedAtlanticOcean = true);
        return GetVisitedBothOceans(map);
    }

    private IList<IList<int>> GetVisitedBothOceans(Map map)
    {
        var result = new List<IList<int>>();

        for (var y = 0; y < map.Height; y++)
            for (var x = 0; x < map.Width; x++)
                if (map[y, x].VisitedPacificOcean && map[y, x].VisitedAtlanticOcean)
                    result.Add(new[] {y, x});

        return result;
    }

    private Queue<Cell> CreatePacificOceanQueue(Map map)
    {
        var queue = new Queue<Cell>();
        for (var y = 0; y < map.Height; y++)
            EnqueueAndVisit(queue, map[y, 0], c => c.VisitedPacificOcean = true);
        for (var x = 1; x < map.Width; x++)
            EnqueueAndVisit(queue, map[0, x], c => c.VisitedPacificOcean = true);
        return queue;
    }

    private Queue<Cell> CreateAtlanticOceanQueue(Map map)
    {
        var queue = new Queue<Cell>();
        for (var y = 0; y < map.Height; y++)
            EnqueueAndVisit(queue, map[y, map.Width - 1], c => c.VisitedAtlanticOcean = true);
        for (var x = 0; x < map.Width - 1; x++)
            EnqueueAndVisit(queue, map[map.Height - 1, x], c => c.VisitedAtlanticOcean = true);
        return queue;
    }

    private void EnqueueAndVisit(Queue<Cell> queue, Cell cell, Action<Cell> visit)
    {
        queue.Enqueue(cell);
        visit(cell);
    }

    private void BFS(Queue<Cell> queue, Map map, Func<Cell, bool> isVisited, Action<Cell> visit)
    {
        while (queue.Count > 0)
        {
            var cell = queue.Dequeue();
            for (var i = 0; i < 4; i++)
            {
                var ny = cell.Y + positions[i];
                var nx = cell.X + positions[i + 1];
                var neighbour = map[ny, nx];
                if (neighbour is not null && !isVisited(neighbour) && cell.Height <= neighbour.Height)
                {
                    queue.Enqueue(neighbour);
                    visit(neighbour);
                }
            }
        }
    }

    class Map
    {
        public int Width { get; }
        public int Height { get; }
        private Cell[,] Cells { get; }

        public Cell this[int y, int x] => InBoundary(y, x) ? Cells[y, x] : null;

        public Map(int[][] heights, int height, int width)
        {
            Width = width;
            Height = height;
            Cells = new Cell[height, width];
            for (var y = 0; y < height; y++)
                for (var x = 0; x < width; x++)
                    Cells[y, x] = new Cell(y, x, heights[y][x]);
        }

        private bool InBoundary(int y, int x) => y >= 0 && y < Height && x >= 0 && x < Width;
    }

    class Cell
    {
        public int Y { get; set; }
        public int X { get; set; }
        public int Height { get; set; }

        public bool VisitedPacificOcean { get; set; }
        public bool VisitedAtlanticOcean { get; set; }

        public Cell(int y, int x, int height)
        {
            Y = y;
            X = x;
            Height = height;
        }
    }
}