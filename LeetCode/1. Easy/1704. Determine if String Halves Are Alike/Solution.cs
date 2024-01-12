using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._1704._Determine_if_String_Halves_Are_Alike;

public class Solution
{
    public bool HalvesAreAlike(string s)
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var a = Enumerable.Range(0, s.Length / 2).Count(i => vowels.Contains(s[i]));
        var b = Enumerable.Range(s.Length / 2, s.Length / 2).Count(i => vowels.Contains(s[i]));
        return a == b;
    }
}
