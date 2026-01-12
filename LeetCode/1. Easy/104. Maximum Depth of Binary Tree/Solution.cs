using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._1._Easy._104._Maximum_Depth_of_Binary_Tree;

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        var maxDepth = 1;
        var queue = new Queue<(TreeNode node, int depth)>();
        queue.Enqueue((root, 1));
        while (queue.Count > 0)
        {
            var (node, depth) = queue.Dequeue();
            if (depth > maxDepth)
                maxDepth = depth;

            if (node.left != null)
                queue.Enqueue((node.left, depth + 1));

            if (node.right != null)
                queue.Enqueue((node.right, depth + 1));
        }

        return maxDepth;
    }
}
