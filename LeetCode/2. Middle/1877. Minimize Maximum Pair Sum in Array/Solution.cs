using System;

namespace LeetCode._2._Middle._1877._Minimize_Maximum_Pair_Sum_in_Array;

public class Solution
{
    public int MinPairSum(int[] nums)
    {
        Array.Sort(nums);

        var sum = -1;
        for (var i = 0; i < nums.Length / 2; i++)
        {
            var localSum = nums[i] + nums[nums.Length - 1 - i];
            if (localSum > sum)
                sum = localSum;
        }

        return sum;
    }
}
