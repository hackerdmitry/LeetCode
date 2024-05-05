using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._1._Easy._938._Range_Sum_of_BST;

public class Solution
{
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        var sum = 0;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (low <= node.val && node.val <= high)
                sum += node.val;
            if (node.left != null)
                queue.Enqueue(node.left);
            if (node.right != null)
                queue.Enqueue(node.right);
        }

        return sum;
    }
}