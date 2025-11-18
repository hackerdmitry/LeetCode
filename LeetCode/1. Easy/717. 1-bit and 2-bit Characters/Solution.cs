namespace LeetCode._1._Easy._717._1_bit_and_2_bit_Characters;

public class Solution
{
    public bool IsOneBitCharacter(int[] bits)
    {
        var countOnesBeforeLast = 0;
        for (var i = bits.Length - 2; i >= 0 && bits[i] == 1; i--)
            countOnesBeforeLast++;
        return countOnesBeforeLast % 2 == 0;
    }
}
