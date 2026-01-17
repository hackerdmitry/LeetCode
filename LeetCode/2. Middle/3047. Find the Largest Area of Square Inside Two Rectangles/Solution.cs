using System;

namespace LeetCode._2._Middle._3047._Find_the_Largest_Area_of_Square_Inside_Two_Rectangles;

public class Solution
{
    public long LargestSquareArea(int[][] bottomLeft, int[][] topRight)
    {
        var result = 0L;
        var n = bottomLeft.Length;
        for (var i = 0; i < n; i++)
            for (var j = i + 1; j < n; j++)
                result = Math.Max(result, MaxSquareIntersection(bottomLeft[i], topRight[i], bottomLeft[j], topRight[j]));
        return result;
    }

    private long MaxSquareIntersection(int[] bottomLeft1, int[] topRight1, int[] bottomLeft2, int[] topRight2)
    {
        var side1 = IntersectionSideLength(bottomLeft1[0], topRight1[0], bottomLeft2[0], topRight2[0]);
        var side2 = IntersectionSideLength(bottomLeft1[1], topRight1[1], bottomLeft2[1], topRight2[1]);
        var minSide = (long)Math.Min(side1, side2);
        return minSide * minSide;
    }

    private int IntersectionSideLength(int startSide1, int endSide1, int startSide2, int endSide2)
    {
        var left = Math.Max(startSide1, startSide2);
        var right = Math.Min(endSide1, endSide2);
        return left < right ? right - left : 0;
    }
}