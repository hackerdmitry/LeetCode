using System;
using System.IO;

namespace LeetCode._2._Middle._2762._Continuous_Subarrays;

public class Solution
{
    public long ContinuousSubarrays(int[] nums)
    {
        var numberContinuousSubarrays = (long)nums.Length;
        for (var i = 0; i < nums.Length; i++)
        {
            var startIndex = GetStartIndexContinuousSubarray(nums, i, out var minNumber, out var maxNumber);
            var endIndex = GetEndIndexContinuousSubarray(nums, i, minNumber, maxNumber);
            if (startIndex != endIndex)
            {
                var length = (long)(endIndex - startIndex);
                numberContinuousSubarrays += (length + 1) * length / 2;

                if (startIndex + 1 < i)
                {
                    var startLength = (long)(i - startIndex - 1);
                    numberContinuousSubarrays -= (startLength + 1) * startLength / 2;
                }

                i = endIndex;
            }
        }

        return numberContinuousSubarrays;
    }

    private int GetStartIndexContinuousSubarray(int[] nums, int endIndex, out int minNumber, out int maxNumber)
    {
        minNumber = nums[endIndex];
        maxNumber = nums[endIndex];

        for (var i = endIndex - 1; i >= 0; i--)
        {
            var targetMinNumber = Math.Min(minNumber, nums[i]);
            var targetMaxNumber = Math.Max(maxNumber, nums[i]);
            if (targetMaxNumber - targetMinNumber > 2)
                return i + 1;
            minNumber = targetMinNumber;
            maxNumber = targetMaxNumber;
        }

        return 0;
    }

    private int GetEndIndexContinuousSubarray(int[] nums, int startIndex, int minNumber, int maxNumber)
    {
        for (var i = startIndex + 1; i < nums.Length; i++)
        {
            minNumber = Math.Min(minNumber, nums[i]);
            maxNumber = Math.Max(maxNumber, nums[i]);
            if (maxNumber - minNumber > 2)
                return i - 1;
        }

        return nums.Length - 1;
    }
}
