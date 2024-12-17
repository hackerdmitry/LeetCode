using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2182._Construct_String_With_Repeat_Limit;

public class Solution
{
    public string RepeatLimitedString(string s, int repeatLimit)
    {
        var dictionary = CreateDictionary(s);
        var linkedList = CreateLinkedList(dictionary);
        var node = linkedList.First;
        var result = new LinkedList<char>();

        while (node != null)
            if (dictionary[node.Value] <= repeatLimit)
            {
                while (dictionary[node.Value]-- > 0)
                    result.AddLast(node.Value);
                dictionary.Remove(node.Value);
                var next = node.Next;
                linkedList.Remove(node);
                node = next;
            }
            else
            {
                for (var _ = 0; _ < repeatLimit; _++)
                    result.AddLast(node.Value);
                dictionary[node.Value] -= repeatLimit;
                node = node.Next;
                if (node != null)
                {
                    result.AddLast(node.Value);
                    dictionary[node.Value]--;
                    var previous = node.Previous;
                    if (dictionary[node.Value] == 0)
                    {
                        dictionary.Remove(node.Value);
                        linkedList.Remove(node);
                    }
                    node = previous;
                }
            }

        return new string(result.ToArray());
    }

    private Dictionary<char, int> CreateDictionary(string s) =>
        s.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

    private LinkedList<char> CreateLinkedList(Dictionary<char, int> dictionary) =>
        new(dictionary.Keys.OrderByDescending(x => x));
}
