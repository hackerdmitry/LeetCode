using System;

namespace LeetCode._1._Easy._3110._Score_of_a_String;

public class Solution
{
    public int ScoreOfString(string s)
    {
        var sum = 0;
        for (var i = 1; i < s.Length; i++)
            sum += Math.Abs(s[i] - s[i - 1]);
        return sum;
    }
}