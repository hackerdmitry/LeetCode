using System;

namespace LeetCode._1._Easy._1758._Minimum_Changes_To_Make_Alternating_Binary_String;

public class Solution
{
    public int MinOperations(string s)
    {
        var v1 = 0;
        var v2 = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0 ^ s[i] == '0')
                v1++;
            else
                v2++;
        }

        return Math.Min(v1, v2);
    }
}
