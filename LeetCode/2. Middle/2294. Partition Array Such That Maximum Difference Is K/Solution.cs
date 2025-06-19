using System;

namespace LeetCode._2._Middle._2294._Partition_Array_Such_That_Maximum_Difference_Is_K;

public class Solution
{
    public int PartitionArray(int[] nums, int k)
    {
        Array.Sort(nums);
        var result = 1;
        var startNum = nums[0];
        for (var i = 1; i < nums.Length; i++)
            if (nums[i] - startNum > k)
            {
                result++;
                startNum = nums[i];
            }

        return result;
    }
}
