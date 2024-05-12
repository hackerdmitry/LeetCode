using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._18._4Sum;

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort(nums);
        var dictionary = nums.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

        var result = new List<int[]>();

        var targets = new Dictionary<long, LinkedList<(int, int)>>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (i != 0 && nums[i - 1] == nums[i])
                continue;

            for (var j = i + 1; j < nums.Length; j++)
            {
                if (j != i + 1 && nums[j - 1] == nums[j])
                    continue;

                var localTarget = (long) target - nums[i] - nums[j];
                if (!targets.ContainsKey(localTarget))
                    targets[localTarget] = new LinkedList<(int, int)>();
                targets[localTarget].AddLast((nums[i], nums[j]));
            }
        }

        var countDictionary = new Dictionary<int, int>();
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
                countDictionary[first] = 1;
                countDictionary[second] = countDictionary.TryGetValue(second, out var value) ? value + 1 : 1;
                var localTarget = (long) first + second;
                if (targets.ContainsKey(localTarget))
                {
                    foreach (var (third, fourth) in targets[localTarget])
                    {
                        if (third < second)
                            continue;

                        countDictionary[third] = countDictionary.TryGetValue(third, out value) ? value + 1 : 1;
                        countDictionary[fourth] = countDictionary.TryGetValue(fourth, out value) ? value + 1 : 1;

                        foreach (var (key, count) in countDictionary)
                            if (dictionary[key] < count)
                                goto next;

                        result.Add(new[] {first, second, third, fourth});

                        next: ;

                        countDictionary[third]--;
                        if (countDictionary[third] == 0) countDictionary.Remove(third);
                        countDictionary[fourth]--;
                        if (countDictionary[fourth] == 0) countDictionary.Remove(fourth);
                    }
                }

                countDictionary.Clear();
            }
        }

        return result.ToArray();
    }
}