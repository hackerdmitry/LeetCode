using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._1002._Find_Common_Characters;

public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        var letters1 = new int[26];
        FillArray(letters1, words[0]);

        var letters2 = new int[26];
        foreach (var word in words.Skip(1))
        {
            FillArray(letters2, word);
            IntersectDifference(letters1, letters2);
        }

        return ToList(letters1);
    }

    private List<string> ToList(int[] letters)
    {
        var result = new List<string>();
        for (var i = 0; i < letters.Length; i++)
        {
            var letter = ((char)(i + 'a')).ToString();
            while (letters[i] > 0)
            {
                result.Add(letter);
                letters[i]--;
            }
        }
        return result;
    }

    private void FillArray(int[] letters, string word)
    {
        foreach (var letter in word)
            letters[letter - 'a']++;
    }

    private void IntersectDifference(int[] letters1, int[] letters2)
    {
        for (var i = 0; i < letters1.Length; i++)
        {
            letters1[i] = Math.Min(letters1[i], letters2[i]);
            letters2[i] = 0;
        }
    }
}
