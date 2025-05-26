using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._2131._Longest_Palindrome_by_Concatenating_Two_Letter_Words;

public class Solution
{
    public int LongestPalindrome(string[] words)
    {
        var palindromeLength = 0;
        var groupedPairs = CreateGroupedPairs(words);

        foreach (var (key, value) in groupedPairs)
        {
            var first = key >> 5;
            var second = key & 0b11111;

            if (first == second)
                if (palindromeLength % 2 != 0 && value % 2 != 0)
                    palindromeLength = palindromeLength - palindromeLength % 2 + value;
                else
                    palindromeLength += value;
            else if (first < second && groupedPairs.TryGetValue((second << 5) ^ first, out var reversedValue))
                palindromeLength += Math.Min(value, reversedValue) * 2;
        }

        return palindromeLength * 2;
    }

    private Dictionary<int, int> CreateGroupedPairs(string[] words)
    {
        var groupedPairs = new Dictionary<int, int>();
        foreach (var word in words)
        {
            var key = ToKey(word);
            if (!groupedPairs.TryAdd(key, 1))
                groupedPairs[key]++;
        }

        return groupedPairs;
    }

    private static int ToKey(string pair)
    {
        return ((pair[0] - 'a') << 5) ^ (pair[1] - 'a');
    }
}