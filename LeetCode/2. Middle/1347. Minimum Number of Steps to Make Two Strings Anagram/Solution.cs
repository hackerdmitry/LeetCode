using System;
using System.Linq;

namespace LeetCode._2._Middle._1347._Minimum_Number_of_Steps_to_Make_Two_Strings_Anagram;

public class Solution
{
    public int MinSteps(string s, string t)
    {
        var sLetters = s.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        var tLetters = t.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        var diffSum = Enumerable.Range('a', 26).Sum(x =>
        {
            var c = (char)x;
            sLetters.TryGetValue(c, out var sCount);
            tLetters.TryGetValue(c, out var tCount);
            return Math.Abs(sCount - tCount);
        });

        return diffSum / 2;
    }
}
