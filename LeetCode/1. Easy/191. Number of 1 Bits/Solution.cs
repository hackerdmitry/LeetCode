namespace LeetCode._1._Easy._191._Number_of_1_Bits;

public class Solution
{
    public int HammingWeight(uint n)
    {
        var sum = 0;
        while (n != 0)
        {
            sum += (int)(n - (n >> 1 << 1));
            n >>= 1;
        }

        return sum;
    }
}
