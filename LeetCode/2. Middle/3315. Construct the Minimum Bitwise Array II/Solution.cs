using System.Collections.Generic;

namespace LeetCode._2._Middle._3315._Construct_the_Minimum_Bitwise_Array_II;

public class Solution
{
    public int[] MinBitwiseArray(IList<int> nums)
    {
        var result = new int[nums.Count];
        for (var i = 0; i < nums.Count; i++)
            result[i] = MinBitwiseNumber(nums[i]);
        return result;
    }

    private int MinBitwiseNumber(int number)
    {
        if (number % 2 == 0)
            return -1;

        var countShift = 0;
        while (number % 2 == 1)
        {
            number >>= 1;
            countShift++;
        }

        number <<= 1;
        while (countShift-- > 1)
            number = (number << 1) + 1;

        return number;
    }
}
