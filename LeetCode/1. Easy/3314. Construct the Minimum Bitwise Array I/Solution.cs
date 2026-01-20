using System.Collections.Generic;

namespace LeetCode._1._Easy._3314._Construct_the_Minimum_Bitwise_Array_I;

public class Solution
{
    public int[] MinBitwiseArray(IList<int> nums)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 2; i <= 1000; i++)
        {
            var value = i | (i - 1);
            dict.TryAdd(value, i - 1);
        }

        var result = new int[nums.Count];
        for (var i = 0; i < nums.Count; i++)
            result[i] = dict.GetValueOrDefault(nums[i], -1);
        return result;
    }
}
