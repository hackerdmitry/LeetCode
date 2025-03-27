using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2780._Minimum_Index_of_a_Valid_Split;

public class Solution
{
    public int MinimumIndex(IList<int> nums)
    {
        var dominant = GetDominant(nums);
        return GetMinimumIndexToSplit(nums, dominant);
    }

    private int GetDominant(IList<int> nums)
    {
        return nums.GroupBy(x => x).MaxBy(x => x.Count()).Key;
    }

    private int GetMinimumIndexToSplit(IList<int> nums, int dominant)
    {
        var leftDominant = 0;
        var rightDominant = nums.Count(x => x == dominant);
        for (var i = 0; i < nums.Count; i++)
            if (nums[i] == dominant)
            {
                leftDominant++;
                rightDominant--;

                if (leftDominant > (i + 1) / 2 &&
                    rightDominant > (nums.Count - 1 - i) / 2)
                    return i;
            }

        return -1;
    }
}
