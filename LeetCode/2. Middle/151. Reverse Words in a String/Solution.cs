using System;
using System.Linq;

namespace LeetCode._2._Middle._151._Reverse_Words_in_a_String;

public class Solution
{
    public string ReverseWords(string s)
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return string.Join(' ', words.Reverse());
    }
}
