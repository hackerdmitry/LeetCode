using System;
using System.Linq;

namespace LeetCode._1._Easy._1422._Maximum_Score_After_Splitting_a_String;

public class Solution
{
    public int MaxScore(string s)
    {
        var left = s[0] == '0' ? 1 : 0;
        var right = s.Skip(1).Count(x => x == '1');
        var maxScore = left + right;

        for (var i = 1; i < s.Length - 1; i++)
        {
            if (s[i] == '0')
                left++;
            else
                right--;
            maxScore = Math.Max(left + right, maxScore);
        }

        return maxScore;
    }
}
