using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._2200._Find_All_K_Distant_Indices_in_an_Array;

public class Solution
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var keyIndices = Enumerable.Range(0, nums.Length).Where(j => nums[j] == key).ToArray();
        if (keyIndices.Length == 0)
            return Array.Empty<int>();

        return Enumerable.Range(0, nums.Length).Where(i => keyIndices.Any(j => Math.Abs(i - j) <= k)).ToArray();
    }
}
