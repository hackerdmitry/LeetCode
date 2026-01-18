using System.Collections.Generic;

namespace LeetCode._2._Middle._3810._Minimum_Operations_to_Reach_Target_Array;

public class Solution
{
    public int MinOperations(int[] nums, int[] target)
    {
        var hashSet = new HashSet<int>();
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] != target[i])
                hashSet.Add(nums[i]);

        return hashSet.Count;
    }
}