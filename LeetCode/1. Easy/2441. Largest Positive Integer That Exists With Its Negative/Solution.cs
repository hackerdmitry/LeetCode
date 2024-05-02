using System;

namespace LeetCode._1._Easy._2441._Largest_Positive_Integer_That_Exists_With_Its_Negative;

public class Solution
{
    public int FindMaxK(int[] nums)
    {
        Array.Sort(nums);
        var pointer1 = 0;
        var pointer2 = nums.Length - 1;

        while (nums[pointer1] < 0 && nums[pointer2] > 0)
        {
            if (nums[pointer1] == -nums[pointer2])
                return nums[pointer2];
            if (nums[pointer1] < -nums[pointer2])
                pointer1++;
            else
                pointer2--;
        }

        return -1;
    }
}