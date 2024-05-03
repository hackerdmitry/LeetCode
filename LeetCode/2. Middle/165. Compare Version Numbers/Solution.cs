using System;

namespace LeetCode._2._Middle._165._Compare_Version_Numbers;

public class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        var revisions1 = Array.ConvertAll(version1.Split('.'), int.Parse);
        var revisions2 = Array.ConvertAll(version2.Split('.'), int.Parse);

        var minLen = Math.Min(revisions1.Length, revisions2.Length);
        var maxLen = Math.Max(revisions1.Length, revisions2.Length);
        for (var i = 0; i < minLen; i++)
        {
            if (revisions1[i] < revisions2[i])
                return -1;
            if (revisions1[i] > revisions2[i])
                return 1;
        }

        for (var i = minLen; i < maxLen; i++)
        {
            if (i < revisions1.Length && revisions1[i] > 0)
                return 1;
            if (i < revisions2.Length && revisions2[i] > 0)
                return -1;
        }

        return 0;
    }
}