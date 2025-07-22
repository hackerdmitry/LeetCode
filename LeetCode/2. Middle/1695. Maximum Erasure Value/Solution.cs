using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._1695._Maximum_Erasure_Value;

public class Solution
{
    public int MaximumUniqueSubarray(int[] nums)
    {
        var left = 0;
        var right = 0;
        var result = 0;

        var bag = new HashSet<int>();
        var bagSum = 0;

        while (right < nums.Length)
        {
            var num = nums[right++];
            while (bag.Contains(num))
                BagRemove(bag, ref bagSum, nums[left++]);
            BagAdd(bag, ref bagSum, num);
            result = Math.Max(result, bagSum);
        }

        return result;
    }

    private void BagRemove(HashSet<int> bag, ref int bagSum, int num)
    {
        bagSum -= num;
        bag.Remove(num);
    }

    private void BagAdd(HashSet<int> bag, ref int bagSum, int num)
    {
        bagSum += num;
        bag.Add(num);
    }
}
