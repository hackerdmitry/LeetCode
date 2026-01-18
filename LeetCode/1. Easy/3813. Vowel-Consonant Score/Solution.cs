using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._3813._Vowel_Consonant_Score;

public class Solution
{
    private static readonly HashSet<char> vowels = new() {'a', 'e', 'i', 'o', 'u'};

    public int VowelConsonantScore(string s)
    {
        var v = s.Count(x => char.IsLetter(x) && vowels.Contains(x));
        var c = s.Count(x => char.IsLetter(x) && !vowels.Contains(x));
        return c > 0 ? v / c : 0;
    }
}