using System;
using System.Linq;

namespace LeetCode._1._Easy._3442._Maximum_Difference_Between_Even_and_Odd_Frequency_I;

public class Solution
{
    public int MaxDifference(string s)
    {
        var countLetters = s.GroupBy(x => x).Select(x => x.Count()).ToArray();
        var maxOdd = int.MinValue;
        var minEven = int.MaxValue;
        foreach (var countLetter in countLetters)
            if (countLetter % 2 == 0)
                minEven = Math.Min(minEven, countLetter);
            else
                maxOdd = Math.Max(maxOdd, countLetter);
        return maxOdd - minEven;
    }
}
