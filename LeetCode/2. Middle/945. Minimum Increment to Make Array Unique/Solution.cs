using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._945._Minimum_Increment_to_Make_Array_Unique;

public class Solution
{
    public int MinIncrementForUnique(int[] nums)
    {
        Array.Sort(nums);

        var result = 0;
        var unique = nums[0];
        var queue = new Queue<int>();
        for (var i = 1; i < nums.Length; i++)
        {
            if (unique == nums[i])
                queue.Enqueue(unique);
            else
            {
                while (++unique != nums[i] && queue.Count > 0)
                    result += unique - queue.Dequeue();

                unique = nums[i];
            }
        }

        while (queue.Count > 0)
            result += ++unique - queue.Dequeue();

        return result;
    }
}
