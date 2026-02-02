using System;

namespace LeetCode._2._Middle._3828._Final_Element_After_Subarray_Deletions;

public class Solution
{
    public int FinalElement(int[] nums)
    {
        return Math.Max(nums[0], nums[^1]);
    }
}