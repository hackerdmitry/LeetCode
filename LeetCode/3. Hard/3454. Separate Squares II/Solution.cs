using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._3454._Separate_Squares_II;

public class Solution
{
    public double SeparateSquares(int[][] squares)
    {
        var events = CreateEvents(squares, out var xCoords);
        var segmentLengths = CreateSegmentLengths(xCoords);
        var xCoordToSegment = xCoords.Select((x, i) => new { x, i }).ToDictionary(item => item.x, item => item.i);
        var segmentTree = CreateSegmentTreeNode(0, segmentLengths.Length - 1, segmentLengths);
        var totalArea = CalculateTotalArea(events, segmentTree, xCoordToSegment);
        return FindMinY(events, segmentTree, xCoordToSegment, totalArea / 2d);
    }

    private static Event[] CreateEvents(int[][] squares, out SortedSet<int> xCoords)
    {
        var events = new Event[squares.Length * 2];
        xCoords = new SortedSet<int>();

        for (var i = 0; i < squares.Length; i++)
        {
            var square = squares[i];
            var x1 = square[0];
            var y1 = square[1];
            var x2 = square[0] + square[2];
            var y2 = square[1] + square[2];

            xCoords.Add(x1);
            xCoords.Add(x2);

            events[i * 2] = new Event(y1, x1, x2, 1);
            events[i * 2 + 1] = new Event(y2, x1, x2, -1);
        }

        Array.Sort(events, (a, b) => a.Y.CompareTo(b.Y));
        return events;
    }

    private static long[] CreateSegmentLengths(SortedSet<int> xCoords)
    {
        var segmentLengths = new long[xCoords.Count - 1];

        var prevX = xCoords.First();
        var index = 0;
        foreach (var x in xCoords.Skip(1))
        {
            segmentLengths[index++] = x - prevX;
            prevX = x;
        }

        return segmentLengths;
    }

    private long CalculateTotalArea(Event[] events, ISegmentTreeNode segmentTree, Dictionary<int, int> xCoordToSegment)
    {
        var totalArea = 0L;
        var prevY = events[0].Y;

        foreach (var ev in events)
        {
            if (prevY != ev.Y)
            {
                var currentLength = segmentTree.GetLength();
                totalArea += currentLength * (ev.Y - prevY);
            }

            segmentTree.Update(xCoordToSegment[ev.X1], xCoordToSegment[ev.X2] - 1, ev.Value);
            prevY = ev.Y;
        }

        return totalArea;
    }

    private static double FindMinY(Event[] events, ISegmentTreeNode segmentTree, Dictionary<int, int> xCoordToSegment, double targetArea)
    {
        var prevY = events[0].Y;

        foreach (var ev in events)
        {
            if (prevY != ev.Y)
            {
                var currentLength = segmentTree.GetLength();
                var height = ev.Y - prevY;
                var segmentArea = currentLength * height;
                if (segmentArea < targetArea)
                    targetArea -= segmentArea;
                else
                    return prevY + height * (targetArea / segmentArea);
            }

            segmentTree.Update(xCoordToSegment[ev.X1], xCoordToSegment[ev.X2] - 1, ev.Value);
            prevY = ev.Y;
        }

        return -1;
    }

    private class Event
    {
        public int Y { get; }
        public int X1 { get; }
        public int X2 { get; }
        public int Value { get; }

        public Event(int y, int x1, int x2, int value)
        {
            Y = y;
            X1 = x1;
            X2 = x2;
            Value = value;
        }
    }

    private static ISegmentTreeNode CreateSegmentTreeNode(int left, int right, long[] segmentLengths)
    {
        return left == right
            ? new SegmentTreeLeafNode(segmentLengths[left])
            : new SegmentTreeNode(left, right, segmentLengths);
    }

    private class SegmentTreeNode : ISegmentTreeNode
    {
        private long totalLength; // общая длина сегмента

        private readonly int left; // левая граница сегмента
        private readonly int mid; // середина сегмента
        private readonly int right; // правая граница сегмента

        private ISegmentTreeNode leftNode;
        private ISegmentTreeNode rightNode;

        public SegmentTreeNode(int left, int right, long[] segmentLengths)
        {
            mid = (left + right) / 2;
            this.left = left;
            this.right = right;
            leftNode = CreateSegmentTreeNode(left, mid, segmentLengths);
            rightNode = CreateSegmentTreeNode(mid + 1, right, segmentLengths);
        }

        public long GetLength()
        {
            return totalLength;
        }

        public void Update(int from, int to, int value)
        {
            if (left <= from && from <= mid)
                leftNode.Update(from, Math.Min(mid, to), value);

            if (mid < to && to <= right)
                rightNode.Update(Math.Max(mid + 1, from), to, value);

            totalLength = leftNode.GetLength() + rightNode.GetLength();
        }

        public int CountSegments()
        {
            return leftNode.CountSegments() + rightNode.CountSegments();
        }
    }

    private class SegmentTreeLeafNode : ISegmentTreeNode
    {
        private readonly long length; // длина сегмента
        private int count; // кол-во сегментов в этой ноде

        public SegmentTreeLeafNode(long length)
        {
            this.length = length;
        }

        public long GetLength()
        {
            return count > 0 ? length : 0;
        }

        public void Update(int from, int to, int value)
        {
            count += value;
        }

        public int CountSegments()
        {
            return 1;
        }
    }

    private interface ISegmentTreeNode
    {
        long GetLength();
        void Update(int from, int to, int value);
        int CountSegments();
    }
}