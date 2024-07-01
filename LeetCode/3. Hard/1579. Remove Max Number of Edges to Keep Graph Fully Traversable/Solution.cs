using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._1579._Remove_Max_Number_of_Edges_to_Keep_Graph_Fully_Traversable;

public class Solution
{
    public int MaxNumEdgesToRemove(int n, int[][] edges)
    {
        var visitedByAlice = new HashSet<int>();
        var visitedByBob = new HashSet<int>();

        var edgeMap = new Dictionary<int, LinkedList<Edge>>();
        for (var i = 0; i < edges.Length; i++)
        {
            var edgeArr = edges[i];
            var (type, from, to) = ((EdgeType)edgeArr[0], edgeArr[1] - 1, edgeArr[2] - 1);

            var edgeFrom = new Edge(i, type, to);
            if (!edgeMap.ContainsKey(from))
                edgeMap[from] = new LinkedList<Edge>();
            if (type == EdgeType.Both)
                edgeMap[from].AddFirst(edgeFrom);
            else
                edgeMap[from].AddLast(edgeFrom);

            var edgeTo = new Edge(i, type, from);
            if (!edgeMap.ContainsKey(to))
                edgeMap[to] = new LinkedList<Edge>();
            if (type == EdgeType.Both)
                edgeMap[to].AddFirst(edgeTo);
            else
                edgeMap[to].AddLast(edgeTo);
        }

        var touchedEdges = new bool[edges.Length];

        var queueAlice = new Queue<int>();
        queueAlice.Enqueue(0);
        visitedByAlice.Add(0);
        while (visitedByAlice.Count != n && queueAlice.Count > 0)
        {
            var pointIndex = queueAlice.Dequeue();
            var possibleEdges = edgeMap[pointIndex];
            foreach (var possibleEdge in possibleEdges)
                if (!visitedByAlice.Contains(possibleEdge.to) && possibleEdge.type is EdgeType.Both or EdgeType.Alice)
                {
                    touchedEdges[possibleEdge.index] = true;
                    visitedByAlice.Add(possibleEdge.to);
                    queueAlice.Enqueue(possibleEdge.to);
                }
        }
        if (visitedByAlice.Count != n)
            return -1;

        var queueBob = new Queue<int>();
        queueBob.Enqueue(0);
        visitedByBob.Add(0);
        while (visitedByBob.Count != n && queueBob.Count > 0)
        {
            var pointIndex = queueBob.Dequeue();
            var possibleEdges = edgeMap[pointIndex];
            foreach (var possibleEdge in possibleEdges)
                if (!visitedByBob.Contains(possibleEdge.to) && possibleEdge.type is EdgeType.Both or EdgeType.Bob)
                {
                    touchedEdges[possibleEdge.index] = true;
                    visitedByBob.Add(possibleEdge.to);
                    queueBob.Enqueue(possibleEdge.to);
                }
        }
        if (visitedByBob.Count != n)
            return -1;

        return touchedEdges.Count(x => !x);
    }

    record Edge(int index, EdgeType type, int to);

    enum EdgeType
    {
        Alice = 1,
        Bob = 2,
        Both = 3,
    }
}