namespace LeetCode._2._Middle._2411._Smallest_Subarrays_With_Maximum_Bitwise_OR;

public class Solution
{
    private const int leftUnit = 536_870_912;

    public int[] SmallestSubarrays(int[] nums)
    {
        var maxBitwise = new int[30];
        var maxBitwiseNum = -1;
        for (var i = 0; i < nums.Length; i++)
            maxBitwiseNum = AddNumber(maxBitwise, nums[i]);

        var bitwise = new int[30];
        var bitwiseNum = -1;
        var right = 0;

        var result = new int[nums.Length];

        for (var left = 0; left < nums.Length; left++)
        {
            while (right != nums.Length && (bitwiseNum != maxBitwiseNum || right == left))
                bitwiseNum = AddNumber(bitwise, nums[right++]);
            result[left] = right - left;
            bitwiseNum = RemoveNumber(bitwise, nums[left]);
            maxBitwiseNum = RemoveNumber(maxBitwise, nums[left]);
        }

        return result;
    }

    private int AddNumber(int[] bitwise, int number)
    {
        var result = 0;
        for (var i = 0; i < bitwise.Length; i++)
        {
            result >>= 1;
            if (number % 2 == 1)
                bitwise[i]++;
            if (bitwise[i] > 0)
                result |= leftUnit;
            number >>= 1;
        }

        return result;
    }

    private int RemoveNumber(int[] bitwise, int number)
    {
        var result = 0;
        for (var i = 0; i < bitwise.Length; i++)
        {
            result >>= 1;
            if (number % 2 == 1)
                bitwise[i]--;
            if (bitwise[i] > 0)
                result |= leftUnit;
            number >>= 1;
        }

        return result;
    }
}
