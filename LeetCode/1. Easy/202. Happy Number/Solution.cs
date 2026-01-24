using System.Collections.Generic;

namespace LeetCode._1._Easy._202._Happy_Number;

public class Solution
{
    public bool IsHappy(int n)
    {
        var hashSet = new HashSet<int>();
        while (n != 1 && !hashSet.Contains(n))
        {
            hashSet.Add(n);
            n = SquareDigits(n);
        }

        return n == 1;
    }

    private int SquareDigits(int n)
    {
        var result = 0;
        while (n > 0)
        {
            result += n % 10 * (n % 10);
            n /= 10;
        }

        return result;
    }
}