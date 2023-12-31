using System;

namespace LeetCode._1._Easy._1624._Largest_Substring_Between_Two_Equal_Characters;

public class Solution
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        var lettersStart = new int[26];
        var lettersEnd = new int[26];

        for (var i = 0; i < s.Length; i++)
            if (lettersStart[s[i] - 'a'] == 0)
                lettersStart[s[i] - 'a'] = i + 1;

        for (int i = s.Length - 1; i >= 0; i--)
            if (lettersEnd[s[i] - 'a'] == 0)
                lettersEnd[s[i] - 'a'] = i + 1;

        var maxLength = -1;
        for (var i = 0; i < 26; i++)
            if (lettersEnd[i] != lettersStart[i])
                maxLength = Math.Max(lettersEnd[i] - lettersStart[i] - 1, maxLength);

        return maxLength;
    }
}
