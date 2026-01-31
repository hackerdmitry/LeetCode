using System.Collections.Generic;

namespace LeetCode._1._Easy._3823._Reverse_Letters_Then_Special_Characters_in_a_String;

public class Solution
{
    public string ReverseByType(string s)
    {
        var letters = new Stack<char>();
        var symbols = new Stack<char>();

        foreach (var c in s)
            if (char.IsLetter(c))
                letters.Push(c);
            else
                symbols.Push(c);

        var result = new char[s.Length];
        for (var i = 0; i < s.Length; i++)
            if (char.IsLetter(s[i]))
                result[i] = letters.Pop();
            else
                result[i] = symbols.Pop();
        return new string(result);
    }
}