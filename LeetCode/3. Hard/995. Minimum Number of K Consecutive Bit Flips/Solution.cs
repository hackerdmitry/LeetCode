using System;
using System.Collections.Generic;

namespace LeetCode._3._Hard._995._Minimum_Number_of_K_Consecutive_Bit_Flips;

public class Solution
{
    public int MinKBitFlips(int[] nums, int k)
    {
        var list = new List<int>(nums.Length / 2);

        for (var i = 0; i < nums.Length; i++)
            if (GetBit(i, nums[i], k, list) == 0)
                list.Add(i);

        return list.Count == 0 ||
               list[^1] + k <= nums.Length
            ? list.Count
            : -1;
    }

    private int GetBit(int index, int value, int k, List<int> list)
    {
        var left = 0;
        var right = list.Count;
        while (left < right)
        {
            var mid = (left + right) / 2;

            if (list[mid] <= index && index < list[mid] + k)
                right = mid;
            else if (mid == left)
                left++;
            else
                left = mid;
        }

        return (value + (left - list.Count)) % 2;
    }
}