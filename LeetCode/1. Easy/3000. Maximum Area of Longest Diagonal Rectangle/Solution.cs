using System;

namespace LeetCode._1._Easy._3000._Maximum_Area_of_Longest_Diagonal_Rectangle;

public class Solution
{
    public int AreaOfMaxDiagonal(int[][] dimensions)
    {
        var longestDiagonal = 0;
        var maxArea = 0;

        foreach (var dimension in dimensions)
        {
            var diagonal = dimension[0] * dimension[0] + dimension[1] * dimension[1];
            if (diagonal >= longestDiagonal)
            {
                maxArea = diagonal > longestDiagonal
                    ? dimension[0] * dimension[1]
                    : Math.Max(maxArea, dimension[0] * dimension[1]);
                longestDiagonal = diagonal;
            }
        }

        return maxArea;
    }
}