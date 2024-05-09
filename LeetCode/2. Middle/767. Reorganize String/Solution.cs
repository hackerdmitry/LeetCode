using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._767._Reorganize_String;

public class Solution
{
    public string ReorganizeString(string s)
    {
        if (s.Length == 1)
            return s;

        var letterCounts = new LinkedList<(char, int)>(
            s.GroupBy(x => x)
                .Select(x => (x.Key, Value: x.Count()))
                .OrderByDescending(x => x.Value)
                .Select(x => (x.Key, x.Value)));

        if (letterCounts.Count == 1)
            return string.Empty;

        var result = new char[s.Length];
        var node = letterCounts.First;

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = node.Value.Item1;
            if (i + 1 == result.Length)
                break;

            node.Value = (node.Value.Item1, node.Value.Item2 - 1);
            var prevNode = node;
            node = node.Previous ?? node.Next;
            if (node == null)
                return string.Empty;
            if (prevNode.Value.Item2 == 0)
                letterCounts.Remove(prevNode);
        }

        return new string(result);
    }
}