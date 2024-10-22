using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._1._Easy._222._Count_Complete_Tree_Nodes;

public class Solution
{
    public int CountNodes(TreeNode root)
    {
        if (root == null)
            return 0;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var numNodes = 1;

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (node.right != null)
            {
                queue.Enqueue(node.right);
                numNodes++;
            }

            if (node.left != null)
            {
                queue.Enqueue(node.left);
                numNodes++;
            }
        }

        return numNodes;
    }
}