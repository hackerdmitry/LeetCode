using System;
using System.Linq;

namespace LeetCode._2._Middle._1503._Last_Moment_Before_All_Ants_Fall_Out_of_a_Plank;

public class Solution
{
    public int GetLastMoment(int n, int[] left, int[] right)
    {
        return Math.Max(
            left.Length == 0 ? 0 : left.Max(x => x),
            right.Length == 0 ? 0 : right.Max(x => n - x));
    }
}