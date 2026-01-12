using System;
using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._1448._Count_Good_Nodes_in_Binary_Tree;

public class Solution
{
    public int GoodNodes(TreeNode root)
    {
        var queue = new Queue<(TreeNode, int)>();
        var result = 0;
        queue.Enqueue((root, root.val));

        while (queue.Count > 0)
        {
            var (node, maxValue) = queue.Dequeue();
            if (node.val >= maxValue)
            {
                result++;
                maxValue = node.val;
            }

            if (node.left != null)
                queue.Enqueue((node.left, maxValue));
            if (node.right != null)
                queue.Enqueue((node.right, maxValue));
        }

        return result;
    }
}
