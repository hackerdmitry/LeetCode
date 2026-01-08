using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._345._Reverse_Vowels_of_a_String;

public class Solution
{
    private static readonly HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    public string ReverseVowels(string s)
    {
        var strVowels = s.Where(vowels.Contains).Reverse().ToArray();
        var vowelIndex = 0;
        return new string(s.Select(x => vowels.Contains(x) ? strVowels[vowelIndex++] : x).ToArray());
    }
}