namespace LeetCode._1._Easy._190._Reverse_Bits;

public class Solution
{
    public int ReverseBits(int n)
    {
        var reversed = 0;
        for (var i = 0; i < 32; i++)
        {
            reversed = (reversed << 1) + n % 2;
            n >>= 1;
        }

        return reversed;
    }
}
