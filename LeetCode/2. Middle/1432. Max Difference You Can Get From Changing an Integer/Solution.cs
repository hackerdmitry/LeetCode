namespace LeetCode._2._Middle._1432._Max_Difference_You_Can_Get_From_Changing_an_Integer;

public class Solution
{
    public int MaxDiff(int num)
    {
        var order = GetOrder(num);
        var leadDigit = num / order;
        var afterLeadDigit = GetAfterLeadDigit(num, order);
        var max = leadDigit == 9
            ? ReplaceDigit(num, afterLeadDigit, 9)
            : ReplaceDigit(num, leadDigit, 9);
        var min = leadDigit == afterLeadDigit || leadDigit != 1
            ? ReplaceDigit(num, leadDigit, 1)
            : afterLeadDigit > 0
                ? ReplaceDigit(num, afterLeadDigit, 0)
                : ReplaceDigit(num, GetAfterAfterLeadDigit(num, order), 0);
        return max - min;
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

    private int GetAfterLeadDigit(int num, int order)
    {
        var leadDigit = num / order;
        num %= order;
        order /= 10;

        while (num > 0)
        {
            var currDigit = num / order;
            if (currDigit != leadDigit)
                return currDigit;
            num %= order;
            order /= 10;
        }

        return leadDigit;
    }

    private int GetAfterAfterLeadDigit(int num, int order)
    {
        while (num > 0)
        {
            var currDigit = num / order;
            if (currDigit > 1)
                return currDigit;
            num %= order;
            order /= 10;
        }

        return 0;
    }

    private int GetOrder(int num)
    {
        var order = 1;
        while (num > 9)
        {
            num /= 10;
            order *= 10;
        }

        return order;
    }
}