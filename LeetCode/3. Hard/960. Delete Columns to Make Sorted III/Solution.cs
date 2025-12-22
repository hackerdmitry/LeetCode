using System;

namespace LeetCode._3._Hard._960._Delete_Columns_to_Make_Sorted_III;

public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        var n = strs[0].Length;
        var maxLexicographicalLength = 1;

        var maxLength = new int[n];
        maxLength[0] = 1;

        for (var i = 1; i < n; i++)
        {
            maxLength[i] = 1;

            for (var j = 0; j < i; j++)
            {
                var isLexicographical = true;

                for (var k = 0; k < strs.Length; k++)
                    if (strs[k][j] > strs[k][i])
                    {
                        isLexicographical = false;
                        break;
                    }

                if (isLexicographical)
                    maxLength[i] = Math.Max(maxLength[i], maxLength[j] + 1);
            }

            maxLexicographicalLength = Math.Max(maxLexicographicalLength, maxLength[i]);
        }

        return n - maxLexicographicalLength;
    }
}
