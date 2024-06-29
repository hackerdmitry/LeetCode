using System.Collections.Generic;

namespace LeetCode._2._Middle._2192._All_Ancestors_of_a_Node_in_a_Directed_Acyclic_Graph;

public class Solution
{
    public IList<IList<int>> GetAncestors(int n, int[][] edges)
    {
        var toEdges = new Dictionary<int, LinkedList<int>>();

        foreach (var edge in edges)
        {
            var from = edge[0];
            var to = edge[1];
            if (!toEdges.ContainsKey(from))
                toEdges[from] = new LinkedList<int>();
            toEdges[from].AddLast(to);
        }

        var result = new List<int>[n];
        for (var i = 0; i < n; i++)
            result[i] = new List<int>();

        var queue = new Queue<int>();
        for (var i = 0; i < n; i++)
        {
            queue.Enqueue(i);
            while (queue.Count > 0)
            {
                var from = queue.Dequeue();
                if (toEdges.TryGetValue(from, out var tos))
                    foreach (var to in tos)
                        if (result[to].Count == 0 || result[to][^1] != i)
                        {
                            result[to].Add(i);
                            queue.Enqueue(to);
                        }
            }
        }

        return result;
    }
}