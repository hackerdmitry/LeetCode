namespace LeetCode._1._Easy._66._Plus_One;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (var i = digits.Length - 1; i >= 0; i--)
            if (digits[i] != 9)
            {
                digits[i]++;
                break;
            }
            else
                digits[i] = 0;
        return digits[0] == 0
            ? CreateRoundNumber(digits.Length)
            : digits;
    }

    private int[] CreateRoundNumber(int zeroCount)
    {
        var number = new int[zeroCount + 1];
        number[0] = 1;
        return number;
    }
}
