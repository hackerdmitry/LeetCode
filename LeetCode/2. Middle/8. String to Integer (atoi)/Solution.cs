using System.Linq;

namespace LeetCode._2._Middle._8._String_to_Integer__atoi_;

public class Solution
{
    public int MyAtoi(string s)
    {
        // Whitespace
        s = s.TrimStart();

        // Signedness
        var sign = 1;
        if (s.Length > 0 && (s[0] == '-' || s[0] == '+'))
        {
            sign = s[0] == '-' ? -1 : 1;
            s = s[1..];
        }

        // Conversion
        var result = 0;
        foreach (var letter in s.TakeWhile(char.IsDigit))
        {
            var digit = letter - '0';
            try
            {
                checked
                {
                    result = result * 10 + digit * sign;
                }
            }
            catch
            {
                // Rounding
                return sign == -1 ? int.MinValue : int.MaxValue;
            }
        }

        return result;
    }
}