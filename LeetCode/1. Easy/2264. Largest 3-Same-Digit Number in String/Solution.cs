using System.Collections.Generic;

namespace LeetCode._1._Easy._2264._Largest_3_Same_Digit_Number_in_String;

public class Solution
{
    public string LargestGoodInteger(string num)
    {
        var maxDigit = -1;

        for (var i = 2; i < num.Length; i++)
            if (num[i - 2] == num[i - 1] && num[i - 1] == num[i] && num[i] - '0' > maxDigit)
                maxDigit = num[i] - '0';

        return maxDigit == -1 ? "" : new string((char)(maxDigit + '0'), 3);
    }
}
