namespace LeetCode._2._Middle._12._Integer_to_Roman;

public class Solution
{
    private static readonly string[][] romans =
    {
        new[] {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},
        new[] {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},
        new[] {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"},
        new[] {"", "M", "MM", "MMM"},
    };

    public string IntToRoman(int num)
    {
        var index = 0;
        var result = string.Empty;

        while (num > 0)
        {
            result = romans[index++][num % 10] + result;
            num /= 10;
        }

        return result;
    }
}