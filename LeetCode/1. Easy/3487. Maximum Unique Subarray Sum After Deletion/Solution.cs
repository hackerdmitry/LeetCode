using System.Linq;

namespace LeetCode._1._Easy._3487._Maximum_Unique_Subarray_Sum_After_Deletion;

public class Solution
{
    public int MaxSum(int[] nums)
    {
        var enumerable = nums.Where(x => x > 0).Distinct();
        return enumerable.Any() ? enumerable.Sum() : nums.Max();
    }
}
