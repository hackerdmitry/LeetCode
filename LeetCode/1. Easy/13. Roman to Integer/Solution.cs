using System.Collections.Generic;

namespace LeetCode._1._Easy._13._Roman_to_Integer;

public class Solution
{
    private static readonly Dictionary<char, int> romans = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
    };

    public int RomanToInt(string s)
    {
        var result = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var current = romans[s[i]];
            if (i < s.Length - 1)
            {
                var next = romans[s[i + 1]];
                if (next > current)
                {
                    result += next - current;
                    i++;
                    continue;
                }
            }

            result += current;
        }

        return result;
    }
}