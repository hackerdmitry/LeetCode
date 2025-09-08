using System;

namespace LeetCode._1._Easy._1317._Convert_Integer_to_the_Sum_of_Two_No_Zero_Integers;

public class Solution
{
    public int[] GetNoZeroIntegers(int n)
    {
        for (var i = 1; i < n; i++)
            if (IsNonZeroNum(i) && IsNonZeroNum(n - i))
                return new[] { i, n - i };
        throw new Exception("No solution found");
    }

    private bool IsNonZeroNum(int x)
    {
        while (x > 0)
        {
            if (x % 10 == 0)
                return false;
            x /= 10;
        }

        return true;
    }
}
