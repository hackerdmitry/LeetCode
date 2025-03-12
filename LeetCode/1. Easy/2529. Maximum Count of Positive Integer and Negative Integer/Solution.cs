using System;
using System.Linq;

namespace LeetCode._1._Easy._2529._Maximum_Count_of_Positive_Integer_and_Negative_Integer;

public class Solution
{
    public int MaximumCount(int[] nums)
    {
        return Math.Max(nums.Count(x => x < 0), nums.Count(x => x > 0));
    }
}
