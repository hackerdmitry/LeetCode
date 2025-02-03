using System;

namespace LeetCode._1._Easy._3105._Longest_Strictly_Increasing_or_Strictly_Decreasing_Subarray;

public class Solution
{
    public int LongestMonotonicSubarray(int[] nums)
    {
        var maxDecreaseStreak = 0;
        var maxIncreaseStreak = 0;
        var decreaseStreak = 0;
        var increaseStreak = 0;

        for (var i = 1; i < nums.Length; i++)
            if (nums[i - 1] > nums[i])
            {
                decreaseStreak++;
                maxDecreaseStreak = Math.Max(maxDecreaseStreak, decreaseStreak);
                increaseStreak = 0;
            }
            else if (nums[i - 1] < nums[i])
            {
                increaseStreak++;
                maxIncreaseStreak = Math.Max(maxIncreaseStreak, increaseStreak);
                decreaseStreak = 0;
            }
            else
            {
                increaseStreak = 0;
                decreaseStreak = 0;
            }

        return Math.Max(maxIncreaseStreak, maxDecreaseStreak) + 1;
    }
}
