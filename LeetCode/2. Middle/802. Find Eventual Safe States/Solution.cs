using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._802._Find_Eventual_Safe_States;

public class Solution
{
    public IList<int> EventualSafeNodes(int[][] graph)
    {
        var isSafeNodes = new bool[graph.Length];
        for (var i = 0; i < graph.Length; i++)
            if (graph[i].Length == 0)
                isSafeNodes[i] = true;

        while (true)
        {
            var addedSafeNodes = 0;
            for (var i = 0; i < graph.Length; i++)
                if (!isSafeNodes[i] && graph[i].All(nodeToIndex => isSafeNodes[nodeToIndex]))
                {
                    isSafeNodes[i] = true;
                    addedSafeNodes++;
                }

            if (addedSafeNodes == 0)
                break;
        }

        return isSafeNodes
            .Select((x, i) => (x, i))
            .Where(x => x.x)
            .Select(x => x.i)
            .ToArray();
    }
}