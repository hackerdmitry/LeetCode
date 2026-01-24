using System.Collections.Generic;

namespace LeetCode._1._Easy._290._Word_Pattern;

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var words = new string[26];
        var splittedWords = s.Split(' ');
        var visitedWords = new HashSet<string>();

        if (pattern.Length != splittedWords.Length)
            return false;

        for (var i = 0; i < pattern.Length; i++)
        {
            var word = words[pattern[i] - 'a'];
            if (word == null && !visitedWords.Contains(splittedWords[i]))
            {
                words[pattern[i] - 'a'] = splittedWords[i];
                visitedWords.Add(splittedWords[i]);
            }
            else if (word != splittedWords[i])
                return false;
        }

        return true;
    }
}