using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._2096._Step_By_Step_Directions_From_a_Binary_Tree_Node_to_Another;

public class Solution
{
    public string GetDirections(TreeNode root, int startValue, int destValue)
    {
        var parents = GetParents(root, startValue, out var startNode);

        var queue = new Queue<Node>();
        queue.Enqueue(new Node(startNode));

        while (true)
        {
            var node = queue.Dequeue();
            if (node.Current.val == destValue)
                return ToPath(node);

            if (parents.TryGetValue(node.Current.val, out var parentNode) && (node.Prev == null || node.Prev.Current.val != parentNode.val))
                queue.Enqueue(new Node(parentNode, node, 'U'));

            if (node.Current.left != null && (node.Prev == null || node.Prev.Current.val != node.Current.left.val))
                queue.Enqueue(new Node(node.Current.left, node, 'L'));

            if (node.Current.right != null && (node.Prev == null || node.Prev.Current.val != node.Current.right.val))
                queue.Enqueue(new Node(node.Current.right, node, 'R'));
        }
    }

    private string ToPath(Node node)
    {
        var path = new char[node.Count - 1];
        for (var i = node.Count - 2; i >= 0; i--)
        {
            path[i] = node.Direction!.Value;
            node = node.Prev;
        }

        return new string(path);
    }

    class Node
    {
        public TreeNode Current { get; set; }
        public Node Prev { get; set; }
        public char? Direction { get; set; }
        public int Count { get; set; }

        public Node(TreeNode current, Node prev = null, char? direction = null)
        {
            Current = current;
            Prev = prev;
            Direction = direction;
            Count = (prev?.Count ?? 0) + 1;
        }
    }

    private static Dictionary<int, TreeNode> GetParents(TreeNode root, int startValue, out TreeNode startNode)
    {
        startNode = null;
        var parents = new Dictionary<int, TreeNode>();

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (node.val == startValue)
                startNode = node;

            if (node.left != null)
            {
                parents[node.left.val] = node;
                queue.Enqueue(node.left);
            }

            if (node.right != null)
            {
                parents[node.right.val] = node;
                queue.Enqueue(node.right);
            }
        }

        return parents;
    }
}