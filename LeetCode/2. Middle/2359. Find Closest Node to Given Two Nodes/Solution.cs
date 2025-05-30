namespace LeetCode._2._Middle._2359._Find_Closest_Node_to_Given_Two_Nodes;

public class Solution
{
    public int ClosestMeetingNode(int[] edges, int node1, int node2)
    {
        if (node1 == node2)
            return node1;

        var tree = CreateTree(edges);
        return FindMeetingNode(tree[node1], tree[node2])?.Id ?? -1;
    }

    private Node FindMeetingNode(Node node1, Node node2)
    {
        node1.Owner = Owner.Node1;
        node2.Owner = Owner.Node2;

        while (node1 != null || node2 != null)
        {
            node1 = MoveTo(node1);
            node2 = MoveTo(node2);
            if (node1?.Owner == Owner.Node2 || node2?.Owner == Owner.Node1)
                return DetectTarget(node1, node2);
        }

        return null;
    }

    private Node MoveTo(Node node)
    {
        if (node?.To != null)
        {
            if (node.To.Owner == Owner.Nobody)
            {
                node.To.Owner = node.Owner;
                node.To.Step = node.Step + 1;
                return node.To;
            }

            if (node.To.Owner != node.Owner)
                return node.To;
        }

        return null;
    }

    private Node DetectTarget(Node node1, Node node2)
    {
        if (node1?.Owner == Owner.Node2 && node2?.Owner == Owner.Node1)
            return node1.Id < node2.Id ? node1 : node2;
        return node1 == null || node2?.Owner == Owner.Node1
            ? node2
            : node1;
    }

    private Node[] CreateTree(int[] edges)
    {
        var tree = new Node[edges.Length];
        for (var i = 0; i < edges.Length; i++)
            tree[i] = new Node {Id = i};
        for (var i = 0; i < edges.Length; i++)
            tree[i].To = edges[i] != -1 ? tree[edges[i]] : null;
        return tree;
    }

    private class Node
    {
        public int Id { get; set; }
        public int Step { get; set; }
        public Node To { get; set; }
        public Owner Owner { get; set; } = Owner.Nobody;
    }

    private enum Owner
    {
        Nobody,
        Node1,
        Node2,
    }
}
