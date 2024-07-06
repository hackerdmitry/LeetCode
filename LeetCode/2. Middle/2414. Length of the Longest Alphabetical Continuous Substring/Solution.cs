using System;

namespace LeetCode._2._Middle._2414._Length_of_the_Longest_Alphabetical_Continuous_Substring;

public class Solution
{
    public int LongestContinuousSubstring(string s)
    {
        var countLongestString = 1;
        var prevContinuous = -1;

        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] - 1 != s[i - 1])
            {
                if (prevContinuous != -1)
                {
                    countLongestString = Math.Max(i - prevContinuous, countLongestString);
                    prevContinuous = -1;
                }
            }
            else if (prevContinuous == -1)
                prevContinuous = i - 1;
        }

        if (prevContinuous != -1)
            countLongestString = Math.Max(s.Length - prevContinuous, countLongestString);

        return countLongestString;
    }
}