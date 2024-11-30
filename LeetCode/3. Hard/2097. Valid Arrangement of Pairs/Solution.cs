using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._2097._Valid_Arrangement_of_Pairs;

public class Solution
{
    public int[][] ValidArrangement(int[][] pairs)
    {
        var points = GetPoints(pairs);
        var startPoint = GetStartPoint(points);
        return GetResult(EulerianPath(startPoint), pairs.Length);
    }

    private Point[] GetPoints(int[][] pairs)
    {
        var points = new Dictionary<int, Point>();

        foreach (var pair in pairs)
        {
            var startPoint = GetPoint(pair[0], points);
            var endPoint = GetPoint(pair[1], points);
            endPoint.From.Add(startPoint);
            startPoint.To.AddLast(endPoint);
        }

        return points.Values.ToArray();
    }

    private Point GetPoint(int value, Dictionary<int, Point> points)
    {
        if (!points.TryGetValue(value, out var point))
        {
            point = new Point(value);
            points.Add(value, point);
        }

        return point;
    }

    private Point GetStartPoint(Point[] points)
    {
        return points.FirstOrDefault(x => x.To.Count > x.From.Count) ?? points.First();
    }

    private IEnumerable<Point> EulerianPath(Point startPoint)
    {
        var stack = new Stack<Point>();
        Visit(startPoint, stack);
        return stack;
    }

    private void Visit(Point point, Stack<Point> result)
    {
        while (point.To.Count > 0)
        {
            var nextPoint = point.To.First();
            point.To.RemoveFirst();
            Visit(nextPoint, result);
        }

        result.Push(point);
    }

    private int[][] GetResult(IEnumerable<Point> orderedPoints, int length)
    {
        using var enumerator = orderedPoints.GetEnumerator();
        enumerator.MoveNext();
        var prevPoint = enumerator.Current!;
        var index = 0;

        var result = new int[length][];

        while (enumerator.MoveNext())
        {
            var curPoint = enumerator.Current!;
            result[index++] = new[] {prevPoint.Value, curPoint.Value};
            prevPoint = curPoint;
        }

        return result;
    }

    private class Point
    {
        public List<Point> From { get; } = new();
        public LinkedList<Point> To { get; } = new();

        public int Value { get; }

        public Point(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"[{Value}] | >> {string.Join(",", To.Select(x => x.Value))} | << {string.Join(",", From.Select(x => x.Value))}";
        }
    }
}