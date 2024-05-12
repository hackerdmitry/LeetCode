using System;
using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._1._Easy._543._Diameter_of_Binary_Tree;

public class Solution
{
    public int DiameterOfBinaryTree(TreeNode root)
    {
        var parents = new Dictionary<TreeNode, TreeNode> {{root, null}};

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        TreeNode lastNode = null;
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            lastNode = node;

            if (node.left != null)
            {
                parents[node.left] = node;
                queue.Enqueue(node.left);
            }

            if (node.right != null)
            {
                parents[node.right] = node;
                queue.Enqueue(node.right);
            }
        }

        var visitNodes = new HashSet<TreeNode> {lastNode};
        var visitQueue = new Queue<(TreeNode, int)>();
        visitQueue.Enqueue((lastNode, 0));
        var maxSteps = 0;
        while (visitQueue.Count > 0)
        {
            var (node, steps) = visitQueue.Dequeue();
            maxSteps = Math.Max(maxSteps, steps);
            if (node.left != null && visitNodes.Add(node.left))
                visitQueue.Enqueue((node.left, steps + 1));
            if (node.right != null && visitNodes.Add(node.right))
                visitQueue.Enqueue((node.right, steps + 1));
            var parent = parents[node];
            if (parent != null && visitNodes.Add(parent))
                visitQueue.Enqueue((parent, steps + 1));
        }

        return maxSteps;
    }
}