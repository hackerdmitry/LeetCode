using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode._2._Middle._394._Decode_String;

public class Solution
{
    public string DecodeString(string s)
    {
        var index = 0;
        return ReadString(s, ref index).ToString();
    }

    private StringBuilder ReadString(string s, ref int index)
    {
        var result = new StringBuilder();
        while (index != s.Length && s[index] != ']')
        {
            if (char.IsDigit(s[index]))
            {
                var num = ReadNumber(s, ref index);
                var str = ReadString(s, ref index);
                result.AppendJoin(string.Empty, Enumerable.Repeat(str, num));
            }
            else
                result.Append(s[index]);

            index++;
        }

        return result;
    }

    private int ReadNumber(string s, ref int index)
    {
        var result = 0;
        while (char.IsDigit(s[index]))
            result = result * 10 + s[index++] - '0';
        index++;
        return result;
    }
}
