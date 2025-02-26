using System;
using System.Linq;

namespace LeetCode._2._Middle._1749._Maximum_Absolute_Sum_of_Any_Subarray;

public class Solution
{
    public int MaxAbsoluteSum(int[] nums)
    {
        var countAggNums = nums.Select((x, i) => (x, i)).Skip(1).Count(x => (x.x >= 0) ^ (nums[x.i - 1] >= 0)) + 1;
        var aggNums = new int[countAggNums];
        var aggNumsIndex = 0;
        aggNums[0] = nums[0];
        for (var i = 1; i < nums.Length; i++)
            if ((nums[i] >= 0) ^ (nums[i - 1] < 0))
                aggNums[aggNumsIndex] += nums[i];
            else
                aggNums[++aggNumsIndex] += nums[i];

        var max = 0;
        var min = 0;
        var streakPositive = 0;
        var streakNegative = 0;

        for (var i = 0; i < aggNums.Length; i++)
        {
            streakPositive = streakPositive + aggNums[i] > 0 ? streakPositive + aggNums[i] : 0;
            streakNegative = streakNegative + aggNums[i] < 0 ? streakNegative + aggNums[i] : 0;
            max = Math.Max(max, Math.Max(streakPositive, aggNums[i]));
            min = Math.Min(min, Math.Min(streakNegative, aggNums[i]));
        }

        return Math.Max(max, Math.Abs(min));
    }
}
