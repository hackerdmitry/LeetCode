using System;

namespace LeetCode._1._Easy._3375._Minimum_Operations_to_Make_Array_Values_Equal_to_K;

public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        if (nums[0] < k)
            return -1;
        var result = 0;
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] > k && (i == 0 || nums[i - 1] != nums[i]))
                result++;
        return result;
    }
}
