using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1061._Lexicographically_Smallest_Equivalent_String;

public class Solution
{
    public string SmallestEquivalentString(string s1, string s2, string baseStr)
    {
        var transitivity = CreateNeighboursMap(s1, s2);
        var transformation = BFS(transitivity);
        return new string(baseStr.Select(c => transformation[c]).ToArray());
    }

    private static Dictionary<char, HashSet<char>> CreateNeighboursMap(string s1, string s2)
    {
        var transitivity = Enumerable.Range(0, 26).Select(i => (char)('a' + i)).ToDictionary(c => c, _ => new HashSet<char>(26));
        for (var i = 0; i < s1.Length; i++)
        {
            transitivity[s1[i]].Add(s2[i]);
            transitivity[s2[i]].Add(s1[i]);
        }

        return transitivity;
    }

    private static Dictionary<char, char> BFS(Dictionary<char, HashSet<char>> transitivity)
    {
        var transformation = new Dictionary<char, char>(26);
        var visited = new HashSet<char>(26);
        var queue = new Queue<char>();
        for (var c = 'a'; c <= 'z'; c++)
            if (!visited.Contains(c))
            {
                transformation[c] = c;
                queue.Enqueue(c);
                visited.Add(c);
                while (queue.Count > 0)
                {
                    var letter = queue.Dequeue();
                    foreach (var neighbour in transitivity[letter])
                        if (visited.Add(neighbour))
                        {
                            queue.Enqueue(neighbour);
                            transformation[neighbour] = c;
                        }
                }
            }

        return transformation;
    }
}