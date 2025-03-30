using System;
using System.Linq;

namespace LeetCode._2._Middle._2560._House_Robber_IV;

public class Solution
{
    public int MinCapability(int[] nums, int k)
    {
        var orderedNums = nums.OrderBy(x => x).ToArray();
        return orderedNums[BinarySearchMin(0, orderedNums.Length - 1, i => CanStealWithMaxMoney(nums, k, orderedNums[i]))];
    }

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

    private bool CanStealWithMaxMoney(int[] nums, int k, int maxMoney)
    {
        for (var i = 0; i < nums.Length && k > 0; i++)
            if (nums[i] <= maxMoney)
            {
                k--;
                i++;
            }

        return k == 0;
    }
}
