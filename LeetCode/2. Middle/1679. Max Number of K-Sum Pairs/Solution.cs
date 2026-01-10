using System;

namespace LeetCode._2._Middle._1679._Max_Number_of_K_Sum_Pairs;

public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        var ptr1 = 0;
        var ptr2 = nums.Length - 1;

        Array.Sort(nums);

        var result = 0;
        while (ptr1 < ptr2)
        {
            var sum = nums[ptr1] + nums[ptr2];
            if (sum == k)
            {
                ptr1++;
                ptr2--;
                result++;
            }
            else if (sum < k)
                ptr1++;
            else
                ptr2--;
        }

        return result;
    }
}
