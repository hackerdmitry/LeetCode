using System.Collections.Generic;

namespace LeetCode._1._Easy._3174._Clear_Digits;

public class Solution
{
    public string ClearDigits(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
            if (char.IsDigit(c))
            {
                if (stack.Count > 0)
                    stack.Pop();
            }
            else
                stack.Push(c);

        var result = new char[stack.Count];
        for (var i = stack.Count - 1; i >= 0; i--)
            result[i] = stack.Pop();
        return new string(result);
    }
}
