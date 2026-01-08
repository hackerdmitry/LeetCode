using System;

namespace LeetCode._1._Easy._1071._Greatest_Common_Divisor_of_Strings;

public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        var gcdLen = Gcd(str1.Length, str2.Length) + 1;
        while (--gcdLen > 0)
            if (str1.Length % gcdLen == 0 && str2.Length % gcdLen == 0 && SubEqual(str1, str2, gcdLen) && IsRepeat(str1, gcdLen) && IsRepeat(str2, gcdLen))
                return str1[..gcdLen];
        return string.Empty;
    }

    private bool SubEqual(string str1, string str2, int len)
    {
        for (var i = 0; i < len; i++)
            if (str1[i] != str2[i])
                return false;
        return true;
    }

    private bool IsRepeat(string str, int len)
    {
        if (str.Length == len)
            return true;

        if (str.Length % len != 0)
            return false;

        for (var i = 0; i < len; i++)
        {
            var letter = str[i];
            for (var j = i + len; j < str.Length; j += len)
                if (letter != str[j])
                    return false;
        }

        return true;
    }

    private int Gcd(int num1, int num2)
    {
        while (num1 != 0 && num2 != 0)
            if (num1 > num2)
                num1 %= num2;
            else
                num2 %= num1;

        return Math.Max(num1, num2);
    }
}