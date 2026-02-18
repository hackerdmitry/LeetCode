namespace LeetCode._1._Easy._693._Binary_Number_with_Alternating_Bits;

public class Solution
{
    public bool HasAlternatingBits(int n)
    {
        while (n > 0 && (n & 1) != ((n >>= 1) & 1)) ;
        return n == 0;
    }
}
