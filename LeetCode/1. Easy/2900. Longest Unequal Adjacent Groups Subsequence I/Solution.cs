using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._2900._Longest_Unequal_Adjacent_Groups_Subsequence_I;

public class Solution
{
    public IList<string> GetLongestSubsequence(string[] words, int[] groups)
    {
        return Enumerable.Range(0, groups.Length)
            .Where(i => i == 0 || groups[i] != groups[i - 1])
            .Select(i => words[i])
            .ToArray();
    }
}
