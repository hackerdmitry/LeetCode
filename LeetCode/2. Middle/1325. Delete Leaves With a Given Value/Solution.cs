using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._1325._Delete_Leaves_With_a_Given_Value;

public class Solution
{
    public TreeNode RemoveLeafNodes(TreeNode root, int target)
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var stack = new Stack<(TreeNode node, TreeNode parent, Side side)>();
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node.left != null)
            {
                queue.Enqueue(node.left);
                stack.Push((node.left, node, Side.Left));
            }
            if (node.right != null)
            {
                queue.Enqueue(node.right);
                stack.Push((node.right, node, Side.Right));
            }
        }

        while (stack.Count > 0)
        {
            var (node, parent, side) = stack.Pop();
            if (node.left == null && node.right == null && node.val == target)
                if (side == Side.Left)
                    parent.left = null;
                else
                    parent.right = null;
        }

        return root.left == null && root.right == null && root.val == target ? null : root;
    }

    enum Side
    {
        Left,
        Right,
    }
}