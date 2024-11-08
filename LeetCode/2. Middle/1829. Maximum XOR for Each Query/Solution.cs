namespace LeetCode._2._Middle._1829._Maximum_XOR_for_Each_Query;

public class Solution
{
    public int[] GetMaximumXor(int[] nums, int maximumBit)
    {
        var maxK = 0;
        for (var i = 0; i < maximumBit; i++)
            maxK = (maxK << 1) + 1;

        var xorAll = 0;
        foreach (var num in nums)
            xorAll ^= num;

        var result = new int[nums.Length];
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            result[nums.Length - 1 - i] = (maxK ^ xorAll) & maxK;
            xorAll ^= nums[i];
        }

        return result;
    }
}
