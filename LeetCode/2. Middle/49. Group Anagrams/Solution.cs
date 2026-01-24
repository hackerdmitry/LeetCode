using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._49._Group_Anagrams;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dictionary = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            var orderedStr = GetAnagramOrderedStr(str);
            if (!dictionary.ContainsKey(orderedStr))
                dictionary[orderedStr] = new List<string>();
            dictionary[orderedStr].Add(str);
        }

        return dictionary.Values.ToArray();
    }

    private string GetAnagramOrderedStr(string str)
    {
        Span<char> span = stackalloc char[str.Length];
        var index = 0;
        foreach (var c in str.OrderBy(x => x))
            span[index++] = c;
        return new string(span);
    }
}