using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._560._Subarray_Sum_Equals_K;

public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        var count = 0;
        var sum = 0;
        var dict = new Dictionary<int, int> { { 0, 1 } };
        foreach (var num in nums)
        {
            sum += num;
            if (dict.ContainsKey(sum - k))
                count += dict[sum - k];
            if (dict.ContainsKey(sum))
                dict[sum]++;
            else
                dict.Add(sum, 1);
        }

        return count;
    }
}
