using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._3202._Find_the_Maximum_Length_of_Valid_Subsequence_II;

public class Solution
{
    public int MaximumLength(int[] nums, int k)
    {
        var modResultSearched = new HashSet<(int, int)>();

        var result = 2;

        for (var i = 0; i < nums.Length; i++)
            for (var j = i + 1; j < nums.Length; j++)
            {
                var modResult = (nums[i] + nums[j]) % k;
                if (!modResultSearched.Add((nums[i] % k, nums[j] % k)))
                    continue;

                var localResult = 2;
                var modLast = nums[j];

                for (var l = j + 1; l < nums.Length; l++)
                    if ((modLast + nums[l]) % k == modResult)
                    {
                        localResult++;
                        modLast = nums[l];
                    }

                result = Math.Max(result, localResult);
            }

        return result;
    }
}
