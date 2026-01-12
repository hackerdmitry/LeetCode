using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._199._Binary_Tree_Right_Side_View;

public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        var result = new List<int>();
        if (root == null)
            return result;

        var queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 1));

        while (queue.Count > 0)
        {
            var (node, depth) = queue.Dequeue();
            if (depth > result.Count)
                result.Add(node.val);
            if (node.right != null)
                queue.Enqueue((node.right, depth + 1));
            if (node.left != null)
                queue.Enqueue((node.left, depth + 1));
        }

        return result;
    }
}
