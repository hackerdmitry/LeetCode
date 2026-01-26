using System.Collections.Generic;

namespace LeetCode._1._Easy._20._Valid_Parentheses;

public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
            if (c is '(' or '{' or '[')
                stack.Push(c);
            else
            {
                if (stack.Count == 0)
                    return false;

                var open = stack.Pop();
                if ((c == ')' && open != '(') ||
                    (c == '}' && open != '{') ||
                    (c == ']' && open != '['))
                    return false;
            }

        return stack.Count == 0;
    }
}
