using System;
using System.IO;

namespace LeetCode._2._Middle._3133._Minimum_Array_End;

public class Solution
{
    public long MinEnd(int n, int x)
    {
        n--;

        var countXBinaryOnes = CountBinaryOnes(x);
        var countXBinaryDigits = CountBinaryDigits(x);
        var countNBinaryDigits = CountBinaryDigits(n);
        var countResultBinaryDigits = Math.Max(countXBinaryOnes + countNBinaryDigits, countXBinaryDigits);

        var reversedResult = 0L;

        while (n > 0 || x > 0)
        {
            reversedResult <<= 1;

            if ((x & 1) == 0)
            {
                reversedResult += n & 1;
                n >>= 1;
            }
            else
                reversedResult += x & 1;

            x >>= 1;
        }

        return ReverseNumber(reversedResult, countResultBinaryDigits);
    }

    private int CountBinaryOnes(int number)
    {
        var countOnes = 0;
        while (number != 0)
        {
            if (number % 2 == 1)
                countOnes++;
            number >>= 1;
        }

        return countOnes;
    }

    private int CountBinaryDigits(int number)
    {
        var countDigits = 0;
        while (number != 0)
        {
            countDigits++;
            number >>= 1;
        }

        return countDigits;
    }

    private long ReverseNumber(long reversedNumber, int countBinaryDigits)
    {
        var number = 0L;
        while (reversedNumber > 0)
        {
            number = (number << 1) + (reversedNumber & 1);
            reversedNumber >>= 1;
            countBinaryDigits--;
        }

        while (countBinaryDigits-- > 0)
            number <<= 1;

        return number;
    }
}