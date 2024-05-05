using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._1._Easy._101._Symmetric_Tree;

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root.left == null ^ root.right == null)
            return false;
        if (root.left == null && root.right == null)
            return true;

        var queueLeft = new Queue<TreeNode>();
        queueLeft.Enqueue(root.left);

        var queueRight = new Queue<TreeNode>();
        queueRight.Enqueue(root.right);

        while (queueLeft.Count > 0 && queueRight.Count > 0)
        {
            var left = queueLeft.Dequeue();
            var right = queueRight.Dequeue();

            if (left.val != right.val ||
                left.left == null ^ right.right == null ||
                left.right == null ^ right.left == null)
                return false;

            if (left.left != null)
            {
                queueLeft.Enqueue(left.left);
                queueRight.Enqueue(right.right);
            }

            if (left.right != null)
            {
                queueLeft.Enqueue(left.right);
                queueRight.Enqueue(right.left);
            }
        }

        return true;
    }
}