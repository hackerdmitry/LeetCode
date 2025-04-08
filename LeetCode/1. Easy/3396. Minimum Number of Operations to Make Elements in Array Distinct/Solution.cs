using System.Collections.Generic;

namespace LeetCode._1._Easy._3396._Minimum_Number_of_Operations_to_Make_Elements_in_Array_Distinct;

public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        var maxOperations = nums.Length / 3;
        if (nums.Length % 3 != 0)
            maxOperations++;

        var intermediateHashSet = new HashSet<int>();
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (!intermediateHashSet.Add(nums[i]))
                return maxOperations;
            if (i % 3 == 0)
                maxOperations--;
        }

        return maxOperations;
    }
}
