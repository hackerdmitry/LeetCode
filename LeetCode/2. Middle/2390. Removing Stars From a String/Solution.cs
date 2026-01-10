using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._2390._Removing_Stars_From_a_String;

public class Solution
{
    public string RemoveStars(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
            if (c == '*')
                stack.TryPop(out _);
            else
                stack.Push(c);

        Span<char> span = stackalloc char[stack.Count];
        for (var i = span.Length - 1; i >= 0; i--)
            span[i] = stack.Pop();
        return new string(span);
    }
}
