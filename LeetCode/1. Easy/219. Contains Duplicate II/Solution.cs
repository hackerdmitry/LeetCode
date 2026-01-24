using System.Collections.Generic;

namespace LeetCode._1._Easy._219._Contains_Duplicate_II;

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var lastIndices = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
            if (!lastIndices.TryAdd(nums[i], i))
                if (i - lastIndices[nums[i]] <= k)
                    return true;
                else
                    lastIndices[nums[i]] = i;
        return false;
    }
}