using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2785._Sort_Vowels_in_a_String;

public class Solution
{
    public string SortVowels(string s)
    {
        var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

        var t = new char[s.Length];
        var orderedVowels = s.Where(x => vowels.Contains(x)).OrderBy(x => x).ToArray();
        var orderedVowelsIndex = 0;
        for (var i = 0; i < s.Length; i++)
        {
            t[i] = vowels.Contains(s[i]) ? orderedVowels[orderedVowelsIndex++] : s[i];
        }

        return new string(t);
    }
}
