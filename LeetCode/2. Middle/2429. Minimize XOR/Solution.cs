namespace LeetCode._2._Middle._2429._Minimize_XOR;

public class Solution
{
    public int MinimizeXor(int num1, int num2)
    {
        var countBits1 = CountBits(num1);
        var countBits2 = CountBits(num2);
        return countBits1 > countBits2
            ? RemoveBits(num1, countBits1 - countBits2)
            : AddBits(num1, countBits2 - countBits1);
    }

    private int CountBits(int num)
    {
        var count = 0;
        while (num > 0)
        {
            count += num & 1;
            num >>= 1;
        }
        return count;
    }

    private int AddBits(int num, int countBits)
    {
        var bit = 1;
        while (countBits > 0)
        {
            if ((num & bit) == 0)
            {
                num ^= bit;
                countBits--;
            }
            bit <<= 1;
        }

        return num;
    }

    private int RemoveBits(int num, int countBits)
    {
        var bit = 1;
        while (countBits > 0)
        {
            if ((num & bit) > 0)
            {
                num ^= bit;
                countBits--;
            }
            bit <<= 1;
        }

        return num;
    }
}
