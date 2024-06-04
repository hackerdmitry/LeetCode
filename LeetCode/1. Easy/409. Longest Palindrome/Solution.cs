using System.Linq;

namespace LeetCode._1._Easy._409._Longest_Palindrome;

public class Solution
{
    public int LongestPalindrome(string s)
    {
        var letters = s.GroupBy(x => x).Select(x => x.Count()).ToArray();
        var result = 0;

        foreach (var letterCount in letters)
            result += letterCount % 2 == 0 || result % 2 != 1 ? letterCount : letterCount - 1;

        return result;
    }
}