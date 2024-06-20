using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._1552._Magnetic_Force_Between_Two_Balls;

public class Solution
{
    public int MaxDistance(int[] position, int m)
    {
        Array.Sort(position);

        var left = 1;
        var right = position[^1] - position[0] + 1;

        while (left < right)
        {
            var mid = (left + right) / 2;

            if (!CanUseDistance(position, m, mid))
                right = mid;
            else if (left == mid)
                right--;
            else
                left = mid;
        }

        return left;
    }

    private bool CanUseDistance(int[] position, int m, int distance)
    {
        m--;
        var prevPosition = position[0];

        for (var i = 1; i < position.Length; i++)
        {
            if (position[i] - prevPosition >= distance)
            {
                prevPosition = position[i];
                m--;
            }

            if (m == 0)
                return true;
        }

        return false;
    }
}
