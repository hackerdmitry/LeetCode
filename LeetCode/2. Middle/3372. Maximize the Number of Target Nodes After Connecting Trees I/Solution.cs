using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3372._Maximize_the_Number_of_Target_Nodes_After_Connecting_Trees_I;

public class Solution
{
    private HashSet<int> visited = new();
    private Queue<(Node, int)> queue = new();

    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k)
    {
        var tree1 = CreateTree(edges1);
        var tree2 = CreateTree(edges2);
        var additionalCountNodes = k == 0 ? 0 : GetMaxCountTargets(tree2, k - 1);
        return tree1.Select(node => CountTargets(node, k) + additionalCountNodes).ToArray();
    }

    private int GetMaxCountTargets(Node[] tree, int k)
    {
        return tree.Max(node => CountTargets(node, k));
    }

    private int CountTargets(Node node, int k)
    {
        if (k == 0)
            return 1;

        queue.Enqueue((node, 0));
        visited.Clear();
        visited.Add(node.Id);

        while (queue.Count > 0)
        {
            var (targetNode, pathLength) = queue.Dequeue();
            var nextPathLength = pathLength + 1;
            foreach (var neighbourNode in targetNode.Neighbours)
                if (visited.Add(neighbourNode.Id) && nextPathLength < k)
                    queue.Enqueue((neighbourNode, nextPathLength));
        }

        return visited.Count;
    }

    private Node[] CreateTree(int[][] edges)
    {
        var tree = new Node[edges.Length + 1];
        for (var i = 0; i < tree.Length; i++)
            tree[i] = new Node(i);

        foreach (var edge in edges)
        {
            tree[edge[0]].Neighbours.Add(tree[edge[1]]);
            tree[edge[1]].Neighbours.Add(tree[edge[0]]);
        }

        return tree;
    }

    private class Node
    {
        public int Id { get; set; }
        public List<Node> Neighbours { get; set; } = new();

        public Node(int id)
        {
            Id = id;
        }
    }
}
