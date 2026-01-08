using System.Collections.Generic;

namespace LeetCode._2._Middle._443._String_Compression;

public class Solution
{
    public int Compress(char[] chars)
    {
        var index = 0;

        var streak = 1;
        for (var i = 1; i < chars.Length; i++)
            if (chars[i] != chars[i - 1])
            {
                chars[index++] = chars[i - 1];
                AddStreak(ref index, chars, streak);
                streak = 1;
            }
            else
                streak++;

        chars[index++] = chars[^1];
        AddStreak(ref index, chars, streak);

        return index;
    }

    private void AddStreak(ref int index, char[] chars, int streak)
    {
        if (streak == 1)
            return;

        var length = Len(streak);
        for (var i = length - 1; i >= 0; i--)
        {
            chars[index + i] = (char)('0' + streak % 10);
            streak /= 10;
        }

        index += length;
    }

    private int Len(int num)
    {
        var result = 0;
        while (num > 0)
        {
            result++;
            num /= 10;
        }
        return result;
    }
}
