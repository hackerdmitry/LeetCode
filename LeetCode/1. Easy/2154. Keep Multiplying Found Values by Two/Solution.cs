using System;

namespace LeetCode._1._Easy._2154._Keep_Multiplying_Found_Values_by_Two;

public class Solution
{
    public int FindFinalValue(int[] nums, int original)
    {
        Array.Sort(nums);
        foreach (var num in nums)
            if (num == original)
                original *= 2;
        return original;
    }
}
