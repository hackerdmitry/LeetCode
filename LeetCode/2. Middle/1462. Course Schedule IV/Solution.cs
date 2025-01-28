using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1462._Course_Schedule_IV;

public class Solution
{
    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries)
    {
        var graph = CreateGraph(numCourses, prerequisites);
        FillPrerequisites(graph);

        var result = new bool[queries.Length];
        for (var i = 0; i < queries.Length; i++)
            result[i] = IsPrerequisite(queries[i][0], queries[i][1], graph);

        return result;
    }

    private Dictionary<int, Node> CreateGraph(int numCourses, int[][] prerequisites)
    {
        var graph = new Dictionary<int, Node>();
        for (var i = 0; i < numCourses; i++)
            graph[i] = new Node(i);

        foreach (var prerequisite in prerequisites)
        {
            var (from, to) = (prerequisite[0], prerequisite[1]);
            graph[to].AddFrom(graph[from]);
            graph[from].AddTo(graph[to]);
        }

        return graph;
    }

    private void FillPrerequisites(Dictionary<int, Node> graph)
    {
        var queue = new Queue<(Node Node, HashSet<int> Prerequisites)>();

        foreach (var node in graph.Values)
            if (node.ListTo.Count == 0 && node.ListFrom.Count > 0)
                queue.Enqueue((node, new HashSet<int>()));

        while (queue.Count > 0)
        {
            var (node, prerequisites) = queue.Dequeue();
            foreach (var prerequisite in prerequisites)
                node.Prerequisites.Add(prerequisite);
            prerequisites.Add(node.Index);

            foreach (var from in node.ListFrom)
                queue.Enqueue((from, prerequisites));
        }
    }

    private bool IsPrerequisite(int from, int to, Dictionary<int, Node> graph)
    {
        return graph[from].Prerequisites?.Contains(to) ?? false;
    }

    private class Node
    {
        public int Index { get; set; }
        public LinkedList<Node> ListFrom { get; set; }
        public LinkedList<Node> ListTo { get; set; }
        public HashSet<int> Prerequisites { get; set; }

        public Node(int index)
        {
            Index = index;
            ListFrom = new LinkedList<Node>();
            ListTo = new LinkedList<Node>();
            Prerequisites = new HashSet<int>();
        }

        public void AddTo(Node node)
        {
            ListTo.AddLast(node);
        }

        public void AddFrom(Node node)
        {
            ListFrom.AddLast(node);
        }

        public override string ToString()
        {
            var prerequisistes = Prerequisites != null
                ? $"{string.Join(", ", Prerequisites)}"
                : string.Empty;
            var from = string.Join(", ", ListFrom.Select(x => x.Index));
            var to = string.Join(", ", ListTo.Select(x => x.Index));
            return $"{Index}: [{prerequisistes}], from=[{from}], to=[{to}]";
        }
    }
}