using System;
using System.Linq;

namespace LeetCode._2._Middle._3201._Find_the_Maximum_Length_of_Valid_Subsequence_I;

public class Solution
{
    public int MaximumLength(int[] nums)
    {
        var result = nums.Count(x => x % 2 == 0);
        result = Math.Max(result, nums.Count(x => x % 2 == 1));
        return Math.Max(result, GetMaxChangingParityLength(nums));
    }

    private int GetMaxChangingParityLength(int[] nums)
    {
        var result = 0;
        var lastIsEven = nums[0] % 2 != 0;

        foreach (var num in nums)
            if ((num % 2 == 0) ^ lastIsEven)
            {
                lastIsEven = !lastIsEven;
                result++;
            }

        return result;
    }
}
