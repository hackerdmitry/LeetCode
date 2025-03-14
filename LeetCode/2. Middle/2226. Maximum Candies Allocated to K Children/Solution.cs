using System;
using System.Linq;

namespace LeetCode._2._Middle._2226._Maximum_Candies_Allocated_to_K_Children;

public class Solution
{
    public int MaximumCandies(int[] candies, long k)
    {
        var candiesCount = candies.Sum(x => (long) x);
        if (k > candiesCount)
            return 0;

        var minPileCandies = 1;
        var maxPileCandies = (int)(candiesCount / k);
        return BinarySearchMax(minPileCandies, maxPileCandies, pileSize => CanBeShareToPiles(candies, pileSize, k));
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

    private bool CanBeShareToPiles(int[] candies, int pileSize, long childrenCount)
    {
        foreach (var candy in candies)
        {
            childrenCount -= candy / pileSize;
            if (childrenCount <= 0)
                return true;
        }

        return false;
    }
}
