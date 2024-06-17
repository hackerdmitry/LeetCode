using System;
using System.Linq;

namespace LeetCode._2._Middle._633._Sum_of_Square_Numbers;

public class Solution
{
    public bool JudgeSquareSum(int c)
    {
        var max = (int)Math.Sqrt(c);
        var squares = Enumerable.Range(0, max + 1).Select(x => x * x).ToHashSet();

        foreach (var square in squares)
            if (squares.Contains(c - square))
                return true;
        return false;
    }
}
