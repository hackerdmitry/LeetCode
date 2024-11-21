using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2257._Count_Unguarded_Cells_in_the_Grid;

public class Solution
{
    public int CountUnguarded(
        int m,
        int n,
        int[][] guards,
        int[][] walls)
    {
        var guardsHashSet = GetHashSet(guards);
        var wallsHashSet = GetHashSet(walls);

        var uncheckedCells = new Dictionary<Point, bool>();

        for (var y = 0; y < m; y++)
            for (var x = 0; x < n; x++)
            {
                var cell = new Point(x, y);
                if (!guardsHashSet.Contains(cell) && !wallsHashSet.Contains(cell))
                    uncheckedCells.Add(cell, false);
            }

        foreach (var point in guardsHashSet)
            CheckGuard(point, uncheckedCells);

        return uncheckedCells.Count(x => !x.Value);
    }

    private void CheckGuard(Point startPoint, Dictionary<Point, bool> uncheckedCells)
    {
        CheckDirection(startPoint, 0, 1, uncheckedCells);
        CheckDirection(startPoint, 0, -1, uncheckedCells);
        CheckDirection(startPoint, 1, 0, uncheckedCells);
        CheckDirection(startPoint, -1, 0, uncheckedCells);
    }

    private void CheckDirection(Point startPoint, int shiftX, int shiftY, Dictionary<Point, bool> uncheckedCells)
    {
        for (var point = new Point(startPoint.X + shiftX, startPoint.Y + shiftY);
             uncheckedCells.ContainsKey(point);
             point = new Point(point.X + shiftX, point.Y + shiftY))
            uncheckedCells[point] = true;
    }

    private HashSet<Point> GetHashSet(int[][] entities)
    {
        var entityHashSet = new HashSet<Point>();
        foreach (var entity in entities)
            entityHashSet.Add(new Point(entity[1], entity[0]));
        return entityHashSet;
    }

    private record struct Point(int X, int Y);
}