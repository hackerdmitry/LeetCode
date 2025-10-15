using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._3350._Adjacent_Increasing_Subarrays_Detection_II;

public class Solution
{
    public int MaxIncreasingSubarrays(IList<int> nums)
    {
        return BinarySearchMax(1, nums.Count / 2, k => HasIncreasingSubarrays(nums, k));
    }

    private bool HasIncreasingSubarrays(IList<int> nums, int k)
    {
        var prevIncreasing = 0;
        var lastIncreasing = 1;
        for (var i = 1; i < nums.Count; i++, lastIncreasing++)
            if (nums[i - 1] >= nums[i])
            {
                if (lastIncreasing >= 2 * k ||
                    lastIncreasing >= k && prevIncreasing >= k)
                    return true;
                prevIncreasing = lastIncreasing;
                lastIncreasing = 0;
            }

        return lastIncreasing >= 2 * k || lastIncreasing >= k && prevIncreasing >= k;
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
