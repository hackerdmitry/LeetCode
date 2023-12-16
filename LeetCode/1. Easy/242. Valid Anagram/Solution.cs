namespace LeetCode._1._Easy._242._Valid_Anagram;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var anagramS = new int[26];
        var anagramT = new int[26];

        for (var i = 0; i < s.Length; i++)
        {
            anagramS[s[i] - 'a']++;
            anagramT[t[i] - 'a']++;
        }

        for (var i = 0; i < 26; i++)
            if (anagramS[i] != anagramT[i])
                return false;

        return true;
    }
}
