using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1190._Reverse_Substrings_Between_Each_Pair_of_Parentheses;

public class Solution
{
    public string ReverseParentheses(string s)
    {
        var resultLetters = new char[s.Count(c => !IsBracket(c))];

        var stack = new Stack<int>();
        var queue = new Queue<(int, int)>();

        for (int i = 0, j = 0; j < s.Length; j++)
            switch (s[j])
            {
                case '(':
                    stack.Push(i);
                    break;
                case ')':
                    var startIndex = stack.Pop();
                    queue.Enqueue((startIndex, i - 1));
                    break;
                default:
                    resultLetters[i++] = s[j];
                    break;
            }

        while (queue.Count > 0)
            for (var (i, j) = queue.Dequeue(); i < j; i++, j--)
                (resultLetters[i], resultLetters[j]) = (resultLetters[j], resultLetters[i]);

        return new string(resultLetters);
    }

    private bool IsBracket(char c) => c is '(' or ')';
}
