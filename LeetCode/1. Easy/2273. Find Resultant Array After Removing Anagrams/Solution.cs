using System.Collections.Generic;

namespace LeetCode._1._Easy._2273._Find_Resultant_Array_After_Removing_Anagrams;

public class Solution
{
    public IList<string> RemoveAnagrams(string[] words)
    {
        var anagramHelper = new int[26];
        var result = new List<string>(words.Length) {words[0]};
        for (var i = 1; i < words.Length; i++)
            if (!AreAnagrams(anagramHelper, words[i - 1], words[i]))
                result.Add(words[i]);
        return result;
    }

    private bool AreAnagrams(int[] anagramHelper, string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        foreach (var c in s1)
            anagramHelper[c - 'a']++;

        foreach (var c in s2)
            anagramHelper[c - 'a']--;

        var result = true;
        for (var i = 0; i < anagramHelper.Length; i++)
            if (anagramHelper[i] != 0)
            {
                anagramHelper[i] = 0;
                result = false;
            }

        return result;
    }
}