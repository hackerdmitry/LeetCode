using System;

namespace LeetCode._1._Easy._14._Longest_Common_Prefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return string.Empty;
        if (strs.Length == 1)
            return strs[0];

        var result = FindLongestPrefix(strs[0], strs[1]);
        for (var i = 1; i < strs.Length; i++)
            result = FindLongestPrefix(result, strs[i]);

        return result;
    }

    private string FindLongestPrefix(string s1, string s2)
    {
        for (var i = 0; i < s1.Length && i < s2.Length; i++)
            if (s1[i] != s2[i])
                return s1[..i];
        return s1[..Math.Min(s1.Length, s2.Length)];
    }
}
