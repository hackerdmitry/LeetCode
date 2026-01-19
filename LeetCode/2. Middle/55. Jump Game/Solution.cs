using System;

namespace LeetCode._2._Middle._55._Jump_Game;

public class Solution
{
    public bool CanJump(int[] nums)
    {
        var maxReach = nums[0];

        for (var i = 1; maxReach < nums.Length && maxReach >= i; i++)
            maxReach = Math.Max(maxReach, i + nums[i]);

        return maxReach >= nums.Length - 1;
    }
}
