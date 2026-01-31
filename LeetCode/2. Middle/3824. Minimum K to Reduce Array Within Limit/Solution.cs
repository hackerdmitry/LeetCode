using System;
using System.Linq;

namespace LeetCode._2._Middle._3824._Minimum_K_to_Reduce_Array_Within_Limit;

public class Solution
{
    public int MinimumK(int[] nums)
    {
        return BinarySearchMin(1, 46_340, k => NonPositive(nums, k) <= k * k);
    }

    private int NonPositive(int[] nums, int k)
    {
        return nums.Sum(num => NonPositiveDistance(num, k));
    }

    private int NonPositiveDistance(int num, int k) =>
        num % k == 0 ? num / k : num / k + 1;

    private int BinarySearchMin(int left, int right, Func<int, bool> canBeRight)
    {
        while (left < right)
        {
            var mid = (left + right) / 2;
            var isRight = canBeRight(mid);
            if (isRight)
                right = mid;
            else if (left == mid)
                left++;
            else
                left = mid;
        }

        return left;
    }
}