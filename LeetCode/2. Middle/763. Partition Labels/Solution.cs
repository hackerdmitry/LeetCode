using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._763._Partition_Labels;

public class Solution
{
    public IList<int> PartitionLabels(string s)
    {
        var lastIndexes = new int[26];
        for (var i = 0; i < s.Length; i++)
            lastIndexes[s[i] - 'a'] = i;
        var result = new List<int>();
        var maxIndex = 0;
        var sumResult = 0;
        for (var i = 0; i < s.Length; i++)
        {
            maxIndex = Math.Max(maxIndex, lastIndexes[s[i] - 'a']);
            if (i == maxIndex)
            {
                var valueResult = i + 1 - sumResult;
                result.Add(valueResult);
                sumResult += valueResult;
            }
        }

        return result;
    }
}
