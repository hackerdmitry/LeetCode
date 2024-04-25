using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2370._Longest_Ideal_Subsequence;

public class Solution
{
    public int LongestIdealString(string s, int k)
    {
        var dictionaryAlphabet = new Dictionary<char, int>();

        foreach (var c in s)
        {
            var start = (char)Math.Max(c - k, 'a');
            var end = (char)Math.Min(c + k, 'z');

            var result = 0;
            for (var i = start; i <= end; i++)
                if (dictionaryAlphabet.ContainsKey(i) && dictionaryAlphabet[i] > result)
                    result = dictionaryAlphabet[i];
            dictionaryAlphabet[c] = result + 1;
        }

        return dictionaryAlphabet.Max(x => x.Value);
    }
}