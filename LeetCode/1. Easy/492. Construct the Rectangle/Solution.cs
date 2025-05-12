using System;

namespace LeetCode._1._Easy._492._Construct_the_Rectangle;

public class Solution
{
    public int[] ConstructRectangle(int area)
    {
        var squareArea = (int) Math.Sqrt(area);
        var min1 = area;
        var min2 = 1;

        for (var side = 2; side <= squareArea && side >= min2; side++)
            if (area % side == 0)
            {
                min1 = area / side;
                min2 = side;
            }

        return new[] {min1, min2};
    }
}