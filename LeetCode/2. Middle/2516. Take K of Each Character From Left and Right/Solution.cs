using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2516._Take_K_of_Each_Character_From_Left_and_Right;

public class Solution
{
    public int TakeCharacters(string s, int k)
    {
        if (k == 0)
            return 0;

        var counts = new Dictionary<char, int>(3);

        for (var i = 0; i < s.Length; i++)
            if (!counts.TryAdd(s[i], 1))
                counts[s[i]]++;

        if (counts.Count != 3 || counts.Any(x => x.Value < k))
            return -1;

        var minLength = s.Length;
        var left = 0;
        for (var right = 0; right < s.Length; right++)
        {
            counts[s[right]]--;
            while (counts[s[right]] < k)
                counts[s[left++]]++;
            minLength = Math.Min(minLength, s.Length - right + left - 1);
        }

        return minLength;
    }
}