using LeetCode.__TreeNode;
using NUnit.Framework;

namespace LeetCode._1._Easy._100._Same_Tree;

public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        return p == null && q == null || (p != null &&
                                          q != null &&
                                          p.val == q.val &&
                                          (p.left == null) ^ (q.left != null) &&
                                          (p.left == null || IsSameTree(p.left, q.left)) &&
                                          (p.right == null) ^ (q.right != null) &&
                                          (p.right == null || IsSameTree(p.right, q.right)));
    }
}