using System;

namespace LeetCode._2._Middle._2145._Count_the_Hidden_Sequences;

public class Solution
{
    public int NumberOfArrays(int[] differences, int lower, int upper)
    {
        var min = 0L;
        var max = 0L;
        var curr = 0L;
        foreach (var diff in differences)
        {
            curr += diff;
            min = Math.Min(curr, min);
            max = Math.Max(curr, max);
        }

        return (int)Math.Max(0, upper - lower - max + min + 1);
    }
}