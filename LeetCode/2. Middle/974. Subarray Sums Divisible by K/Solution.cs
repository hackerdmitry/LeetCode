using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._974._Subarray_Sums_Divisible_by_K;

public class Solution
{
    public int SubarraysDivByK(int[] nums, int k)
    {
        var prefixSum = new int[nums.Length + 1];
        for (var i = 0; i < nums.Length; i++)
            prefixSum[i + 1] = ((prefixSum[i] + nums[i]) % k + k) % k;

        var numPlacementList = new List<int>{0, 0, 1, 3, 6, 10};

        int GetNumPlacement(int count)
        {
            while (numPlacementList.Count <= count)
                numPlacementList.Add(numPlacementList[^1] + numPlacementList.Count - 1);
            return numPlacementList[count];
        }

        return prefixSum.GroupBy(x => x).Sum(x => GetNumPlacement(x.Count()));
    }
}
