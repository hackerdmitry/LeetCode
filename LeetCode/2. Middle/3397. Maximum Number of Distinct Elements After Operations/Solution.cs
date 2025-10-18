using System;

namespace LeetCode._2._Middle._3397._Maximum_Number_of_Distinct_Elements_After_Operations;

public class Solution
{
    public int MaxDistinctElements(int[] nums, int k)
    {
        Array.Sort(nums);

        var minNum = int.MinValue;
        var result = 0;

        foreach (var num in nums)
        {
            if (minNum < num + k)
                result++;

            minNum++;
            minNum = Math.Min(Math.Max(minNum, num - k), num + k);
        }

        return result;
    }
}