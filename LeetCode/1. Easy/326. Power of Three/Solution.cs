using System;

namespace LeetCode._1._Easy._326._Power_of_Three;

public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        var power = Math.Log(n, 3);
        return !double.IsNaN(power) && Math.Abs(power - Math.Round(power)) < 1e-10;
    }
}