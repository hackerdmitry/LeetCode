using System;

namespace LeetCode._2._Middle._1750._Minimum_Length_of_String_After_Deleting_Similar_Ends;

public class Solution
{
    public int MinimumLength(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right &&  s[left] == s[right])
        {
            do left++; while (left < right && s[left] == s[left - 1]);
            do right--; while (right > left && s[right] == s[right + 1]);
        }

        return Math.Max(0, right - left + 1);
    }
}