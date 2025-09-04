using System;

namespace LeetCode._1._Easy._3516._Find_Closest_Person;

public class Solution
{
    public int FindClosest(int x, int y, int z)
    {
        var distToX = Math.Abs(x - z);
        var distToY = Math.Abs(y - z);
        return distToX == distToY
            ? 0
            : distToX > distToY
                ? 2
                : 1;
    }
}
