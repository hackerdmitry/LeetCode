using System;

namespace LeetCode._2._Middle._2563._Count_the_Number_of_Fair_Pairs;

public class Solution
{
    public long CountFairPairs(int[] nums, int lower, int upper)
    {
        Array.Sort(nums);

        var resultCount = 0L;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            var lowerIndex = FindLowerIndex(nums, i, lower, upper);
            var upperIndex = FindUpperIndex(nums, i, lower, upper);

            if (lowerIndex == -1 || upperIndex == -1)
                continue;

            resultCount += upperIndex - lowerIndex + 1;
        }

        return resultCount;
    }

    private int FindLowerIndex(int[] nums, int startIndex, int lower, int upper)
    {
        var left = startIndex + 1;
        var right = nums.Length - 1;

        while (left < right)
        {
            var middle = (left + right) / 2;
            var curNum = nums[middle] + nums[startIndex];

            if (curNum >= lower)
                right = middle;
            else if (left == middle)
                left++;
            else
                left = middle;
        }

        return IsInBorder(lower, upper, nums[left] + nums[startIndex]) ? left : -1;
    }

    private int FindUpperIndex(int[] nums, int startIndex, int lower, int upper)
    {
        var left = startIndex + 1;
        var right = nums.Length - 1;

        while (left < right)
        {
            var middle = (left + right) / 2 + (left + right) % 2;
            var curNum = nums[middle] + nums[startIndex];

            if (curNum <= upper)
                left = middle;
            else if (right == middle)
                right--;
            else
                right = middle;
        }

        return IsInBorder(lower, upper, nums[left] + nums[startIndex]) ? left : -1;
    }

    private bool IsInBorder(int lower, int upper, int number) =>
        lower <= number && number <= upper;
}
