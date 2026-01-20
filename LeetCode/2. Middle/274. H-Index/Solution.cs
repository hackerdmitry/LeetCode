using System;
using System.Linq;

namespace LeetCode._2._Middle._274._H_Index;

public class Solution
{
    public int HIndex(int[] citations)
    {
        Array.Sort(citations, (a, b) => b.CompareTo(a));
        return Enumerable.Range(1, citations.Length).LastOrDefault(h => h <= citations[h - 1]);
    }
}
