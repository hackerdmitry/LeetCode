using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2685._Count_the_Number_of_Complete_Components;

public class Solution
{
    private readonly Queue<int> queue = new();

    public int CountCompleteComponents(int n, int[][] edges)
    {
        var map = CreateMap(n, edges);
        var visitedNodes = new bool[n];
        var startNode = -1;
        var visitedNodesCount = 0;
        var components = new HashSet<int>();
        var result = 0;
        while (visitedNodesCount < visitedNodes.Length)
        {
            while (visitedNodes[++startNode]) ;
            BFS(map, startNode, components, visitedNodes, ref visitedNodesCount);
            if (CheckComponents(map, components))
                result++;
            components.Clear();
        }

        return result;
    }

    private int[][] CreateMap(int n, int[][] edges)
    {
        var helpArray = new int[n];
        foreach (var edge in edges)
        {
            helpArray[edge[0]]++;
            helpArray[edge[1]]++;
        }

        var map = new int[n][];
        for (var i = 0; i < n; i++)
        {
            map[i] = new int[helpArray[i]];
            helpArray[i] = 0;
        }

        foreach (var edge in edges)
        {
            map[edge[0]][helpArray[edge[0]]++] = edge[1];
            map[edge[1]][helpArray[edge[1]]++] = edge[0];
        }

        return map;
    }

    private void BFS(int[][] map, int startNode, HashSet<int> components, bool[] visitedNodes, ref int visitedNodesCount)
    {
        queue.Enqueue(startNode);
        components.Add(startNode);
        visitedNodes[startNode] = true;
        visitedNodesCount++;
        while (queue.Count > 0)
        {
            var neighbours = map[queue.Dequeue()];
            foreach (var neighbour in neighbours)
                if (components.Add(neighbour))
                {
                    visitedNodes[neighbour] = true;
                    visitedNodesCount++;
                    queue.Enqueue(neighbour);
                }
        }
    }

    private bool CheckComponents(int[][] map, HashSet<int> components)
    {
        var expectedNeighboursLength = components.Count - 1;
        return components.All(x => map[x].Length == expectedNeighboursLength);
    }
}