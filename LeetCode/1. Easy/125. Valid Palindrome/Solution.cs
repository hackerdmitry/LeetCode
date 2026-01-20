using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._125._Valid_Palindrome;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        return GetValidChars(s).Zip(GetValidChars(s.Reverse())).All(c => c.First == c.Second);
    }

    private IEnumerable<char> GetValidChars(IEnumerable<char> s)
    {
        foreach (var c in s)
            if (char.IsLetterOrDigit(c))
                yield return char.ToLower(c);
    }
}
