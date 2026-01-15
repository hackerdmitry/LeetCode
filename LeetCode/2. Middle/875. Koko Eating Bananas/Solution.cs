using System.Linq;

namespace LeetCode._2._Middle._875._Koko_Eating_Bananas;

public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        var left = 1;
        var right = piles.Max();

        while (left < right)
        {
            var mid = (left + right) / 2;
            if (CanBeSuccess(piles, h, mid))
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }

    private bool CanBeSuccess(int[] piles, int h, int speed)
    {
        var hours = 0;
        foreach (var pile in piles)
        {
            hours += (pile + speed - 1) / speed;
            if (hours > h)
                return false;
        }

        return hours <= h;
    }
}
