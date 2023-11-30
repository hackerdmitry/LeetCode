namespace LeetCode._3._Hard._1611._Minimum_One_Bit_Operations_to_Make_Integers_Zero;

public class Solution
{
    public int MinimumOneBitOperations(int n)
    {
        var k = 0;
        var k2 = 1;

        while (k < n)
        {
            k = (k << 1) + 1;
            k2 <<= 1;
        }
        k2 >>= 1;
        n ^= k2;

        var result = k;
        var posSign = false;
        for (; n > 0; k >>= 1, k2 >>= 1)
            if (k2 <= n)
            {
                result += posSign ? k : -k;
                n ^= k2;
                posSign = !posSign;
            }

        return result;
    }
}
