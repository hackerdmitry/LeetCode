using System.Collections.Generic;

namespace LeetCode._2._Middle._3713._Longest_Balanced_Substring_I;

public class Solution
{
    public int LongestBalanced(string s)
    {
        var maxLength = 0;
        var balancedLetters = new BalancedLetters();

        for (var length = 1; length <= s.Length; length++)
        {
            for (var r = 0; r < length; r++)
                balancedLetters.AddLetter(s[r]);

            for (var r = length; r < s.Length; r++)
            {
                if (balancedLetters.IsBalanced())
                    break;
                balancedLetters.RemoveLetter(s[r - length]);
                balancedLetters.AddLetter(s[r]);
            }

            if (balancedLetters.IsBalanced())
                maxLength = length;

            balancedLetters.Clear();
        }

        return maxLength;
    }

    private class BalancedLetters
    {
        private readonly int[] countLetters = new int[26];
        private readonly Dictionary<int, int> countLettersDict = new(26);

        public void AddLetter(char letter)
        {
            var countLetter = countLetters[letter - 'a'];
            if (countLetter > 0)
            {
                countLettersDict[countLetter]--;
                if (countLettersDict[countLetter] == 0)
                    countLettersDict.Remove(countLetter);
            }
            countLetter = ++countLetters[letter - 'a'];
            if (!countLettersDict.TryAdd(countLetter, 1))
                countLettersDict[countLetter]++;
        }

        public void RemoveLetter(char letter)
        {
            var countLetter = countLetters[letter - 'a'];
            countLettersDict[countLetter]--;
            if (countLettersDict[countLetter] == 0)
                countLettersDict.Remove(countLetter);
            countLetter = --countLetters[letter - 'a'];
            if (countLetter > 0 && !countLettersDict.TryAdd(countLetter, 1))
                countLettersDict[countLetter]++;
        }

        public void Clear()
        {
            countLettersDict.Clear();
            for (var i = 0; i < 26; i++)
                countLetters[i] = 0;
        }

        public bool IsBalanced()
        {
            return countLettersDict.Count == 1;
        }
    }
}