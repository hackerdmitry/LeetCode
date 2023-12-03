using System;

namespace LeetCode._1._Easy._1266._Minimum_Time_Visiting_All_Points;

public class Solution
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        var result = 0;
        for (var i = 1; i < points.Length; i++)
        {
            var prevPoint = points[i - 1];
            var curPoint = points[i];

            var hor = Math.Abs(prevPoint[0] - curPoint[0]);
            var ver = Math.Abs(prevPoint[1] - curPoint[1]);

            result += hor > ver ? hor : ver;
        }

        return result;
    }
}
