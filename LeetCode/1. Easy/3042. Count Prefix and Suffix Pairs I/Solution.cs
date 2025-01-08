using System.Linq;

namespace LeetCode._1._Easy._3042._Count_Prefix_and_Suffix_Pairs_I;

public class Solution
{
    public int CountPrefixSuffixPairs(string[] words) =>
        words
            .Select((word1, i) => words.Skip(i + 1).Count(word2 => word2.StartsWith(word1) && word2.EndsWith(word1)))
            .Sum();
}