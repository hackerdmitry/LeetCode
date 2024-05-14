using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._1219._Path_with_Maximum_Gold;

public class Solution
{
    private static readonly (int, int)[] moves = {(-1, 0), (1, 0), (0, -1), (0, 1)};

    public int GetMaximumGold(int[][] grid)
    {
        var height = grid.Length;
        var width = grid[0].Length;

        var maxGold = 0;

        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                if (grid[y][x] == 0)
                    continue;

                var priorityQueue = new SinglePriorityQueue<Step>();
                priorityQueue.Enqueue(new Step(y, x, 1, grid[y][x]));
                maxGold = Math.Max(maxGold, grid[y][x]);

                while (priorityQueue.Count > 0)
                {
                    var step = priorityQueue.Dequeue();

                    foreach (var move in moves)
                    {
                        var nextPoint = step.GetNextPoint(move);
                        if (nextPoint.Y >= 0 && nextPoint.X >= 0 && nextPoint.Y < height && nextPoint.X < width && grid[nextPoint.Y][nextPoint.X] != 0)
                        {
                            var newGold = step.Gold + grid[nextPoint.Y][nextPoint.X];
                            if (step.NotVisit(nextPoint))
                            {
                                priorityQueue.Enqueue(new Step(nextPoint.Y, nextPoint.X, step.Count + 1, newGold, step));
                                maxGold = Math.Max(maxGold, newGold);
                            }
                        }
                    }
                }
            }
        }

        return maxGold;
    }

    class SinglePriorityQueue<TValue> : PriorityQueue<TValue, TValue>
    {
        public void Enqueue(TValue element) => Enqueue(element, element);
    }

    class Step : IComparable<Step>
    {
        public int Y { get; set; }
        public int X { get; set; }
        public int Count { get; set; }
        public int Gold { get; set; }

        public Step Previous { get; set; }

        public Step(int y, int x, int count, int gold, Step previous = null)
        {
            Y = y;
            X = x;
            Count = count;
            Gold = gold;
            Previous = previous;
        }

        public bool NotVisit((int Y, int X) point)
        {
            if (Y == point.Y && X == point.X)
                return false;

            var node = Previous;
            while (node != null)
            {
                if (node.Y == point.Y && node.X == point.X)
                    return false;
                node = node.Previous;
            }

            return true;
        }

        public (int Y, int X) GetPoint() => (Y, X);

        public (int Y, int X) GetNextPoint((int Y, int X) move) => (Y + move.Y, X + move.X);

        public int CompareTo(Step other)
        {
            if (Count != other.Count)
                return Count.CompareTo(other.Count);

            if (Gold != other.Gold)
                return Gold.CompareTo(other.Gold);

            return 0;
        }

        public override string ToString()
        {
            return $"{nameof(Gold)}={Gold}, {nameof(Count)}={Count}";
        }
    }
}