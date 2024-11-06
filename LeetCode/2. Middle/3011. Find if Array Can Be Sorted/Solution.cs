using System;
using System.Linq;

namespace LeetCode._2._Middle._3011._Find_if_Array_Can_Be_Sorted;

public class Solution
{
    public bool CanSortArray(int[] nums)
    {
        var sortedNums = nums.OrderBy(x => x).ToArray();
        var localMax = -1;
        var localCountSetBits = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != sortedNums[i])
            {
                localMax = Math.Max(localMax, nums[i]);

                if (localCountSetBits == -1)
                    localCountSetBits = NumberSetBits(nums[i]);
            }

            if (localMax != -1 && localCountSetBits != NumberSetBits(nums[i]))
                return false;

            if (sortedNums[i] == localMax && (i + 1 == nums.Length || sortedNums[i + 1] > sortedNums[i]))
            {
                localMax = -1;
                localCountSetBits = -1;
            }
        }

        return true;
    }

    private int NumberSetBits(int num)
    {
        var countSetBits = 0;
        while (num > 0)
        {
            countSetBits += num & 1;
            num >>= 1;
        }

        return countSetBits;
    }
}
