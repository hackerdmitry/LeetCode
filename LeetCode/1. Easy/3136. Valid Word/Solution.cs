using System.Collections.Generic;

namespace LeetCode._1._Easy._3136._Valid_Word;

public class Solution
{
    private static readonly HashSet<char> invalidSymbols = new(new[] {'@', '#', '$'});
    private static readonly HashSet<char> vowelSymbols = new(new[] {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'});

    public bool IsValid(string word)
    {
        if (word.Length < 3)
            return false;

        var isOneVowel = false;
        var isOneConsonant = false;
        foreach (var c in word)
            if (invalidSymbols.Contains(c))
                return false;
            else if (char.IsLetter(c))
                if (vowelSymbols.Contains(c))
                    isOneVowel = true;
                else
                    isOneConsonant = true;

        return isOneVowel && isOneConsonant;
    }
}