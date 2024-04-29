using System.Linq;

namespace LeetCode._2._Middle._2997._Minimum_Number_of_Operations_to_Make_Array_XOR_Equal_to_K;

public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        var xor = nums.Aggregate(0, (xorResult, elem) => elem ^ xorResult);
        var diff = xor ^ k;
        var result = 0;
        while (diff > 0)
        {
            result += diff % 2;
            diff >>= 1;
        }

        return result;
    }
}