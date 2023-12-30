using System.Linq;

namespace LeetCode._1._Easy._1897._Redistribute_Characters_to_Make_All_Strings_Equal;

public class Solution
{
    public bool MakeEqual(string[] words)
    {
        var letters = new int[26];
        foreach (var word in words)
            foreach (var letter in word)
                letters[letter - 'a']++;

        for (var i = 0; i < 26; i++)
            if (letters[i] != 0 && letters[i] % words.Length != 0)
                return false;

        return true;
    }
}
