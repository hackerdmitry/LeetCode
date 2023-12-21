using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1637._Widest_Vertical_Area_Between_Two_Points_Containing_No_Points;

public class Solution
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        var result = int.MinValue;
        var startPoint = int.MaxValue;
        foreach (var point in points.Select(x => x[0]).OrderBy(x => x))
        {
            if (startPoint != int.MaxValue)
                result = Math.Max(point - startPoint, result);
            startPoint = point;
        }

        return result;
    }
}
