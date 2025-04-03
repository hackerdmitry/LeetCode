using System;

namespace LeetCode._2._Middle._2874._Maximum_Value_of_an_Ordered_Triplet_II;

public class Solution
{
    public long MaximumTripletValue(int[] nums)
    {
        var maxA = (long) nums[0];
        var minB = nums[1];
        var pocketMaxA = Math.Max(maxA, minB);

        var result = 0L;
        for (var i = 2; i < nums.Length; i++)
        {
            var c = nums[i];
            result = Math.Max(result, (maxA - minB) * c);
            if (pocketMaxA - c >= maxA - minB)
            {
                minB = c;
                maxA = pocketMaxA;
            }
            if (c > pocketMaxA)
                pocketMaxA = c;
        }

        return result;
    }
}
