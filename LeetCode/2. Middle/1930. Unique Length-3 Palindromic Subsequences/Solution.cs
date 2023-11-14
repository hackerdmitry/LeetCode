using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LeetCode._2._Middle._1930._Unique_Length_3_Palindromic_Subsequences;

public class Solution
{
    public int CountPalindromicSubsequence(string s)
    {
        var positions = new Dictionary<int, List<int>>();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (positions.ContainsKey(c))
                positions[c].Add(i);
            else
                positions[c] = new List<int> { i };
        }

        var checks = new bool[26, 26];
        var result = 0;
        foreach (var (letter, letterPositions) in positions)
        {
            if (letterPositions.Count < 2)
                continue;

            var startPos = letterPositions[0];
            var endPos = letterPositions[^1];

            for (var i = startPos + 1; i < endPos; i++)
            {
                if (!checks[letter - 'a', s[i] - 'a'])
                {
                    checks[letter - 'a', s[i] - 'a'] = true;
                    result++;
                }
            }
        }

        return result;
    }
}
