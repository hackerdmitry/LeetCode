using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1887._Reduction_Operations_to_Make_the_Array_Elements_Equal;

public class Solution
{
    public int ReductionOperations(int[] nums)
    {
        var dictNums = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (dictNums.ContainsKey(num))
                dictNums[num]++;
            else
                dictNums[num] = 1;
        }

        var orderedKeys = dictNums.Keys.OrderByDescending(x => x).ToArray();

        var result = 0;
        var prevCount = 0;

        for (var i = 0; i < orderedKeys.Length - 1; i++)
        {
            var maxNum = orderedKeys[i];
            var count = dictNums[maxNum] + prevCount;
            result += count;
            prevCount = count;
        }

        return result;
    }
}
