using System.Linq;

namespace LeetCode._1._Easy._2138._Divide_a_String_Into_Groups_of_Size_k;

public class Solution
{
    public string[] DivideString(string s, int k, char fill)
    {
        var substrings = Enumerable.Repeat(0, GetSubstringLength(s, k)).Select(_ => new char[k]).ToArray();
        var counter = 0;
        foreach (var substring in substrings)
            for (var i = 0; i < k; i++)
                substring[i] = counter == s.Length ? fill : s[counter++];
        return substrings.Select(ss => new string(ss)).ToArray();
    }

    private int GetSubstringLength(string s, int k) =>
        s.Length % k > 0 ? s.Length / k + 1 : s.Length / k;
}
