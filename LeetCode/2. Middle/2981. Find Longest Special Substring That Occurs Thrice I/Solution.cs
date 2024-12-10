using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2981._Find_Longest_Special_Substring_That_Occurs_Thrice_I;

public class Solution
{
    public int MaximumLength(string s)
    {
        var dict = new Dictionary<char, LinkedList<(int, int)>>();

        var startSequence = 0;
        for (var i = 1; i < s.Length; i++)
            if (s[i] != s[i - 1])
            {
                AddSequence(dict, s[i-1], i - startSequence);
                startSequence = i;
            }
        AddSequence(dict, s[^1], s.Length - startSequence);

        var result = dict.Max(x => FindMaxThrice(x.Value));
        return result == 0 ? -1 : result;
    }

    private void AddSequence(Dictionary<char, LinkedList<(int, int)>> dict, char symbol, int lenght)
    {
        if (!dict.ContainsKey(symbol))
            dict[symbol] = new LinkedList<(int, int)>();

        var linkedList = dict[symbol];
        if (linkedList.Count == 0 || linkedList.Last!.Value.Item1 < lenght)
        {
            linkedList.AddLast((lenght, 1));
            return;
        }

        var node = linkedList.Last;
        while (node != null)
        {
            if (node.Value.Item1 == lenght)
            {
                node.Value = (node.Value.Item1, node.Value.Item2 + 1);
                return;
            }

            if (node.Value.Item1 < lenght)
            {
                linkedList.AddAfter(node, (lenght, 1));
                return;
            }

            node = node.Previous;
        }

        linkedList.AddFirst((lenght, 1));
    }

    private int FindMaxThrice(LinkedList<(int, int)> sequences)
    {
        if (sequences.Count == 0)
            return 0;

        var lastValue = sequences.Last!.Value;
        if (lastValue.Item2 >= 3)
            return lastValue.Item1;

        if (lastValue.Item2 == 2 ||
            sequences.Count > 1 && sequences.Last.Previous!.Value.Item1 + 1 == lastValue.Item1)
            return Math.Max(0, lastValue.Item1 - 1);

        return Math.Max(0, lastValue.Item1 - 2);
    }
}
