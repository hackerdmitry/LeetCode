using System.Collections.Generic;

namespace LeetCode._2._Middle._1915._Number_of_Wonderful_Substrings;

public class Solution
{
    public long WonderfulSubstrings(string word)
    {
        var freq = new Dictionary<int, int> { [0] = 1 };
        var letters = new[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

        var result = 0L;
        var mask = 0;

        foreach (var c in word)
        {
            mask ^= 1 << (c - 'a');

            if (freq.ContainsKey(mask))
            {
                result += freq[mask];
                freq[mask]++;
            }
            else freq[mask] = 1;

            foreach (var letter in letters)
                if (freq.ContainsKey(mask ^ letter))
                    result += freq[mask ^ letter];
        }

        return result;
    }
}