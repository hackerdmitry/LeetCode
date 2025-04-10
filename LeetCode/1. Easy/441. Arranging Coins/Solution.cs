using System;

namespace LeetCode._1._Easy._441._Arranging_Coins;

public class Solution
{
    public int ArrangeCoins(int n)
    {
        return BinarySearchMax(1, 65_535, x => (x + 1L) * x / 2 <= n);
    }

    private int BinarySearchMax(int left, int right, Func<int, bool> canBeLeft)
    {
        while (left < right)
        {
            var mid = (left + right) / 2;
            if (left == mid)
                mid++;
            var isLeft = canBeLeft(mid);
            if (isLeft)
                left = mid;
            else if (right == mid)
                right--;
            else
                right = mid;
        }

        return left;
    }
}