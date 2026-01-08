using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._334._Increasing_Triplet_Subsequence;

public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        var min1 = (int?)null;
        var min2 = (int?)null;
        var middle = (int?)null;

        foreach (var num in nums)
        {
            if (min1 == null || min2 == null && num < min1)
                min1 = num;
            else if (num < min1)
            {
                if (min2 != null)
                    min1 = min2;
                min2 = num;
            }
            else if ((middle == null || num < middle) && (num > min1 || num > min2))
                middle = num;
            else if (num > middle)
                return true;
        }

        return false;
    }
}