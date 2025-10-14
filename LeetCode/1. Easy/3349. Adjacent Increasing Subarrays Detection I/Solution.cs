using System.Collections.Generic;

namespace LeetCode._1._Easy._3349._Adjacent_Increasing_Subarrays_Detection_I;

public class Solution
{
    public bool HasIncreasingSubarrays(IList<int> nums, int k)
    {
        var prevIncreasing = 0;
        var lastIncreasing = 1;
        for (var i = 1; i < nums.Count; i++, lastIncreasing++)
            if (nums[i - 1] >= nums[i])
            {
                if (lastIncreasing >= 2 * k ||
                    lastIncreasing >= k && prevIncreasing >= k)
                    return true;
                prevIncreasing = lastIncreasing;
                lastIncreasing = 0;
            }

        return lastIncreasing >= 2 * k || lastIncreasing >= k && prevIncreasing >= k;
    }
}