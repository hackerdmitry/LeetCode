using System;

namespace LeetCode._2._Middle._6._Zigzag_Conversion;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        var chars = new char[s.Length];
        var charsIndex = 0;
        var cycle = Math.Max(1, (numRows - 1) * 2);
        for (var start = 0; start < numRows; start++)
        {
            var stepDown = (numRows - start - 1) * 2;
            var stepUp = cycle - stepDown;

            var i = start;
            for (var isDown = true; i < s.Length; isDown = !isDown)
            {
                chars[charsIndex++] = s[i];

                if (start == 0 || start == numRows - 1)
                    i += cycle;
                else if (isDown)
                    i += stepDown;
                else
                    i += stepUp;
            }
        }

        return new string(chars);
    }
}