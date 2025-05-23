using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._368._Largest_Divisible_Subset;

public class Solution
{
    public IList<int> LargestDivisibleSubset(int[] nums)
    {
        Array.Sort(nums);

        var resultMaxLength = 0;
        var resultReference = -1;

        var references = new int[nums.Length];
        var lengths = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            var maxLenght = 1;
            var reference = -1;

            for (var j = i - 1; j >= 0; j--)
                if (nums[i] % nums[j] == 0 && lengths[j] + 1 > maxLenght)
                {
                    maxLenght = lengths[j] + 1;
                    reference = j;
                }

            references[i] = reference;
            lengths[i] = maxLenght;

            if (resultMaxLength < maxLenght)
            {
                resultMaxLength = maxLenght;
                resultReference = i;
            }
        }

        var result = new int[resultMaxLength];
        for (var i = resultMaxLength - 1; i >= 0; i--)
        {
            result[i] = nums[resultReference];
            resultReference = references[resultReference];
        }
        return result;
    }
}
