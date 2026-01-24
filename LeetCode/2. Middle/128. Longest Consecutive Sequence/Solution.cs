using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._128._Longest_Consecutive_Sequence;

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var hashSet = new HashSet<int>(nums);

        var result = 0;
        while (hashSet.Count > 0)
        {
            var num = hashSet.First();
            while (hashSet.Contains(num - 1))
                num--;

            hashSet.Remove(num);

            var length = 1;
            while (hashSet.Contains(num + 1))
            {
                length++;
                hashSet.Remove(++num);
            }

            result = Math.Max(result, length);
        }

        return result;
    }
}