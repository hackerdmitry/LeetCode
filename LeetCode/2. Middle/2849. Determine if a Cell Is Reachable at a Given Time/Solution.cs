using System;

namespace LeetCode._2._Middle._2849._Determine_if_a_Cell_Is_Reachable_at_a_Given_Time;

public class Solution
{
    public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
    {
        var hor = Math.Abs(sx - fx);
        var ver = Math.Abs(sy - fy);

        var max = Math.Max(hor, ver);

        return max == 0 ? t != 1 : t >= max;
    }
}