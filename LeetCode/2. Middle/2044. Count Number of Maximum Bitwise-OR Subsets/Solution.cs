using System.Linq;

namespace LeetCode._2._Middle._2044._Count_Number_of_Maximum_Bitwise_OR_Subsets;

public class Solution
{
    public int CountMaxOrSubsets(int[] nums)
    {
        var maxBitwise = nums.Aggregate(0, (prev, curr) => prev | curr);
        return CountSameBitwise(0, maxBitwise, 0, nums);
    }

    private int CountSameBitwise(int current, int bitwise, int index, int[] nums)
    {
        var result = (current | nums[index]) == bitwise ? 1 : 0;
        if (index + 1 < nums.Length)
            result += CountSameBitwise(current | nums[index], bitwise, index + 1, nums) +
                      CountSameBitwise(current, bitwise, index + 1, nums);
        return result;
    }
}