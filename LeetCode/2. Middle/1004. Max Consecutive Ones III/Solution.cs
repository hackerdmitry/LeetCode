using System;
using System.Linq;

namespace LeetCode._2._Middle._1004._Max_Consecutive_Ones_III;

public class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        var l = 0;
        var maxLength = 0;
        for (var r = 0; r < nums.Length; r++)
        {
            if (nums[r] == 0)
                k--;
            while (k < 0)
                if (nums[l++] == 0)
                    k++;
            maxLength = Math.Max(maxLength, r - l + 1);
        }

        return maxLength;
    }
}