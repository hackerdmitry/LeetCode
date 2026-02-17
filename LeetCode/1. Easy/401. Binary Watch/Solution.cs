using System.Collections.Generic;

namespace LeetCode._1._Easy._401._Binary_Watch;

public class Solution
{
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        var result = new List<string>();
        for (var h = 0; h < 12; h++)
            for (var m = 0; m < 60; m++)
                if (CountBits(h) + CountBits(m) == turnedOn)
                    result.Add(FormatTime(h, m));
        return result;
    }

    private int CountBits(int n)
    {
        var count = 0;
        while (n > 0)
        {
            count += n & 1;
            n >>= 1;
        }

        return count;
    }

    private string FormatTime(int h, int m)
    {
        return $"{h}:{m:D2}";
    }
}