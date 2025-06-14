namespace LeetCode._1._Easy._2566._Maximum_Difference_by_Remapping_a_Digit;

public class Solution
{
    public int MinMaxDifference(int num)
    {
        return ReplaceDigit(num, GetMaxFirstDigit(num), 9) -
               ReplaceDigit(num, GetFirstDigit(num), 0);
    }

    private int GetFirstDigit(int num)
    {
        while (num > 9)
            num /= 10;
        return num;
    }

    private int GetMaxFirstDigit(int num)
    {
        var maxFirstDigit = 9;
        while (num > 0)
        {
            if (num % 10 != 9)
                maxFirstDigit = num % 10;
            num /= 10;
        }

        return maxFirstDigit;
    }

    private int ReplaceDigit(int num, int sourceDigit, int destinationDigit)
    {
        var order = 1;
        var result = 0;
        while (num > 0)
        {
            var currDigit = num % 10;
            if (currDigit == sourceDigit)
                currDigit = destinationDigit;
            result += currDigit * order;
            order *= 10;
            num /= 10;
        }

        return result;
    }
}