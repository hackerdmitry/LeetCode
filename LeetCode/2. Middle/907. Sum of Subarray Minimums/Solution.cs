using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace LeetCode._2._Middle._907._Sum_of_Subarray_Minimums;

public class Solution
{
    private const long modulo = 1_000_000_007;

    public int SumSubarrayMins(int[] arr)
    {
        var points = arr.Select(x => (Point) x).ToArray();
        FillLeftRights(points);
        return CountSum(points);
    }

    private static int CountSum(Point[] points)
    {
        long sum = 0;
        foreach (var point in points)
            checked
            {
                sum += (long) point.Value * point.Left * point.Right;
                sum %= modulo;
            }

        return (int) sum;
    }

    private static void FillLeftRights(Point[] points)
    {
        var stack = new Stack<Point>();
        stack.Push(points.First());

        int right;
        foreach (var point in points.Skip(1))
        {
            if (point > stack.Peek())
                stack.Push(point);
            else
            {
                var left = 0;
                right = 0;
                while (stack.Count > 0 && point < stack.Peek())
                {
                    right += stack.Peek().Right;
                    left += stack.Peek().Left;
                    stack.Pop().Right = right;
                }

                if (stack.Count > 0)
                    stack.Peek().Right += right;

                point.Left += left;
                stack.Push(point);
            }
        }

        right = 0;
        while (stack.Count > 0)
        {
            var point = stack.Pop();
            right += point.Right;
            point.Right = right;
            if (stack.Count > 0)
                point.Left = stack.Peek().Right;
        }
    }

    class Point
    {
        public int Left { get; set; } = 1;
        public int Right { get; set; } = 1;
        public int Value { get; set; }

        public Point(int value)
        {
            Value = value;
        }

        public static implicit operator Point(int value) => new(value);
        public static bool operator <(Point p1, Point p2) => p1.Value < p2.Value;
        public static bool operator >(Point p1, Point p2) => p1.Value > p2.Value;

        public override string ToString()
        {
            return $"value: {Value}, left: {Left}, right: {Right}";
        }
    }
}