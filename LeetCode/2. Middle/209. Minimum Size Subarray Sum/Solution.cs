using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._209._Minimum_Size_Subarray_Sum;

public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        var queueStart = 0;
        var queueEnd = 0;
        var queueSum = 0;

        var minLength = int.MaxValue;

        while (queueEnd != nums.Length)
        {
            queueSum += nums[queueEnd++];

            while (queueSum - nums[queueStart] >= target)
                queueSum -= nums[queueStart++];

            if (queueSum >= target)
                minLength = Math.Min(minLength, queueEnd - queueStart);
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}
