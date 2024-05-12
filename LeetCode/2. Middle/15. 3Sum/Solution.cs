using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._15._3Sum;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var dictionary = nums.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

        var result = new List<int[]>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (i != 0 && nums[i - 1] == nums[i])
                continue;
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (j != i + 1 && nums[j - 1] == nums[j])
                    continue;
                var first = nums[i];
                var second = nums[j];
                var third = -(first + second);
                if (third < second)
                    break;

                if (dictionary.ContainsKey(third))
                {
                    if (first == third && second == third)
                    {
                        if (dictionary[third] >= 3)
                            result.Add(new[] {first, second, third});
                    }
                    else if (first == third || second == third)
                    {
                        if (dictionary[third] >= 2)
                            result.Add(new[] {first, second, third});
                    }
                    else
                        result.Add(new[] {first, second, third});
                }
            }
        }

        return result.ToArray();
    }
}