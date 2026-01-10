using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1456._Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length;

public class Solution
{
    private static readonly HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };

    public int MaxVowels(string s, int k)
    {
        var currentCountVowels = s.Take(k).Count(vowels.Contains);
        var maxCountVowels = currentCountVowels;
        for (var i = k; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
                currentCountVowels++;
            if (vowels.Contains(s[i - k]))
                currentCountVowels--;
            maxCountVowels = Math.Max(maxCountVowels, currentCountVowels);
        }
        return maxCountVowels;
    }
}
