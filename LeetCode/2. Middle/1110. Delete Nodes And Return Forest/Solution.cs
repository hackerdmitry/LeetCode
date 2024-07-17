using System.Collections.Generic;
using System.Linq;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._1110._Delete_Nodes_And_Return_Forest;

public class Solution
{
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
    {
        var toDelete = to_delete.ToHashSet();
        var roots = new List<TreeNode>();
        if (!toDelete.Contains(root.val))
            roots.Add(root);

        var queue = new Queue<(TreeNode, TreeNode, Direction?)>();
        queue.Enqueue((root, null, null));
        while (queue.Count > 0)
        {
            var (node, parent, direction) = queue.Dequeue();

            var shouldDelete = toDelete.Contains(node.val);
            if (shouldDelete && parent != null)
                if (direction == Direction.Left)
                    parent.left = null;
                else
                    parent.right = null;

            if (node.left != null)
            {
                queue.Enqueue((node.left, node, Direction.Left));
                if (shouldDelete && !toDelete.Contains(node.left.val))
                    roots.Add(node.left);
            }

            if (node.right != null)
            {
                queue.Enqueue((node.right, node, Direction.Right));
                if (shouldDelete && !toDelete.Contains(node.right.val))
                    roots.Add(node.right);
            }
        }

        return roots;
    }

    enum Direction
    {
        Left,
        Right,
    }
}
