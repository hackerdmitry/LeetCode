using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._3461._Check_If_Digits_Are_Equal_in_String_After_Operations_I;

public class Solution
{
    public bool HasSameDigits(string s)
    {
        while (s.Length != 2)
            s = new string(Operation(s).ToArray());
        return s[0] == s[1];
    }

    private IEnumerable<char> Operation(string s)
    {
        for (var i = 1; i < s.Length; i++)
            yield return (char) ('0' + (s[i - 1] - '0' + s[i] - '0') % 10);
    }
}
