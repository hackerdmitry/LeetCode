using System;
using System.Linq;

namespace LeetCode._2._Middle._781._Rabbits_in_Forest;

public class Solution
{
    public int NumRabbits(int[] answers)
    {
        return answers
            .GroupBy(x => x)
            .Sum(x => (x.Key + 1) * (int)Math.Ceiling(x.Count() / (x.Key + 1d)));
    }
}