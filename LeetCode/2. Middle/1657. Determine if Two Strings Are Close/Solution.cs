using System;
using System.Linq;

namespace LeetCode._2._Middle._1657._Determine_if_Two_Strings_Are_Close;

public class Solution
{
    public bool CloseStrings(string word1, string word2)
    {
        var letters1 = new bool[26];
        var counts1 = new int[26];
        foreach (var x in word1.Select(c => c - 'a'))
        {
            letters1[x] = true;
            counts1[x]++;
        }

        var letters2 = new bool[26];
        var counts2 = new int[26];
        foreach (var x in word2.Select(c => c - 'a'))
        {
            letters2[x] = true;
            counts2[x]++;
        }

        Array.Sort(counts1);
        Array.Sort(counts2);

        return Enumerable.Range(0, 26).All(i => letters1[i] == letters2[i]) &&
               Enumerable.Range(0, 26).All(i => counts1[i] == counts2[i]);
    }
}
