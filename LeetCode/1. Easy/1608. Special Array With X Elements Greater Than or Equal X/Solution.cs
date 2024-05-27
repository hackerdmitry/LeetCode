using System;

namespace LeetCode._1._Easy._1608._Special_Array_With_X_Elements_Greater_Than_or_Equal_X;

public class Solution
{
    public int SpecialArray(int[] nums)
    {
        Array.Sort(nums);

        var i = 0;
        for (var x = 0; x < 1000; x++)
        {
            while (i < nums.Length && nums[i] < x)
                i++;

            if (i == nums.Length)
                break;

            if (x == nums.Length - i)
                return x;
        }

        return -1;
    }
}
