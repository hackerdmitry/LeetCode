using System;

namespace LeetCode._3._Hard._3068._Find_the_Maximum_Sum_of_Node_Values;

public class Solution
{
    public long MaximumValueSum(int[] nums, int k, int[][] edges)
    {
        var negativeMax = int.MinValue;
        var positiveMin = int.MaxValue;

        var count = 0;
        var sum = 0L;

        foreach (var num in nums)
        {
            var boost = (num ^ k) - num;
            sum += num;
            if (boost > 0)
            {
                count++;
                positiveMin = Math.Min(positiveMin, boost);
                sum += boost;
            }
            else
                negativeMax = Math.Max(negativeMax, boost);
        }

        return count % 2 == 0
            ? sum
            : Math.Max(sum - positiveMin, sum + negativeMax);
    }
}